using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._02__PilaresOOP
{
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem) : base(nome, voltagem)
        {

        }

        public CafeteiraEspressa() : base("Padrão", 110) { }
        
        private static void MoerGraos() { }

        private static void AquecerAgua() { }

        public void PrepararCafe()
        {
            AquecerAgua();
            MoerGraos();
        }

        public override void Desligar()
        {
            Console.WriteLine("Estou desligando a cafeiteira");
        }

        public override void Ligar()
        {
            Console.WriteLine("Estou ligando a cafeiteira");
        }

    }
}
