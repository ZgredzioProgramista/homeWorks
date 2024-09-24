using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_mR__Tydzien4.Lekcja11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parzyste();

        }
        private static string Reset()
        {
            int x = 0;
            while (true)
            {

               
                string answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Wpisz poprawnż odpowiedź");
                    x++;
                }
                else if (answer == "tak")
                {
                    Console.WriteLine("Zapraszam!");
                    Parzyste();
                    break;
                }
                else if (answer == "nie")
                {
                    Console.WriteLine("Do widzenia!");
                    Environment.Exit(0);
                }
                else if (x==3)
                {
                    Console.WriteLine("Przerwać program?");
                    
                }
                else
                {
                    Console.WriteLine("Sprobuj jeszcze raz");
                    x++;
                }
                if (x >= 3)
                {
                    Console.WriteLine("Zbyt wiele prób. Zamykam program!");
                    Environment.Exit(0);
                }              
               
                       
            }
            return "Koniec";
            
        }

        private static void Parzyste()
        {
            Console.WriteLine("Liczby parzyste i nieparzyste, podaj liczbe: ");
            try
            {

                var trials = 0;
                while (trials < 2)
                {
                    trials++;

                    if (!int.TryParse(Console.ReadLine(), out int result))
                    {
                        Console.WriteLine("Podano nieprawidlowe dane! Spróbuj jeszcze raz: ");

                    }
                    else if (result % 2 == 0)
                    {
                        Console.WriteLine("Parzyste");

                    }
                    else if (result % 2 != 0)
                    {
                        Console.WriteLine("Nieparzyste");

                    }
                }
                Console.WriteLine("Chcesz sprawdzic kolejne liczby ?(tak/nie)");
                Reset();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
