using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using MetadataExtractor;
using System.Drawing.Imaging;

namespace galeria
{
    public partial class Form1 : Form
    {
        List<PlikGraficzny> pliki = new List<PlikGraficzny>();
        GMapControl mapa = new GMapControl();
        static readonly string SERWER = "localhost";
        static readonly string BAZA_DANYCH = "galeria";
        static readonly string UZYTKOWNIK = "root";
        static readonly string HASLO = string.Empty;
        MySqlConnection polaczenie = new MySqlConnection("SERVER=" + SERWER + ";" + "DATABASE=" + BAZA_DANYCH + ";" + "UID=" + UZYTKOWNIK + ";" + "PASSWORD=" + HASLO + ";");

        public Form1()
        {
            InitializeComponent();
            wygenerujMape(mapa);
            try
            {
                polaczenie.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void wygenerujMape(GMapControl mapa)
        {
            panelMapa.Controls.Add(mapa);
            mapa.Dock = DockStyle.Fill;
            mapa.MapProvider = GoogleSatelliteMapProvider.Instance;
            mapa.MinZoom = 0;
            mapa.MaxZoom = 20;
            mapa.OnMarkerClick += Mapa_OnMarkerClick;
        }

        private void Mapa_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            duzyObraz.Image = ((PlikGraficzny)item.Tag).grafika;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data wykonania: " + ((PlikGraficzny)item.Tag).dataWykonania.ToString("dd-MM-yyyy"));
            sb.AppendLine("Wymiary: " + ((PlikGraficzny)item.Tag).dlugoscZdjecia + " na " + ((PlikGraficzny)item.Tag).szerokoscZdjecia + " pikseli");
            daneExif.Text = sb.ToString();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != string.Empty)
            {
                pliki.Clear();
                string[] plikiTemp = System.IO.Directory.GetFiles(fbd.SelectedPath);
                IEnumerable<string> plikiTemp2 = plikiTemp.Where<string>(x => x.EndsWith(".jpg") || x.EndsWith(".png") || x.EndsWith(".bmp"));
                foreach (string plik in  plikiTemp2)
                {
                    pliki.Add(new PlikGraficzny(new Bitmap(plik),plik));
                }
                dodajZdjeciaDoMapy(mapa, pliki);
            }
        }

        private void dodajZdjeciaDoMapy(GMapControl mapa, List<PlikGraficzny> zdjecia)
        {
            GMapOverlay znaczniki = new GMapOverlay();
            foreach (PlikGraficzny zdjecie in zdjecia)
            {
                int wysokosc = zdjecie.grafika.Height > zdjecie.grafika.Width ? 50 : Convert.ToInt32(50f * (Convert.ToDouble(zdjecie.grafika.Width) / Convert.ToDouble(zdjecie.grafika.Height)));
                int szerokosc = zdjecie.grafika.Height > zdjecie.grafika.Width ? Convert.ToInt32(50f * (Convert.ToDouble(zdjecie.grafika.Height) / Convert.ToDouble(zdjecie.grafika.Width))) : 50;
                GMapMarker znacznik = new GMarkerGoogle(new PointLatLng(zdjecie.Szerokosc, zdjecie.Dlugosc), new Bitmap(zdjecie.grafika.GetThumbnailImage(wysokosc, szerokosc, new Image.GetThumbnailImageAbort(()=>false), IntPtr.Zero)));
                znacznik.Tag = zdjecie;
                znaczniki.Markers.Add(znacznik);
            }
            mapa.Overlays.Clear();
            mapa.Overlays.Add(znaczniki);
        }

        private void wBazieDancychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (PlikGraficzny zdj in pliki)
                {
                    MySqlCommand msc = new MySqlCommand(null, polaczenie);
                    msc.CommandText = "INSERT INTO zdjecia VALUES(null, ?sciezka, ?szerokoscGeo, ?dlugoscGeo, ?szerokoscZdj, ?wysokoscZdj, ?datWykonania)";
                    msc.Parameters.Add("?sciezka", MySqlDbType.Text).Value = zdj.sciezka;
                    msc.Parameters.Add("?szerokoscGeo", MySqlDbType.Double).Value = zdj.Szerokosc;
                    msc.Parameters.Add("?dlugoscGeo", MySqlDbType.Double).Value = zdj.Dlugosc;
                    msc.Parameters.Add("?szerokoscZdj", MySqlDbType.Int32).Value = zdj.szerokoscZdjecia;
                    msc.Parameters.Add("?wysokoscZdj", MySqlDbType.Int32).Value = zdj.dlugoscZdjecia;
                    msc.Parameters.Add("?datWykonania", MySqlDbType.Date).Value = zdj.dataWykonania;
                    msc.ExecuteNonQuery();
                }
                MessageBox.Show("Informacje o plikach zostały zapisane w bazie danych");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void pobierz_Click(object sender, EventArgs e)
        {
            try
            {
                pliki.Clear();
                MySqlDataAdapter msda;
                if (wszystkie.Checked)
                {
                    msda = new MySqlDataAdapter("SELECT * FROM zdjecia", polaczenie);
                }
                else
                {
                    DateTime a = new DateTime(int.Parse(rok1.Text), int.Parse(miesiac1.Text), int.Parse(dzien1.Text));
                    DateTime b = new DateTime(int.Parse(rok2.Text), int.Parse(miesiac2.Text), int.Parse(dzien2.Text));
                    msda = new MySqlDataAdapter("SELECT * FROM zdjecia WHERE datWykonania BETWEEN @data1 AND @data2", polaczenie);
                    msda.SelectCommand.Parameters.AddWithValue("@data1", a.ToString("yyyy-MM-dd"));
                    msda.SelectCommand.Parameters.AddWithValue("@data2", b.ToString("yyyy-MM-dd"));
                }
                DataSet ds = new DataSet();
                msda.Fill(ds, "zdjecia");
                DataTable dt = ds.Tables["zdjecia"];
                foreach (DataRow rekord in dt.Rows)
                {
                    pliki.Add(new PlikGraficzny(rekord["sciezka"].ToString(), double.Parse(rekord["szerokoscGeo"].ToString()), double.Parse(rekord["dlugoscGeo"].ToString()),
                        int.Parse(rekord["szerokoscZdj"].ToString()), int.Parse(rekord["wysokoscZdj"].ToString()), rekord["datWykonania"].ToString()));
                }
                dodajZdjeciaDoMapy(mapa, pliki);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (ArgumentOutOfRangeException aooe)
            {
                MessageBox.Show(aooe.Message);
            }
            catch (MySqlException mse)
            {
                MessageBox.Show(mse.Message);
            }
        }
    }
}
