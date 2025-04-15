using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string para inverter: ");
        string entrada = Console.ReadLine();

        string invertida = InverterString(entrada);
        
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string str)
    {
        char[] caracteres = new char[str.Length];
        int j = str.Length - 1;

        for (int i = 0; i < str.Length; i++)
        {
            caracteres[i] = str[j];
            j--;
        }

        return new string(caracteres);
    }
}
