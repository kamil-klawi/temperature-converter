using TemperatureConverter.ConsoleApp.enums;

namespace TemperatureConverter.ConsoleApp.interfaces;

public interface ITemperatureConverter<T>
{
    void Convert(T item, TemperatureUnits unit, ISpecification<T> specification);
}
