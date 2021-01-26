using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  
  static void Main(string[] args) {
    // Utilize Console.ReadLine para leitura do input de cada linha
    // Utilize Console.WriteLine para fazer o output de cada linha
    string input = Console.ReadLine();
            List<string> tiposJoia = new List<string>();
            do
            {
                if (!string.IsNullOrWhiteSpace(input))
                {
                tiposJoia.Add(input);
                input = Console.ReadLine();
                }

            }while (!string.IsNullOrWhiteSpace(input));
            int tiposDistintos = tiposJoia.Distinct().Count();
            Console.WriteLine(tiposDistintos);
  }

}