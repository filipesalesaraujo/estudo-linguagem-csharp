﻿//Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os
//nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo

using System.Globalization;

namespace idades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome1, nome2;
            int idade1, idade2;
            double media;

            Console.WriteLine("Dados da primeira pessoa:");

            Console.Write("Nome: ");
            nome1 = Console.ReadLine();

            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome: ");
            nome2 = Console.ReadLine();

            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (double)(idade1 + idade2) / 2;

            Console.WriteLine("A idade de " + nome1 + " e " + nome2 + " e de " + media + " anos");

        }
    }
}