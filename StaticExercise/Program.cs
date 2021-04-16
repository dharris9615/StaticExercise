using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Fahrenheit temperature would you like to ocnvert?");

            var fTemp = Convert.ToDouble(Console.ReadLine());

            var celcius = TempConversion.FahrenheitToCelcius(fTemp);

            Console.WriteLine($"{celcius} degrees celcius");

            Console.WriteLine("What Celcius temperature would you like to ocnvert?");

            var cTemp = Convert.ToDouble(Console.ReadLine());

            var farhenheit = TempConversion.CelciusToFahrenheit(cTemp);

            Console.WriteLine($"{farhenheit} degrees Farhenheit");
        }
    }
}
