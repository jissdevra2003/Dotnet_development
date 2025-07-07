using TemperatureLibrary;

namespace TemperatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature findings..........!!!!");
            Console.WriteLine("Enter celsius temperature");
            double celsius = double.Parse(Console.ReadLine());
            Temperature temp = new Temperature();
            double fahrenheit = temp.CelsiusToFahrenheit(celsius);
            Console.WriteLine("Temperature in Fahrenheit is :" + fahrenheit);



        }
    }
}
