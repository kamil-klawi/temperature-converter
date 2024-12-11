using TemperatureConverter.ConsoleApp.Enums;

namespace TemperatureConverter.ConsoleApp.Interfaces;

public interface ITemperatureConverter<T>
{
    void Convert(T item, TemperatureUnits unit, ISpecification<T> specification);
}
