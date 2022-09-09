using System;

class variaveis
{
    static void Main()
    {
        byte n1 = 10; //0 e 255
        int num = 0;
        char  letra = 'C';
        float valor = 5.3f;
        string nome = "Bruno";



        int num1, num2, res;// Podem ser inicializadas com valores

        num1 = 10;
        num2 = 2;
        res = num1 * num2;


        Console.WriteLine("A multiplicação de " + num1 + " com " + num2 + " é igual a: " + res);

        //var aux = 10; //Não preciso tipar a variável, apenas na atribuição.
        //var aux = "Andradina";
        var aux = nome;

        //Console.WriteLine("Valor da variável é: " + aux + "...");  

    }
}