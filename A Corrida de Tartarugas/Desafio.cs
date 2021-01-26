using System;

class Desafio {
    static void Main(string[] args)
        {
          string line = Console.ReadLine();
        do
        {
            string[] tartarugas;
            if (!string.IsNullOrWhiteSpace(line))
            {
                tartarugas = Console.ReadLine().Split(" ");
                int velocidade = 0;

                foreach (var item in tartarugas)
                {
                    if (Int32.Parse(item) > velocidade)
                        velocidade = Int32.Parse(item);
                }

                if (velocidade < 10)
                {
                    Console.WriteLine(1);
                }
                else if (velocidade >= 10 && velocidade < 20)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(3);
                }
            }
            line = Console.ReadLine();
        } while (!string.IsNullOrWhiteSpace(line));
            


        }
}