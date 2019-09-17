using Microsoft.Extensions.DependencyInjection;
using System;
using TesteLooke.View;
using TesteLooke.View.Interfaces;

namespace TesteLooke
{
    public class Program
    {


        static void Main(string[] args)
        {
            var serviceProvider  = AddServices();

            Ordenacao.WritePessoas();
            Paralelismo.WriteParallel();
            Extension.WriteDateExtension();
            Fatorial.WriteFatorial();

            var carro = serviceProvider.GetService<ICarro>();

            Console.WriteLine("\r\n -------   FATORIAL  -------");
            Console.WriteLine(carro.AbrirPorta(4));

            Console.ReadKey();
        }

        private static IServiceProvider AddServices()
        {
            //setup our DI
            return new ServiceCollection()
                .AddTransient<ICarro, Carro>()
                .AddSingleton<Carro>()
                .BuildServiceProvider();
        }

    }
}
