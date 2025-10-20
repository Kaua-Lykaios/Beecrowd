using System;
using System.Globalization;

class URI
{
    public double ValorA { get; set; }
    public double ValorB { get; set; }
    public double ValorC { get; set; }
    public double Resultado { get; set; }

    public void LerValores()
    {
        ValorA = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        ValorB = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        ValorC = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
    }
    public void Conta()
    {
        Resultado = (ValorA * 2 + ValorB * 3 + ValorC * 5) / 10;
        Console.WriteLine($"MEDIA = {Resultado:F1}");
    }
}
class Program
{
    static void Main()
    {
        var problema = new URI();
        problema.LerValores();
        problema.Conta();
        
    }
}