using System;
using System.ComponentModel;
using System.Globalization;

class URI
{
    public double ValorA { get; set; }
    public double ValorB { get; set; }
    public double Resultado { get; set; }
    public void LerValores()
    {
        ValorA = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        ValorB = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
    }
    public void Media()
    {
        Resultado = (ValorA * 3.5 + ValorB * 7.5) / 11;
        Console.WriteLine($"MEDIA = {Resultado:F5}");
    }
}

class Program
{
    static void Main()
    {
        var problema = new URI();
        problema.LerValores();
        problema.Media();
    }
}