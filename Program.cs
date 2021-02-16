using System;
using System.Collections.Generic;
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

            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();

            numbers.Add(i ??= 14);
            numbers.Add(i ??= 23);

            Console.WriteLine(string.Join(" ", numbers));



        }



    }
}
