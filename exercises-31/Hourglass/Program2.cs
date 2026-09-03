using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n % 2 == 0)
        {
            Console.WriteLine("Por favor, ingrese un número impar válido.");
            return;
        }

        int[,] matriz = new int[n, n];

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = i + 2 * j;
            }
        }

       
        Console.WriteLine("\nMATRIZ COMPLETA");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matriz[i, j],3}");
            }
            Console.WriteLine();
        }

        
        Console.WriteLine("\nRELOJ DE ARENA");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                bool esReloj = (i <= n / 2 && j >= i && j <= n - 1 - i) ||
                               (i > n / 2 && j >= n - 1 - i && j <= i);

                if (esReloj)
                {
                    Console.Write($"{matriz[i, j],3}");
                }
                else
                {
                    Console.Write("   "); 
                }
            }
            Console.WriteLine();
        }
    }
}