using System;

namespace Csharp9Features
{
    public interface IWrite
    {
        void WriteTo(string msg);

        void WriteTo2(string msg)
        {

            Console.WriteLine(msg);
        }
    }


}