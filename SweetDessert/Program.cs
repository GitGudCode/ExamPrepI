using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialCash = decimal.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var singleBananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriePriceKG = decimal.Parse(Console.ReadLine());

            var oneSetPrice = (decimal)(2*singleBananaPrice + 4*eggPrice + (berriePriceKG*0.2M)); // Cena za 1 set
            var setsNeeded = Math.Ceiling(numberOfGuests / 6M);
            var priceOfProducts = oneSetPrice*setsNeeded;

            if (numberOfGuests > 6)
            {
                if (initialCash < priceOfProducts)
                {
                    Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",priceOfProducts-initialCash);
                }
                else
                {
                    Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", priceOfProducts);
                }
            }
            else
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", oneSetPrice);
            }
        }
    }
}
