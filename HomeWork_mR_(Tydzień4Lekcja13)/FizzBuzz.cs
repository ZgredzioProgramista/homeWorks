using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_mR__Tydzień4Lekcja13_
{

    internal class FizzBuzz
    {
       
        public int FizzBuzzGame() 
        {
            
            Console.WriteLine("Witaj w \"FizzBuzz\" podaj liczbę: ");
            while (true)
            {
               
                try
                {   
                    Console.WriteLine("Wcisnij 0000 - aby zakończyć");
                    if (!int.TryParse(Console.ReadLine(), out int input))
                    {
                        Console.WriteLine("Nieprawidlowe dane");                    
                       
                    }
                    else if (input % 3 == 0 && input % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                        
                    }
                    else if (input % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        
                    }
                    else if (input % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        
                    }
                    else if (input % 3 != 0 || input % 5 != 0)
                    {
                        Console.WriteLine(input);
                        
                    }
                    if (input == 0000)
                    {
                        Environment.Exit(0);
                        
                    }
     

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               

            }
           
         

        }
       

    }
   
}
