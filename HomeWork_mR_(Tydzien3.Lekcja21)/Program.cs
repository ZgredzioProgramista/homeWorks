using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_mR__Tydzien3.Lekcja21_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Witaj w moim progrmaie, dzisiaj jest " + dateTime + "\n" + "Jak się nazywasz ?:");
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Pole nie może być puste");
            }
            try          
            {      
                Console.Write("Podaj swoją datę urodzenia: poprawny format to(YYYY-MM-DD) ");
                var userInput = Console.ReadLine();
                                                           
                DateTime birthDate = DateTime.Parse(userInput);
                
                Console.WriteLine("W jakiej miejscowości?:"+"\n");
                var locality = Console.ReadLine();

                Console.WriteLine($"Witaj {name} urodziles sie w {userInput} w miejscowosci {locality}!");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
            
            
        }
        
            
        

    }
}
