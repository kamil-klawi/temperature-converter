using TemperatureConverter.ConsoleApp.Enums;
using TemperatureConverter.ConsoleApp.Interfaces;

namespace TemperatureConverter.ConsoleApp.Models;

public class TemperatureConvert : ITemperatureConverter<Temperature>
{
    public void Convert(Temperature temperature, TemperatureUnits unit, ISpecification<Temperature> specification)
    {
        var actualUnit = temperature.Units switch
        {
            TemperatureUnits.Celsius => "\u2070C",
            TemperatureUnits.Fahrenheit => "\u2070F",
            TemperatureUnits.Kelvin => " K",
            _ => throw new ArgumentException("Nie istnieje taka jednostka temperatury w aplikacji!")
        };
        
        var chooseUnit = unit switch
        {
            TemperatureUnits.Celsius => "\u2070C",
            TemperatureUnits.Fahrenheit => "\u2070F",
            TemperatureUnits.Kelvin => " K",
            _ => throw new ArgumentException("Nie istnieje taka jednostka temperatury w aplikacji!")
        };
        
        Console.WriteLine($"Przeliczono {temperature.Degrees}{actualUnit} na {specification.Convert(temperature)}{chooseUnit}");
    }
}
