using System.Globalization;

namespace processamento_de_dados_e_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 5;
            y = 2 * x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            CultureInfo CI = CultureInfo.InvariantCulture;
            int x2;
            double y2;
            x2 = 5;
            y2 = 2 * x2;
            Console.WriteLine(x2);
            Console.WriteLine(y2.ToString("F1", CI));

            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;
            area = (b1 + b2) / 2.0 * h;
            Console.WriteLine(area);

            int a, b, resultado;
            a = 5;
            b = 2;
            resultado = a / b;
            Console.WriteLine(resultado);

            double a3;
            int b3;
            a3 = 5.0;
            b3 = (int)a3;
            Console.WriteLine(b3);
        }
    }
}