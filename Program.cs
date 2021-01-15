using System;

namespace Csharp9
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            //init keyword'ü ile yanlızca object initializer esnasında deger atanabilir. Sonrası için değer atanmaz
            var product = new Product { Name = "Game", CategoryId = 1 };
            product.Name="Game2";
            //product.CategoryId = 10;
        }
    }
}
