using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

class Program1
{
    static void Main()
    {
        var answer = string.Empty;
        var options = new List<string> { "s", "n" };

        do
        {
            int n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");
            if (n <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero válido mayor a 0.");
                return;
            }

            int[,] matriz = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = i + j;
                }
            }

          
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriz[i, j],-4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{matriz[i, j],-4}");
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