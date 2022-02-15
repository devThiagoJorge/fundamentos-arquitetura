using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._02__PilaresOOP
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }

    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Executar()
        {
            var funcionario = new Funcionario()
            {
                DataAdmissao = DateTime.Now,
                DataNascimento = DateTime.Parse("2000/04/03"),
                Nome = "Joe Mac",
                Registro = "12341251"
            };
        }
    }
}
