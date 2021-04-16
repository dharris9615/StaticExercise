using System;
namespace StaticExercise
{
    public static class TempConversion
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            var celcius = (fahrenheit - 32) / 1.8;

            return celcius;
        }

        public static double CelciusToFahrenheit(double celcius)
        {
            var fahrenheit = (celcius * 9) / 5 + 32;

            return fahrenheit;
        }
    }
}
