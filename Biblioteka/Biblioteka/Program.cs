using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteka
{
    class Tools
    {
        public static Int32 Menu()
        {
            Console.Clear();
            Int32 odp;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("(1)Wyświetlanie tabeli");
            Console.WriteLine("(2)Dodaj do tabeli");
            Console.WriteLine("(3)Wyjście");
            Console.WriteLine("------------------------------");
            odp = Int32.Parse(Console.ReadLine());
            Int32 wyjscowa = 0;

            switch (odp)
            {
                case 1: //Pod menu Wyswietlania
                    Console.Clear();
                    while (wyjscowa!=1)
                    {
                      wyjscowa = MenuWyswietlania();
                    }
                    
                    break;
                case 2: // Podmenu dodawania
                    Console.Clear();
                    while (wyjscowa != 1)
                    {
                        wyjscowa = MenuDodawania();
                    }
                    break;
                case 3:
                    return 1;
                   // break;
                default:
                    Console.WriteLine("Nie ma takiej obcji w menu");
                    break;
            }
            return 0;

        }
        private static void Wyswietlenie(string[,] tab, string baza)
        {

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int k = 0; k < tab.GetLength(1); k++)
                {
                    Console.Write("{0}          ", tab[i, k]);
                    if (baza == "czytelnicy")
                    {
                        SprawdzenieDaty(tab, i, k);
                    }
                }
                Console.WriteLine();
            }
        }
        private static Int32 MenuWyswietlania()
        {
            Console.WriteLine("------------------Menu Wyświetlania--------------------");
            Console.WriteLine("---------------Dostepne tabele danych---------------");
            Console.WriteLine("1)Ksiązki 2)Autorzy  3)Czytelnicy  4)Powrót do menu");
            Console.WriteLine("----------------------------------------------------");
            Int32 a = Int32.Parse(Console.ReadLine());
            Console.Clear();

            switch (a)
            {
                case 1:
                    //ksiazki
                    Console.WriteLine("--------------Tabela książek--------------");
                    string[,] ksiazki = ZczytywanieZPliku("ksiazki");
                    Wyswietlenie(ksiazki, "ksiazki");
                    Console.WriteLine("------------------------------------------");

                    break;
                case 2:
                    //Autorzy
                    Console.WriteLine("--------------Tabela Autorów--------------");
                    string[,] autorzy = ZczytywanieZPliku("autorzy");
                    Wyswietlenie(autorzy, "autorzy");
                    Console.WriteLine("------------------------------------------");
                    break;
                case 3:
                    //Czytelnicy
                    Console.WriteLine("--------------Tabela Czytelników--------------");
                    string[,] czytelnicy = ZczytywanieZPliku("czytelnicy");
                    Wyswietlenie(czytelnicy, "czytelnicy");

                    Console.WriteLine("------------------------------------------");
                    break;
                case 4:
                    return 1;
                    break;
                default:
                    Console.WriteLine("Brak takiej obcji w menu");
                    break;
            }
            return 0;

        }
        private static Int32 MenuDodawania()
        {
            Console.WriteLine("------------------Menu Dodawania--------------------");
            Console.WriteLine("---------------Dostepne tabele danych---------------");
            Console.WriteLine("1)Ksiązki 2)Autorzy  3)Czytelnicy  4)Powrót do menu");
            Console.WriteLine("----------------------------------------------------");
            Int32 a = Int32.Parse(Console.ReadLine());
            Console.Clear();

            switch (a)
            {
                case 1:
                    //ksiazki
                    Console.WriteLine("--------------Tabela książek--------------");
                    DodawanieRekordow("ksiazki");
                    Console.WriteLine("------------------------------------------");

                    break;
                case 2:
                    //Autorzy
                    Console.WriteLine("--------------Tabela Autorów--------------");
                    DodawanieRekordow("autorzy");
                    Console.WriteLine("------------------------------------------");
                    break;
                case 3:
                    //Czytelnicy
                    Console.WriteLine("--------------Tabela Czytelników--------------");
                    DodawanieRekordow("czytelnicy");
                    Console.WriteLine("------------------------------------------");
                    break;
                case 4:
                    return 1;
                    break;
                default:
                    Console.WriteLine("Brak takiej obcji w menu");
                    break;
            }
            return 0;
        }
        private static string[,] ZczytywanieZPliku(string baza) // parametrem nazwa pliku
        {

            baza += ".txt";
            string path = Directory.GetCurrentDirectory() + @"\Bazy\" + baza;


            StreamReader sr;
            sr = File.OpenText(path);

            int ilosclini = File.ReadAllLines(path).Length;
            int rozmiar = 1;

            if (baza == "ksiazki.txt")
                rozmiar = 4;
            else if (baza == "autorzy.txt")
                rozmiar = 3;
            else if (baza == "czytelnicy.txt")
                rozmiar = 5;

            string[,] tab = new string[ilosclini / rozmiar, rozmiar];


            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int k = 0; k < tab.GetLength(1); k++)
                {
                    tab[i, k] = sr.ReadLine();
                }
            }
            sr.Close();
            return tab;
        }
        private static void DodawanieRekordow(string baza)//parametr nazwa tabeli (pliku)
        {
            baza += ".txt";
            string path = Directory.GetCurrentDirectory() + @"\Bazy\" + baza;

            StreamWriter sw = new StreamWriter(path, true);

            string dodawana;
            Console.WriteLine(path);
            if (baza == "ksiazki.txt")
                Console.WriteLine("Podaj rekordy do tabeli:(Id,Autor,Tytuł,Dostępne sztuki)");
            else if (baza == "autorzy.txt")
                Console.WriteLine("Podaj rekordy do tabeli:(Id,Imie,Nazwisko)");
            else if (baza == "czytelnicy.txt")
                Console.WriteLine("Podaj rekordy do tabeli:(Id,Imie,Nazwisko,Ilość wypożyczonych ksiązek,Data Wypożyczenia)");

            Console.WriteLine("Aby zakonczyc dodawanie wpisz: (;)");
            while (true)
            {
                dodawana = Console.ReadLine();
                if (dodawana == ";") break;
                string[] wpisywana = dodawana.Split(',').ToArray();
                for (int i = 0; i < wpisywana.Length; i++)
                {
                    sw.WriteLine(wpisywana[i]);
                }
            }
            sw.Close();

        }
        public static void SprawdzanieIstnienaBazy()
        {
            string folder = Directory.GetCurrentDirectory() + @"\Bazy\";

            StreamWriter sw;

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            string baza = "ksiazki.txt";
            if (!File.Exists(folder + baza))
            {
                FileStream fs = File.Create(folder + baza);
                fs.Close();

                sw = new StreamWriter(folder + "ksiazki.txt");
                sw.WriteLine("Id");
                sw.WriteLine("Autor");
                sw.WriteLine("Tytuł");
                sw.WriteLine("Dostępne sztuki");
                sw.Close();
            }
            baza = "autorzy.txt";
            if (!File.Exists(folder + baza))
            {
                FileStream fs = File.Create(folder + baza);
                fs.Close();

                sw = new StreamWriter(folder + baza);
                sw.WriteLine("Id");
                sw.WriteLine("Imie");
                sw.WriteLine("Nazwisko");
                sw.Close();
            }
            baza = "czytelnicy.txt";
            if (!File.Exists(folder + baza))
            {
                FileStream fs = File.Create(folder + baza);
                fs.Close();

                sw = new StreamWriter(folder + baza);
                sw.WriteLine("Id");
                sw.WriteLine("Imie");
                sw.WriteLine("Nazwisko");
                sw.WriteLine("Ilośc wypożyczonych");
                sw.WriteLine("Data wypożyczenia");
                sw.Close();
            }

        }
        public static void SprawdzenieDaty(string[,] tab, Int32 i, Int32 k)
        {
            DateTime dzis = DateTime.Today;
            dzis = dzis.AddDays(-30);

            DateTime spr;
            // daty sa co 4 k
            if (k == 4 && i > 0)
            {
                spr = DateTime.Parse(tab[i, k]);
                if (DateTime.Compare(spr, dzis) <= 0)
                {
                    Console.Write("Mineło 30 Dni");
                }
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Tools.SprawdzanieIstnienaBazy();
            Int32 a = 0;
            while(a!=1) 
            {
                a=Tools.Menu();
            }
        }
    }
}
