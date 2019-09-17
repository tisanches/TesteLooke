using ClassLibrary1.Extensions;
using System;


namespace TesteLooke
{
    public class Extension
    {

        public static void WriteDateExtension()
        {
            Console.WriteLine("\r\n -------   EXTENSION METHOD  -------");
            Console.WriteLine(DateTime.Now.ToPtBr());
        }
    }
}
