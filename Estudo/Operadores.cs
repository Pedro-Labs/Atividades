using System;

class Operadores
{
    static void Main(){

        int res = (10 + 5)*2;

        bool res = 10 != 5; // >, <, >=, <=, !,

        // Operadores de incremento e decremento
        int num = 10;

        num++;  //num += 1;  /num = num + 1; //Todos d�o o mesmo resultado, por�m com uma sintaxe mais simplificada.
        num *= 2;//num = num + 2;  +  -  /  *

        //Operadores l�gicos: & = AND; | = OR
        bool res = (5 > 3) | (10 < 5); //Se ao menos uma opera��o for TRUE, a resposta ser� TRUE.
        bool res = (5 > 7) | (10 < 5); //Se todas as opera��es for FALSE, a resposta ser� FALSE.

        bool res = (5 < 7) & (10 < 5); // S� retorna TRUE, quandos todas as opera��es forem TRUE.


        Console.WriteLine(res);
    }
} 