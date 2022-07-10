//Leia 2 valores inteiros X e Y (em qualquer ordem). A seguir, calcule e mostre a soma dos números
//impares entre eles.

using System.Globalization;

namespace soma_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y, troca, soma;

            Console.WriteLine("Digite dois numeros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }

            soma = 0;
            for (int i = x + 1; i < y; i++)
            {

                if (i % 2 != 0)
                {
                    soma = soma + i;
                }

            }

            Console.WriteLine("SOMA DOS IMPARES = " + soma);



        }
    }
}