using System;
using TesteLooke.View.Interfaces;

namespace TesteLooke.View
{
    public class Carro : ICarro
    {
        public string AbrirPorta(int quantidadePorta)
        {
            return $"Quantidade de portas abertas {quantidadePorta}";
        }

        public void Porta()
        {
            throw new NotImplementedException();
        }
    }
}
