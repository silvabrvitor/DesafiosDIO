using System;

class Desafio {
    static void Main(string[] args)
        {
            int somaSeq = 0;
            int contarSequencia = 0;
            int V;
            int R = Convert.ToInt32(Console.ReadLine());
            do
            {
                V = Convert.ToInt32(Console.ReadLine());
            }while(V <= R);

            while(somaSeq <= V){
                somaSeq += R;
                R++;
                contarSequencia++;
            }

            Console.WriteLine(contarSequencia);

        }
}