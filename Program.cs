using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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


            //ilgili method'un sonuna geldiğinde otomatik olarak dispose eder
            using var stream = new StreamWriter("examle.txt");
            stream.WriteLine("c#  8.0");







        }



    }
}
