namespace Looke.Domain.Entities
{
    public class Empresa
    {
        protected Empresa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; }
        public string Nome { get; }

        public static Empresa Create(int id, string nome)
            => new Empresa(id, nome);
    }
}
