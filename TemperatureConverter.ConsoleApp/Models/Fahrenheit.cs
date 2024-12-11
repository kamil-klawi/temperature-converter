using TemperatureConverter.ConsoleApp.Interfaces;

namespace TemperatureConverter.ConsoleApp.Models;

public class FahrenheitToCelsius : ISpecification<Temperature>
{
    public double Convert(Temperature temperature)
    {
        return (temperature.Degrees - 32) * 5 / 9;
    }
}

public class FahrenheitToKelvin : ISpecification<Temperature>
{
    public double Convert(Temperature temperature)
    {
        return (temperature.Degrees + 459.67) * 5 / 9;
    }
}