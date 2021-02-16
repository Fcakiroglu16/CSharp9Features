using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Csharp9Features;

namespace Csharp9
{
    public enum Rainbow
    {
        Red,
        Orange,
        Yellow
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    class Program
    {


        static void Main(string[] args)
        {

            var consoleWrite = new ConsoleWrite();

            consoleWrite.WriteTo("c# 8.0 ");

            ((IWrite)consoleWrite).WriteTo2("c# 8.0 c#  8.0");

        }



    }
}
