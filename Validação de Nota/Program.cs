using System; 

class Program {

    static void Main(string[] args) { 

        int doCalc = 1;
              while (doCalc == 1) 
              {
                int numbersValids = 0;
                double total = 0;
                while (numbersValids < 2) 
                {
                    double grade = double.Parse(Console.ReadLine());
                    if (grade >= 0 && grade <= 10)
                    {
                        numbersValids ++;
                        total += grade;
                    } else {
                        Console.WriteLine("nota invalida");
                    }
                } 
                Console.WriteLine("media = "+ (total / 2).ToString("n2"));
                do {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    doCalc = int.Parse(Console.ReadLine());
                } while (doCalc !=  1 && doCalc != 2);
            }

    }

}