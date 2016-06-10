using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Desert
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var numberofGuests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriePrice = decimal.Parse(Console.ReadLine()); // na KG

            var sets = numberofGuests/6;
            if (numberofGuests % 6 != 0)
            {
                sets++;
            }
            var pricePerSet = 2*bananaPrice + 4*eggPrice + 0.2m * berriePrice;
            var moneyNeeded = sets*pricePerSet;

            if (cash < moneyNeeded)
            {
                var shortage = moneyNeeded - cash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",shortage);
            }
            else
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",moneyNeeded);
            }
        }
    }

