using TemperatureConverter.ConsoleApp.interfaces;

namespace TemperatureConverter.ConsoleApp.Models;

public class CelsiusToFahrenheit : ISpecification<Temperature>
{
    public double Convert(Temperature temperature)
    {
        return temperature.Degrees * 9 / 5 + 32;
    }
}

public class CelsiusToKelvin : ISpecification<Temperature>
{
    public double Convert(Temperature temperature)
    {
        return temperature.Degrees + 273.15;
    }
}