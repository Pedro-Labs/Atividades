using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           //Para criar um novo OBJETO dentro desta classe, pode ser feito dessa maneira...
           //Caixa cx;
           // cx = new Caixa();

            //Ou então simplesmente...
            Caixa cx = new Caixa();
            //Agora posso usar o método, tendo em vista que ele foi "transformado" em um método público na minha classe Caixa.
            double volumeCaixa;
            volumeCaixa = cx.Volume();
            Console.WriteLine(volumeCaixa.ToString());
             
        
        }
    }
}