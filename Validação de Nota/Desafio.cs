using System;

class Desafio {
    static void Main(string[] args)
        {
            int contador = 0;
            double media = 0;
            do
            {
                double notaAluno = Convert.ToDouble(Console.ReadLine());
                if (notaAluno < 0 || notaAluno > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    media += notaAluno;
                    contador++;
                }
            }while(contador < 2);
            Console.WriteLine("media = " + (media / 2).ToString("N2"));

        }
}