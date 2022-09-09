using System;

class Switch
{
    static void Main()
    {
        int tempo = 0;
        char escolha;

        
        Console.WriteLine("Belo Horizonte/MG a Vit�ria/ES");
        Console.WriteLine("Escolha o transporte: [a]Avi�o | [c]Carro | [o]�nibus");

        escolha = char.Parse(Console.ReadLine());//Fazer a escolha no console

        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo = 50;
                break;

            case 'c':
            case 'C':
                tempo = 480;
                break;

            case 'o':
            case 'O':
                tempo = 660;
                break;

            default:
                tempo = -1;
                break;
        }

        if (tempo < 0)//Caso a escolha n�o exista
        {
            Console.WriteLine("Transporte indispon�vel");
        }
        else
        {
            Console.WriteLine("Para o transporte escolhido o tempo �: {0} minutos", tempo);
        }

    }
}