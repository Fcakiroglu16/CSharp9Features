using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

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
        public static string FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => "kırmızı",
                Rainbow.Orange => "turuncu",
                Rainbow.Yellow => "sarı",
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
            };

        public static decimal CalculatePrice(Product product, decimal salePrice)
        {

            return product switch
            {
                { Stock: 100 } => salePrice * 0.10M,
                { Stock: 200 } => salePrice * 0.20M,
                _ => salePrice * 0.1M
            };


        }

        static void Main(string[] args)
        {

            Console.WriteLine(FromRainbow(Rainbow.Orange));
            Console.WriteLine(CalculatePrice(new Product { Name = "Kalem", Price = 100, Stock = 100 }, 1000));

        }



    }
}
