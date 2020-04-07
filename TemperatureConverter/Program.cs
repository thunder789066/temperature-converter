using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) To Fahrenheit");
            Console.WriteLine("(2) To Celsius");

            Console.Write("1 or 2 :\t");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("What's the temperature? :\t");
            float temp = int.Parse(Console.ReadLine());

            int degreeCode = 176;
            char degreeChar = (char)degreeCode;
            string degreeSymbol = degreeChar.ToString();

            if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("It is " + (temp * (9.0 / 5.0) + 32.0).ToString("0.0") + degreeSymbol + " Fahrenheit.");
            }

            else if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine("It is " + ((temp - 32.0) * (5.0 / 9.0)).ToString("0.0") + degreeSymbol + " Celsius.");
            }
            
            Console.ReadKey();
        }
    }
}
