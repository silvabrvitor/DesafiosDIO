using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  palavra1; //declare as suas variaveis
        String  palavra2;
        String  palavra3;

        palavra1 = Console.ReadLine(); //insira suas variaveis
        palavra2 = Console.ReadLine();
        palavra3 = Console.ReadLine();

      if ((palavra1  == "vertebrado") && (palavra2  == "ave")  && (palavra3 == "carnivoro")) {
      Console.WriteLine("aguia\n");
    }

     if ((palavra1  == "vertebrado") && (palavra2  == "ave")  && (palavra3 == "onivoro")) {
      Console.WriteLine("pomba\n");
    }

     if ((palavra1  == "vertebrado") && (palavra2  == "mamifero")  && (palavra3 == "onivoro")) {
      Console.WriteLine("homem\n");
    }

     if ((palavra1  == "vertebrado") && (palavra2  == "mamifero")  && (palavra3 == "herbivoro")) {
      Console.WriteLine("vaca\n");
    }

     if ((palavra1  == "invertebrado") && (palavra2  == "inseto")  && (palavra3 == "hematofago")) {
      Console.WriteLine("pulga\n");
    }

     if ((palavra1  == "invertebrado") && (palavra2  == "inseto")  && (palavra3 == "herbivoro")) {
      Console.WriteLine("lagarta\n");
    }

    if ((palavra1  == "invertebrado") && (palavra2  == "anelideo") && (palavra3 == "onivoro")) {
      Console.WriteLine("minhoca\n");
    }
    
    if ((palavra1  == "invertebrado") && (palavra2  == "anelideo") && (palavra3 == "hematofago")) {
      Console.WriteLine("sanguessuga\n");
    }


  }
}