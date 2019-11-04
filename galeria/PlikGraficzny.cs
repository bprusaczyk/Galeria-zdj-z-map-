using MetadataExtractor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace galeria
{
    class PlikGraficzny
    {
        public Bitmap grafika;
        public string sciezka;
        public DateTime dataWykonania;
        public string szerokoscZdjecia;
        public string dlugoscZdjecia;
        private double dlugosc;
        private string dlugoscKierunek;
        private double szerokosc;
        private string szerokoscKierunek;

        public double Dlugosc
        {
            get
            {
                if (dlugoscKierunek=="E")
                {
                    return dlugosc;
                }
                else
                {
                    return -dlugosc;
                }
            }
            set
            {
                if (value > 0)
                {
                    dlugosc = value;
                    dlugoscKierunek = "E";
                }
                else
                {
                    dlugosc = -value;
                    dlugoscKierunek = "W";
                }
            }
        }

        public double Szerokosc
        {
            get
            {
                if (szerokoscKierunek == "N")
                {
                    return szerokosc;
                }
                else
                {
                    return -szerokosc;
                }
            }
            set
            {
                if (value > 0)
                {
                    szerokosc = value;
                    szerokoscKierunek = "N";
                }
                else
                {
                    szerokosc = -value;
                    szerokoscKierunek = "S";
                }
            }
        }

        public PlikGraficzny(Bitmap grafika, string sciezka)
        {
            this.grafika = grafika;
            this.sciezka = sciezka;
            var directories = ImageMetadataReader.ReadMetadata(sciezka);
            foreach (var directory in directories)
            {
                if (directory.Name == "GPS")
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "GPS Longitude")
                        {
                            string wspolrzedne;
                            wspolrzedne = tag.Description;
                            dlugosc = zwrocWspolrzedne(wspolrzedne);
                        }
                        if (tag.Name == "GPS Longitude Ref")
                        {
                            dlugoscKierunek = tag.Description;
                        }
                        if (tag.Name == "GPS Latitude")
                        {
                            string wspolrzedne;
                            wspolrzedne = tag.Description;
                            szerokosc = zwrocWspolrzedne(wspolrzedne);
                        }
                        if (tag.Name == "GPS Latitude Ref")
                        {
                            szerokoscKierunek = tag.Description;
                        }
                        if (tag.Name == "GPS Date Stamp")
                        {
                            string[] pom = tag.Description.Split(':');
                            dataWykonania = new DateTime(Int32.Parse(pom[0]), Int32.Parse(pom[1]), Int32.Parse(pom[2]));
                        }
                    }
                }
                if (directory.Name == "JPEG")
                {
                    foreach (var tag in directory.Tags)
                    {
                        if (tag.Name == "Image Height")
                        {
                            dlugoscZdjecia = tag.Description.Replace(" pixels", "");
                        }
                        if (tag.Name == "Image Width")
                        {
                            szerokoscZdjecia = tag.Description.Replace(" pixels", "");
                        }
                    }
                }
            }
        }

        public PlikGraficzny(string sciezka, double szerokoscG, double dlugoscG, int szerokoscZ, int wysokoscZ, string data)
        {
            this.sciezka = sciezka;
            Szerokosc = szerokoscG;
            Dlugosc = dlugoscG;
            szerokoscZdjecia = szerokoscZ.ToString();
            dlugoscZdjecia = wysokoscZ.ToString();
            string[] pom = data.Split('-');
            dataWykonania = new DateTime(int.Parse(pom[0]), int.Parse(pom[1]), int.Parse(pom[2].Replace(" 00:00:00", "")));
            grafika = new Bitmap(sciezka);
        }
        
        private double zwrocWspolrzedne(string wspolrzedne)
        {
            string[] pom = wspolrzedne.Split();
            double[] wynik = new double[3];
            for (int i = 0; i < pom.Length; i++)
            {
                string x = pom[i].Replace("\"", "").Replace("°", "").Replace("'", "");
                x = x.Contains(",") ? x : x + ",0";
                wynik[i] = Convert.ToDouble(x);
            }
            return wynik[0]+wynik[1]/60+wynik[2]/360;
        }
    }
}
