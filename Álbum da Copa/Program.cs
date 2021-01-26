using System;


class Program {
  
  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int totalDeFigurinhas = 0;

     int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];

            int contaFigurinha = 0;
            
            
            for(var i=0; i < numeroDeFigurinhasCompradas;i++)
            {
                int y;
                
                string x = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(x))
                {
                    y = Int32.Parse(x);
                    int valor = Array.IndexOf(albumDeFigurinha, y);

                    if (valor == -1)
                    {
                        if (i > albumDeFigurinha.Length)
                        {
                            break;
                        }
                        else
                        {
                            albumDeFigurinha[i] = y;
                        }
                    }
                    
                    
                }
              
            }
            
                  


            for (var i = 0; i < albumDeFigurinha.Length; i++)
            {
                if (albumDeFigurinha[i] != 0)
                {
                    contaFigurinha++;
                    
                }
            }
            totalDeFigurinhas = numeroDeFigurinhas - contaFigurinha;
    Console.WriteLine(totalDeFigurinhas);
  }

}