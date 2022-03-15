using System;

namespace raamtukogu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta raamatunimi:");
            string raamatunimi = Console.ReadLine();
            
            Console.WriteLine("Sisesta raamatu autor:");
            string raamatuautor = Console.ReadLine();
            

            Console.WriteLine("Sisesta raamatu hind:");
            double raamatuhind = Convert.ToInt32(Console.ReadLine());

            if (raamatunimi.Length > 4)
            {
                Console.WriteLine("Pealkiri kehtib!");
            }
            else if (raamatunimi.Length < 4)
            {
                Console.WriteLine("Pealkiri ei kehti!");
            }
            else
            {
                Console.WriteLine("Pealkiri ei kehti!");
            }
            
            if (raamatuhind > 0 )
            {
                Console.WriteLine("Hind kehtib!");
            }
            else if(raamatuhind < 0)
            {
                Console.WriteLine("Hind ei kehti!");
            }
            else
            {
                Console.WriteLine("Hind ei kehti!");
            }
            
        }
    }
}
