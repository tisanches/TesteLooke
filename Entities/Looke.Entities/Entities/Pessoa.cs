using System;
using System.Collections.Generic;

namespace Looke.Domain.Entities
{
    public class Pessoa
    {
        protected Pessoa(int id, string nome, string sobrenome, DateTime dataNascimento, Empresa empresa)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Empresa = empresa;
        }

        public static IEnumerable<Pessoa> Pessoas
            => new List<Pessoa>
                {
                   Create(1, "João", "Da Silva", new DateTime(1982, 02, 01), Empresa.Create(1, "Empresa Joao")),
                   Create(2, "Batista", "Benedetto", new DateTime(1982, 02, 01), Empresa.Create(2, "Empresa Batista")),
                   Create(3, "José", "Ceara", new DateTime(1982, 02, 01), Empresa.Create(3, "Empresa José")),
                   Create(4, "Tiago", "Sanches", new DateTime(1982, 02, 01), Empresa.Create(4, "Empresa Tiago")),
                   Create(5, "Pedro", "Dantas", new DateTime(1982, 02, 01), Empresa.Create(5, "Empresa Pedro")),
                   Create(6, "Enzo", "Pio", new DateTime(1982, 02, 01), Empresa.Create(6, "Empresa Enzo"))
                };

        public DateTime DataNascimento { get; }
        public Empresa Empresa { get; }
        public int Id { get; }
        public string Nome { get; }
        public string Sobrenome { get; }

        public static Pessoa Create(int id, string nome, string sobrenome, DateTime dataNascimento, Empresa empresa)
        {
            //Aqui deveria retornar um Notification - nao retornar excpetions
            if (empresa is null)
                throw new Exception("Erro ao criar entidade de pessoa");

            return new Pessoa(id, nome, sobrenome, dataNascimento, empresa);
        } 
    }
}
