using System;
using System.Diagnostics;

namespace Csharp9
{


    class Program
    {
        static void Main(string[] args)
        {

            //C# 9'dan önce miras aldığımız sınıfları ezdiğimizde (abstract veya virtual ile işaretlenmiş) dönüş tipini değiştiremiyorduk. c# 9 ile değiştirebiliyoruz


            var bookProduct = new BookProduct() { Name = "Kitap 1", CategoryId = 2 };

            var bookOrder = bookProduct.Order(10);

            Console.WriteLine($"Book Order:{bookOrder.BookOrderName} {bookOrder.Quantity}");
            var musicProduct = new MusicProduct { Name = "Music 1", CategoryId = 10 };

            var musicOrder = musicProduct.Order(10);

            Console.WriteLine($"Music Order:{musicOrder.MusicOrderName} {musicOrder.Quantity}");


            #region  C#9  before
            // var bookProduct = new BookProduct() { Name = "Kitap 1", CategoryId = 2 };

            // var bookOrder = (BookOrder)bookProduct.Order(10);

            // Console.WriteLine($"Book Order:{bookOrder.BookOrderName} {bookOrder.Quantity}");
            // var musicProduct = new MusicProduct { Name = "Music 1", CategoryId = 10 };

            // var musicOrder = (MusicOrder)musicProduct.Order(10);

            // Console.WriteLine($"Music Order:{musicOrder.MusicOrderName} {musicOrder.Quantity}");
            #endregion  C#9  before
        }
    }
}
