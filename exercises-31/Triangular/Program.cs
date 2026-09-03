using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese orden de la matriz: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
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
    }
}