using TemperatureConverter.ConsoleApp.enums;

namespace TemperatureConverter.ConsoleApp.Models;

public class Temperature
{
    public TemperatureUnits Units { get; private set; }
    public double Degrees { get; private set; }
    
    public Temperature(TemperatureUnits units, double degrees)
    {
        this.Units = units;
        this.Degrees = degrees;
    }
}