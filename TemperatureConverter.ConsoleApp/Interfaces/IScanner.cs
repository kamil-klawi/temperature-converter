namespace TemperatureConverter.ConsoleApp.Interfaces;

public interface IScanner
{
    int ScanInteger(string input);
    double ScanDouble(string input);
}