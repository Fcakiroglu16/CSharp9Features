using System;
using System.Diagnostics;

namespace Csharp9
{


    class Program
    {
        public const string _text = "{0} şehri çok güzel";
        static void Main(string[] args)
        {

            //C# 9 ile berabar isimsiz  static methodlar tanımlayabiliyoruz
            // isimsiz  methodlar allocate'e neden olur. ama static tanımlayarak allocate'i düşürebiliriz.
            Example myExample = new();

            myExample.Write(static x => string.Format(_text, x));



        }
0

    }
}
