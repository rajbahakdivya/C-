// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using FacadePattern;

public class Program
{
    public static void Main(string[] args)
    {

        var weatherServiceFacade = new WeatherServiceFacade();
        var temperatureInC = weatherServiceFacade.GetCurrentTemperatureByCity("Hetauda");

        Console.WriteLine($"The current temperature is {temperatureInC:F1}°C");
    }
}