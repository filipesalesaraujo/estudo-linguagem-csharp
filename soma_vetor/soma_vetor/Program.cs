//Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida:
//- Imprimir todos os elementos do vetor
//- Mostrar na tela a soma e a média dos elementos do vetor

using System.Globalization;

namespace soma_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, i;
            double soma, media;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.Write("VALORES = ");
            for (i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CI) + " ");
            }

            Console.WriteLine();

            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }

            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));

            media = soma / N;

            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));

        }
    }
}