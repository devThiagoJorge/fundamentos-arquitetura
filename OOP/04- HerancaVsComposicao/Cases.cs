using OOP._02__PilaresOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._04__HerancaVsComposicao
{
    #region Caso 1

    public class PessoaFisicaHeranca : Pessoa
    {
        public string Cpf { get; set; }  
    }

    public class PessoaFisicaComposicao
    {
        public Pessoa Pessoa { get; set; } //Composição
        public string Cpf { get; set; }
    }


    public class TestesHerancaComposicao
    {
        public TestesHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisicaHeranca
            {
                Cpf = "124234234",
                DataNascimento = DateTime.Now,
                Nome = "Nome da Pessoa"
            };

            var pessoaComposicao = new PessoaFisicaComposicao
            {
                Cpf = "42342342",
                Pessoa = new Pessoa
                {
                    DataNascimento = DateTime.Now,
                    Nome = "Nome da Pessoa"
                }
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }


    #endregion

    #region Caso 2
    public interface IRepositorio<T> // o T pode ser qualquer objeto
    {
        void Adicionar(T obj);
        void Excluir(T obj);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }


    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T obj)
        {

        }

        public void Excluir(T obj)
        {

        }
    }

    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {

    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        public readonly IRepositorio<Pessoa> _repositoryPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositoryPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa obj)
        {
            _repositoryPessoa.Adicionar(obj);
        }
    }
    #endregion
}
