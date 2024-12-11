using TemperatureConverter.ConsoleApp.Interfaces;

namespace TemperatureConverter.ConsoleApp.Models;

public class ConsoleStream : IPrinter, IScanner
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
    
    public int ScanInteger(string input)
    {
        Console.WriteLine(input);
        var initial = Console.ReadLine();
        if (int.TryParse(initial, out var temp))
            return temp;
        throw new ArgumentException("Prosze podac stopnie temperatury");
    }

    public double ScanDouble(string input)
    {
        Console.WriteLine(input);
        var initial = Console.ReadLine();
        if (double.TryParse(initial, out var temp))
            return temp;
        throw new ArgumentException("Prosze podac stopnie temperatury");
    }
}