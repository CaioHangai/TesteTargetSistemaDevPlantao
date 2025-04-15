using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string jsonPath = "dados.json"; // Arquivo contendo os dados
        if (!File.Exists(jsonPath))
        {
            Console.WriteLine("Arquivo JSON não encontrado.");
            return;
        }

        var faturamentoMensal = JsonConvert.DeserializeObject<List<FaturamentoDia>>(File.ReadAllText(jsonPath));

        // Filtrar dias com faturamento maior que zero
        var diasComFaturamento = faturamentoMensal.Where(d => d.Valor > 0).ToList();

        if (diasComFaturamento.Count == 0)
        {
            Console.WriteLine("Nenhum dia com faturamento registrado.");
            return;
        }

        double menorFaturamento = diasComFaturamento.Min(d => d.Valor);
        double maiorFaturamento = diasComFaturamento.Max(d => d.Valor);
        double mediaMensal = diasComFaturamento.Average(d => d.Valor);
        int diasAcimaDaMedia = diasComFaturamento.Count(d => d.Valor > mediaMensal);

        Console.WriteLine($"Menor faturamento do mês: {menorFaturamento}");
        Console.WriteLine($"Maior faturamento do mês: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}

class FaturamentoDia
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}
