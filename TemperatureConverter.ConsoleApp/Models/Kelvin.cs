using TemperatureConverter.ConsoleApp.interfaces;

namespace TemperatureConverter.ConsoleApp.Models;

public class KelvinToCelsius : ISpecification<Temperature>
{
    public double Convert(Temperature temperature)
    {
        return temperature.Degrees - 273.15;
    }
}

public class KelvinToFahrenheit : ISpecification<Temperature>
{
    public double Convert(Temperature temperature)
    {
        return temperature.Degrees * 9 / 5 - 459.67;
    }
}