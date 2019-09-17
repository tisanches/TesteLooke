using System;

namespace ClassLibrary1.Extensions
{
    public static class Formatters
    {
        public static string ToPtBr(this DateTime dateTime)
            => dateTime.ToString("dd/MM/yyyy");

    }
}
