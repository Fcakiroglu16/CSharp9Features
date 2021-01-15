using System;

namespace Csharp9
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            //Record, compile çıktısı olarak IEquatable<T>’i implemente eden bir sınıfa dönüşmektedir. 
            //Böylece record üzerinden yaratılacak nesneler aralarında karşılaştırıldıklarında referans olarak değil, 
            //Data olarak değerlendirilir.
            var product = new Product { Name = "Game", CategoryId = 1 };
            var product2 = new Product { Name = "Game", CategoryId = 1 };


            Console.WriteLine(product.Equals(product2));

            // Yeni copyalar üretme
            var product3 = product with { CategoryId = 30 };


            var employee = new Employee("Fatih", "Çakıroğlu") { Age = 23 };
            employee.Age = 44;
            // employee.Name="ahmet" => calişmaz






        }
    }
}
