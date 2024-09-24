using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork_mR__Tydzien3.Lekcja23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // mozna utworzyc plik do zapisu 3 ostatnich najlepszych wynikow wraz z data
            // a takze wprowadzanie imienia gracza do tablicy rekordow jezeli zdobedzie dobry wynik np do 10 prob         
            Gra();
        }
        private static void Gra()
        {
            var random = new Random();
            var wylosowanaLiczba = random.Next(1, 100);
            Console.WriteLine(wylosowanaLiczba);
            Console.WriteLine("Podaj liczbe od 1 do 100:");
            var licznik = 0;


            while (true)
            {
                licznik++;
                if (!int.TryParse(Console.ReadLine(), out int zagadka) || zagadka > 101)
                {
                    Console.WriteLine("To nie jest poprawna liczba");
                }
                else if (wylosowanaLiczba > zagadka)
                {
                    Console.WriteLine("Większa");
                }
                else if (wylosowanaLiczba < zagadka)
                {
                    Console.WriteLine("Mniejsza");
                }
                else if (zagadka == wylosowanaLiczba)
                {
                    Console.WriteLine($"Wygrałeś, liczba prób {licznik}\n Czy chcesz zagrac ponownie (tak/nie)?");
                    Reset();
                    break;

                }

            }




        }
        private static string Reset()
        {

            while (true)
            {
                string answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Wpisz poprawnż odpowiedź");

                }
                else if (answer == "tak")
                {
                    Console.WriteLine("Zagrajmy więc!");
                    Gra();

                }
                else if (answer == "nie")
                {
                    Console.WriteLine("Do widzenia!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sprobuj jeszcze raz");
                }

            }
        }

    }
}
