using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double vaha;
            double vyska;
            double výpočet;
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Výpočet BMI");
                Console.WriteLine("---------------------------------------");


                Console.WriteLine("Zadej svou váhu (kg):  ");
                double.TryParse(Console.ReadLine(), out vaha);
                
                if (vaha <= 5)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Nelze použít číslo menší než 5!!");
                }
                else
                {
                    Console.WriteLine("Zadej svou výšku (cm)  ");
                    double.TryParse(Console.ReadLine(), out vyska);
                    
                    if (vyska <= 50) 
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nelze použít číslo nenší než 50!!");

                    }
                    else
                    {

                        výpočet = (vaha) / (vyska / 100)*(vyska / 100);
                        Console.WriteLine();
                        Console.WriteLine($"Tvoje BMI je {výpočet}");

                    } 

                }
                Console.ReadLine();
          
            
            
            
            
            
            
            
            
            }
        }
    }

}