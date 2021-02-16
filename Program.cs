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

            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            Index index1 = 4; //Index tanımlama
            Range range2 = 1..3; // Range tanımlama

            var range1 = numbers[1..3];
            Console.WriteLine(numbers[index1]);
            Console.WriteLine(String.Join(" ", range1));



        }



    }
}
