


using CotacaoDoDolar_MembrosEstaticos.domain;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Qual é a cotação do dólar? ");
        double cotacao = double.Parse(Console.ReadLine()!);

        Console.Write("Quantos dólares você vai comprar? ");
        double quantia = double.Parse(Console.ReadLine()!);


        double valor = conversor.ConversorDeMoeda(cotacao, quantia);

        Console.WriteLine($"Valor a ser pago em reais = {valor:F2}");

    }
}