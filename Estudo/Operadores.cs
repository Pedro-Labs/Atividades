using System;

class Operadores
{
    static void Main(){

        int res = (10 + 5)*2;

        bool res = 10 != 5; // >, <, >=, <=, !,

        // Operadores de incremento e decremento
        int num = 10;

        num++;  //num += 1;  /num = num + 1; //Todos dão o mesmo resultado, porém com uma sintaxe mais simplificada.
        num *= 2;//num = num + 2;  +  -  /  *

        //Operadores lógicos: & = AND; | = OR
        bool res = (5 > 3) | (10 < 5); //Se ao menos uma operação for TRUE, a resposta será TRUE.
        bool res = (5 > 7) | (10 < 5); //Se todas as operações for FALSE, a resposta será FALSE.

        bool res = (5 < 7) & (10 < 5); // Só retorna TRUE, quandos todas as operações forem TRUE.


        Console.WriteLine(res);
    }
} 