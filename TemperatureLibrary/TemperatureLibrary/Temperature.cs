namespace TemperatureLibrary
{
    public class Temperature
    {
        public double CelsiusToFahrenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }
        public double FahrenheitToCelsius(double temperature)
        {
            return (temperature - 32) * 5 / 9;

        }
    }
}
