using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galeria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

/*
Stwórz program typu galeria zdjęć z wyświetlaniem miniaturek zdjęć na mapie w miejscu zrobienia zdjęcia.

Funkcjonalności:
Pobranie plików graficznych z wybranego katalogu.
Wyciągnięcie danych exif z plików graficznych.
Wyświetlenie miniaturek obrazów i jednego powiększonego pliku.
Wyświetlenie wybranych danych Exif w opisie pliku.
Wyświetlenie na mapie miniaturek plików w miejscu opisanym przez dane Exif pliku.
Funkcjonalności na ocenę powyżej 4:
Zapis danych o plikach w bazie danych.
Wyciągnięcie danych o plikach z bazy danych z możliwością filtracji (np. po dacie).
Wyświetlenie miniaturek odfiltrowanych obrazów na mapie.
*/
