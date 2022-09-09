using System;

class ForEach
{
    static void Main()
    {
        int[] num = new int[5] { 11, 22, 33, 44, 55 };
        //Usando apenas For.
        for(int i=0; i < num.Length; i++) {
            Console.WriteLine(num[i]);
        }

        //Usando agora o ForEach, para a mesma finalidade, porém, de maneira bem mais simples.

        foreach(int n in num)
        {
            Console.WriteLine(n);
        }
    }
}