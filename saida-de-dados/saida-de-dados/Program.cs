using System.Globalization;

namespace saida_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia");
            Console.Write("Boa noite");

            Console.WriteLine("Bom dia");
            Console.WriteLine("Boa noite");

            int x, y;
            x = 10;
            y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            CultureInfo CI = CultureInfo.InvariantCulture;

            double x2;
            x2 = 2.3456;
            Console.Write(x2.ToString("F2", CI));
            Console.WriteLine();

            int idade;
            double salario;
            string nome;
            char sexo;
            idade = 32;
            salario = 4560.9;
            nome = "Maria Silva";
            sexo = 'F';
            Console.WriteLine("A funcionaria " + nome + ", sexo " + sexo + ", ganha " + salario.ToString("F2", CI) + " e tem " + idade + " anos");
        }
    }
}