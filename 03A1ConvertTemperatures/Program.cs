using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03A1ConvertTemperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit, kelvin;
            string ckelvin, cfahrenheit;

            Console.WriteLine("Bitte erfassen sie die Temperatur in °C");
            Console.Write("Celsius   :");
            celsius = double.Parse(Console.ReadLine());
            fahrenheit = (( celsius * 9 ) / 5 ) + 32;
            kelvin = celsius + 273.15;

            ckelvin = Convert.ToString(kelvin);
            cfahrenheit = Convert.ToString(fahrenheit);

            Console.WriteLine("Fahrenheit: " + cfahrenheit);
            Console.WriteLine("Kelvin    : " + ckelvin);

            // Console.Write("Fahrenheit: {0:F20}\n", fahrenheit);
            // Console.Write("Kelvin    : {0:F20}\n", kelvin);


        }
    }
}
