using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._01__Classe_x_Objeto
{
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa()
            {
                Andares = 2,
                NumeroVagas = 3,
                TamanhoM2 = 40,
                Valor = 100000
            };
        }
    }
}
