using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._02__PilaresOOP
{
    public class Encapsulamento
    {
        public void FazerCafe()
        {
            var cafeteira = new CafeteiraEspressa();

            cafeteira.Ligar();
            cafeteira.PrepararCafe();
            // cafeteira.MoerGraos(); Isso não vai funcionar, pois é um metodo privado da classe cafeteira
            // sendo assim a gente esconde a implementação dos metodos internos das classes e deixamos eles disponiveis em um metodo de mais alto nivel.
        }
    }
}
