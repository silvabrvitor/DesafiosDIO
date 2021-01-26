using System;

namespace calcviagem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada;
            entrada = Console.ReadLine().Split(" ");
            double calculo = (Convert.ToDouble(entrada[0]) * Convert.ToDouble(entrada[1]))/12;

            Console.WriteLine(calculo.ToString("N3"));
        }
    }
}