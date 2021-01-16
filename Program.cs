using System;

namespace Csharp9
{


    class Program
    {
        static void Main(string[] args)
        {

            Product p = new();
            p.CategoryId = 25;
            Console.WriteLine(GetKDV(p));
            Console.WriteLine(GetKDV2(p));
            Console.WriteLine(GetKDV3(p));


            BookProduct bookProduct = new();
        
        Console.WriteLine(GetKDV4(bookProduct));
        Console.WriteLine(GetKDV5(p));

        }
        //Relational Patterns
        private static int GetKDV(Product p) => p.CategoryId switch
        {

            1 => 0,
            < 5 => 5,
            > 20 => 15,
            _ => 2
        };


        //Relational Patterns 2
        private static int GetKDV2(Product p)
        {
            return p.CategoryId switch
            {
                1 => 0,
                < 5 => 5,
                > 20 => 15,
                _ => 2
            };

        }
        //Logical Patterns
        private static int GetKDV3(Product p) => p.CategoryId switch
        {

            0 or 1 => 0,
            > 1 and < 5 => 5,
            > 20 => 15,
            _ => 10


        };


        //Not Pattern
        private static int GetKDV4(Product p)
        {
            if( p  is not BookProduct)
            {
                return 100;
            }
            return 0;
        }

         //Not Pattern 2
         private static int GetKDV5(Product p) => p is not BookProduct  ? 100 : 0;

    }
}
