using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



    class PopulationAggregation
    {
        static void Main(string[] args)
        {
        var townsByCountry = new SortedDictionary<string, HashSet<string>>();
        var populationByTown = new Dictionary<string, decimal>();


            while (true)
            {
                var cmd = Console.ReadLine();
                
                if (cmd == "stop")
                {
                    break;
                }
                var cmdTokens = cmd.Split('\\');
                 var country = RemoveBadChars(cmdTokens[0]);
                var town = RemoveBadChars(cmdTokens[1]);
                if (!char.IsUpper(country[0]))
                {
                    var old = country;
                    country = town;
                    town = old;
                } 
                //Add the current town to current country
                if (townsByCountry.ContainsKey(country))
                {
                    townsByCountry[country].Add(town);
                } else 
                townsByCountry[country] = new HashSet<string> {town};

                //Add the current population to the current town
                var population = decimal.Parse(cmdTokens[2]);
                if (populationByTown.ContainsKey(country))
                {
                    populationByTown[town] += population;
                }
                else
                    populationByTown[town] = population;

            }
            foreach (var countryAndTown in townsByCountry)
            {
                Console.WriteLine("{0} -> {1}", countryAndTown.Key,countryAndTown.Value.Count);
            }
            var topThree = populationByTown.OrderBy(p => p.Value).Take(3);
            foreach (var p in topThree)
            {
                Console.WriteLine("{0} -> {1}", p.Key,p.Value); 
            }
        }

        static string RemoveBadChars(string str)
        {
        var validCharsOnly = str.Split("@#$&1234567890".ToArray());
        var combined = String.Concat("", validCharsOnly);
            return combined;

        }
    }

