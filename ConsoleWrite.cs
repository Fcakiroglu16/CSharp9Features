using System;

namespace Csharp9Features
{
    public class ConsoleWrite : IWrite
    {
        public void WriteTo(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}