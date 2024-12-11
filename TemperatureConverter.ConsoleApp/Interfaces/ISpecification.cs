namespace TemperatureConverter.ConsoleApp.Interfaces;

public interface ISpecification<T>
{
    double Convert(T degrees);
}
