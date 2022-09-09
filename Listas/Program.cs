using System;
using System.Collections.Generic;

class Listas
{
    static void Main()
    {
        List<string> carros = new List<string>();//Tipar a lista
        string[] carros2 = new string[10];
        
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.AddRange(carros);

        //carros.Clear();
        if (carros.Contains("Golf"))
        {
            Console.WriteLine("Esta na lista");
        }
        else
        {
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2,2); // COPIA ELEMENTOS DE UMA LISTA PARA OUTRA

        carros.Insert(1, "Cruze"); //INSERE EMDETERMINADA POSIÇÃO POSIÇÃO

        //carros.Remove("Argo");  //REMOVE PELO NOME

        //carros.RemoveAt(0);   //REMOVE PELA POSIÇÃO

        //carros.Reverse();    //Inverte a lista

        carros.Sort();    //Ordena em ordem alfabética

        int tamanho = carros.Count;
        carros.Capacity = 15;
        int capa = carros.Capacity;


        Console.WriteLine("Tamanho  {0}", tamanho);
        Console.WriteLine("Capacidade  {0}", capa);


        int pos2 = carros.LastIndexOf("HRV");

        foreach(string c in carros)
        {
            Console.WriteLine("Carro: {0}", c);
        }



        string ca = "HRV";
        int pos = 0;
        pos = carros.IndexOf(ca);
        Console.WriteLine("Carro {0} está na posição {1}", ca, pos);
        Console.WriteLine("Último HRV está na posição {0}", pos2);
    }
}
