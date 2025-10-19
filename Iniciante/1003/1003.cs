using System;

class URI
{
    public int ValorA { get; set; }
    public int ValorB { get; set; }
    public void LerValores()
    {
        ValorA = int.Parse(Console.ReadLine() ?? "0");
        ValorB = int.Parse(Console.ReadLine() ?? "0");
    }
    public void Soma()
    {
        Console.WriteLine($"SOMA = {ValorA + ValorB}");
    }
}
class Program
{
    static void Main()
    {
        var problema = new URI();
        problema.LerValores();
        problema.Soma();
    }
}