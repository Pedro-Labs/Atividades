using System;

class DoWhile
{
    static void Main()
    {
        int num = 5;


        //Utilizando while, a função só será executada enquanto a função for TRUE.
        while(num<5)
        {
                Console.WriteLine("CFB Cursos");
        }

        //Com Do While, garanto que a função será executada ao menos uma vez.
        do{
           Console.WriteLine("CFB Cursos");
        } while (num<5);

        //  Mais um exemplo:
        string senha = "123";
        string senhauser;
        int tentativas = 0;
            
        do
        {
            Console.Clear();
            Console.WriteLine("Digite a senha");
            senhauser = Console.ReadLine();
            tentativas++;
        } while(senha != senhauser); //Ele executará o bloco enquanto a senha for diferente da senha verdadeira.

        Console.WriteLine("Senha Correta, tentativas: {0}", tentativas);
    }
} //Difernte de "DoWhile", o "While" pula o bloco de comandos se a condição for FALSE.