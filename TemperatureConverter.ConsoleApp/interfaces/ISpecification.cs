namespace TemperatureConverter.ConsoleApp.interfaces;

public interface ISpecification<T>
{
    double Convert(T degrees);
}
