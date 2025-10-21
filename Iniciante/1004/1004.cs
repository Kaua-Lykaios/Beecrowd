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
    public void Conta()
    {
        Console.WriteLine($"PROD = {ValorA * ValorB}");
    }
}
class Program
{
    static void Main()
    {
        var problem = new URI();
        problem.LerValores();
        problem.Conta();
    }
}