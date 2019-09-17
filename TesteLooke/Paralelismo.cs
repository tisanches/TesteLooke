using Looke.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace TesteLooke
{
    public class Paralelismo
    {

        public static void WriteParallel()
        {
            Console.WriteLine("\r\n ---------- PARALLEL FOREACH ------------");
            ParalleForEach();
        }

        private static void ParalleForEach()
            => Parallel.ForEach(Pessoa.Pessoas, item =>
            {
                Console.WriteLine(item.Empresa.Nome);
            });
    }
}
