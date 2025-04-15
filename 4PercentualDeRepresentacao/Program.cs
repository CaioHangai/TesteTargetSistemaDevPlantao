using System;

class Program
{
    static void Main()
    {
        // Valores de faturamento mensal por estado
        var faturamentoPorEstado = new (string estado, double valor)[]
        {
            ("SP", 67836.43),
            ("RJ", 36678.66),
            ("MG", 29229.88),
            ("ES", 27165.48),
            ("Outros", 19849.53)
        };

        // Calcula o faturamento total
        double faturamentoTotal = 0;
        foreach (var item in faturamentoPorEstado)
        {
            faturamentoTotal += item.valor;
        }

        // Exibe o percentual de cada estado
        Console.WriteLine("Percentual de representação por estado:");
        foreach (var item in faturamentoPorEstado)
        {
            double percentual = (item.valor / faturamentoTotal) * 100;
            Console.WriteLine($"{item.estado}: {percentual:F2}%");
        }
    }
}
