using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (EhFibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool EhFibonacci(int n)
    {
        int a = 0, b = 1;
        while (b < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == n || a == n;
    }
}