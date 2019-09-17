using System;


namespace TesteLooke
{
    public class Fatorial
    {

        public static void WriteFatorial()
        {
            Console.WriteLine("\r\n -------   FATORIAL  -------");
            Console.WriteLine($"Fatorial de 10 é: {CalculaFatorial(10)}");
        }

        private static int CalculaFatorial(int num)
           => num == 1
               ? 1
               : (num * CalculaFatorial(num - 1));

    }
}
