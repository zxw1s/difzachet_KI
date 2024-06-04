using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Putevka> putevki = new List<Putevka>
            {
                new Putevka { Id = 1, Name = "hotel 1", Country = "Spanish", Kolvo = 2, Price = 2000 },
                new Putevka { Id = 1, Name = "hotel 2", Country = "Brazil", Kolvo = 4, Price = 4000 },
                new Putevka { Id = 1, Name = "hotel 3", Country = "Russia", Kolvo = 6, Price = 5000 }
            };
            var result = from putevka in putevki
                         select new
                         {
                             putevka.Id,
                             putevka.Name,
                             putevka.Country,
                             putevka.Kolvo,
                             putevka.Price
                         };

            foreach (var putevka in result)
            {
                Console.WriteLine($"Путёвка:{putevka.Id}, Отель:{putevka.Name}, Страна:{putevka.Country}, Количество:{putevka.Kolvo}, Цена:{putevka.Price}");
            }
            Console.ReadLine();
        } 
    }
}
