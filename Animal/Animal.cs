using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String palavra1; //declare as suas variaveis
        String palavra2;
        String palavra3;

        palavra1 = Console.ReadLine(); //insira suas variaveis
        palavra2 = Console.ReadLine();
        palavra3 = Console.ReadLine();

        if (palavra1 == "vertebrado")
        {
            if(palavra2 == "ave")
            {
                if(palavra3 == "carnivoro")
                {
                    Console.Write("aguia\n");
                }
                if(palavra3== "onivoro"){
                    Console.Write("pomba\n");
                }
            }else if(palavra2 == "mamifero"){
                if(palavra3=="onivoro")
                {
                    Console.Write("homem\n");
                }
                if(palavra3 == "herbivoro"){
                    Console.Write("vaca\n");
                }
            }
        }else if(palavra1=="invertebrado"){
            if(palavra2=="inseto")
            {
                if(palavra3=="hematofago")
                {
                    Console.Write("pulga\n");
                }
                if(palavra3=="herbivoro"){
                    Console.Write("lagarta\n");
                }
            }else if(palavra2=="anelideo"){
                if(palavra3=="hematofago")
                {
                    Console.Write("sanguessuga\n");
                }
                if(palavra3=="onivoro"){
                    Console.Write("minhoca\n");
                }
            }
        }

        
  }
}