using System;
using System.Diagnostics;

namespace Csharp9
{


    class Program
    {
        static void Main(string[] args)
        {

            //Eski yöntem
            // #if DEBUG
            //             Work();
            // #endif

Work();


        }

        
            [Conditional("DEBUG")]
            static void Work() => Console.WriteLine("Debug ortamda çalıştı");






    }
}
