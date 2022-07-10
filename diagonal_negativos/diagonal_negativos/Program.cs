//Fazer um programa para ler um número inteiro N (máximo = 10) e uma matriz quadrada de ordem N
//contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores
//negativos da matriz.

using System.Globalization;

namespace diagonal_negativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, cont;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [ " + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine(), CI);
                }
            }

            Console.WriteLine();

            Console.WriteLine("DIAGONAL PRINCIPAL:");

            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();

            cont = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.Write("QUANTIDADE DE NEGATIVOS = " + cont);

            Console.WriteLine();

        }
    }
}