using TemperatureConverter.ConsoleApp.Enums;
using TemperatureConverter.ConsoleApp.Models;

namespace TemperatureConverter.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var temperatureFilter = new TemperatureConvert();
        var consoleStream = new ConsoleStream();
        Temperature celsius, fahrenheit, kelvin;
        double temp;
        
        consoleStream.Print("Witaj w aplikacji konsolowej do przeliczania temperatury!");
        var choose = consoleStream.ScanInteger("1 - Przelicz Fahrenheit na Celsjusze\n2 - Przelicz Fahrenheit na Kelwiny\n3 - Przelicz Celsjusze na Fahrenheit\n4 - Przelicz Celsjusze na Kelwiny\n5 - Przelicz Kelwiny na Celsjusz\n6 - Przelicz Kelwiny na Fahrenheit\n7 - Zakoncz dzialanie aplikacji");
        
        switch (choose)
        {
            case 1:
                temp = consoleStream.ScanDouble("Podaj temperature w Fahrenheit");
                fahrenheit = new Temperature(TemperatureUnits.Fahrenheit, temp);
                temperatureFilter.Convert(fahrenheit, TemperatureUnits.Celsius, new FahrenheitToCelsius());
                break;
            case 2:
                temp = consoleStream.ScanDouble("Podaj temperature w Fahrenheit");
                fahrenheit = new Temperature(TemperatureUnits.Fahrenheit, temp);
                temperatureFilter.Convert(fahrenheit, TemperatureUnits.Kelvin, new FahrenheitToKelvin());
                break;
            case 3:
                temp = consoleStream.ScanDouble("Podaj temperature w Celsjuszach");
                celsius = new Temperature(TemperatureUnits.Celsius, temp);
                temperatureFilter.Convert(celsius, TemperatureUnits.Fahrenheit, new CelsiusToFahrenheit());
                break;
            case 4:
                temp = consoleStream.ScanDouble("Podaj temperature w Celsjuszach");
                celsius = new Temperature(TemperatureUnits.Celsius, temp);
                temperatureFilter.Convert(celsius, TemperatureUnits.Kelvin, new CelsiusToKelvin());
                break;
            case 5:
                temp = consoleStream.ScanDouble("Podaj temperature w Kelwinach");
                kelvin = new Temperature(TemperatureUnits.Kelvin, temp);
                temperatureFilter.Convert(kelvin, TemperatureUnits.Celsius, new KelvinToCelsius());
                break;
            case 6:
                temp = consoleStream.ScanDouble("Podaj temperature w Kelwinach");
                kelvin = new Temperature(TemperatureUnits.Kelvin, temp);
                temperatureFilter.Convert(kelvin, TemperatureUnits.Fahrenheit, new KelvinToFahrenheit());
                break;
            case 7:
                Console.WriteLine("Wychodzisz z aplikacji!");
                break;
            default:
                Console.WriteLine("Podany wybor nie istnieje!");
                break;
        }
    }
}