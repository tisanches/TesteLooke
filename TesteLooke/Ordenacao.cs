using Looke.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteLooke
{
    public class Ordenacao
    {

        public static void WritePessoas()
        {
            Console.WriteLine("\r\n ---------- ORDER BY DESC ------------");
            OrderDescBySobrenome().ToList().ForEach(x => Console.WriteLine(new { x.Sobrenome, x.Nome }));
        }

        /// <summary>
        /// 1 - Ordenação
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<Pessoa> OrderDescBySobrenome()
            => Pessoa.Pessoas.OrderByDescending(x => x.Sobrenome);
    }
}
