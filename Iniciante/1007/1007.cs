using System;
using System.Globalization;

class URI
{
    public int ValorA { get; set; }
    public int ValorB { get; set; }
    public int ValorC { get; set; }
    public int ValorD { get; set; }
    public int Resultado { get; set; }
    public void LerValores()
    {
        ValorA = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        ValorB = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        ValorC = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
        ValorD = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
    }
    public void Conta()
    {
        Resultado = ValorA * ValorB - ValorC * ValorD;
    }
    public void Exibir()
    {
        Console.WriteLine($"DIFERENCA = {Resultado}");
    }
}
class Program
{
    static void Main()
    {
        var problem = new URI();
        problem.LerValores();
        problem.Conta();
        problem.Exibir();
    }
}