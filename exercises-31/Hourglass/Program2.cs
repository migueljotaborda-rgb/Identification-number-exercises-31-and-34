using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

class Program2
{
    static void Main()
    {
        var answer = string.Empty;
        var options = new List<string> { "s", "n" };

        do
        {
            int n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");
            if (n <= 0 || n % 2 == 0)
            {
            Console.WriteLine("Por favor, ingrese un número impar válido.");
            return;
        }

        int[,] matriz = new int[n, n];

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                    matriz[i, j] = 2 * i + j;
            }
        }

       
            Console.WriteLine("MATRIZ COMPLETA");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                    Console.Write($"{matriz[i, j],-4}");
            }
            Console.WriteLine();
        }

        
            Console.WriteLine("RELOJ DE ARENA");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                    bool perteneceReloj = (i <= j && i + j <= n - 1) || (i >= j && i + j >= n - 1);

                    if (perteneceReloj)
                {
                        Console.Write($"{matriz[i, j],-4}");
                }
                else
                {
                        Console.Write($"{"",-4}");
                }
            }
            Console.WriteLine();
        }

            do
            {
                answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
            }
            while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

        } while ("s".Equals(answer, StringComparison.CurrentCultureIgnoreCase));
    }
}