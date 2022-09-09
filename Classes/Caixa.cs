using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Caixa
    {
        private double lado;

        public Caixa()
        {
            lado = 10;
        }

        public double Volume() //Deste modo, posso utilizar o método no programa principal.
        {
            return lado * lado * lado;
        }
    }
}