using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> { "COD", "NBA2k", "Mario Cart", "Guitar Hero", "Time Crisis" };

            var games = videoGames.OrderBy(str => str.Length);

            foreach(var videogame in games)
            {
                Console.WriteLine(videogame);
                
            }

            Console.WriteLine("--------------------------");

            var letterO = videoGames.Where(letter => letter.Contains("o"));

            foreach (var letters in letterO)
            {
                Console.WriteLine(letters);
            }

            Console.WriteLine("--------------------------");

            var game = videoGames.OrderByDescending(str => str.Length);

            foreach (var videogame in game)
            {
                Console.WriteLine(videogame);

            }

            Console.WriteLine("--------------------------");

            IEnumerable<int> result = videoGames.Select(str => str.Length);

            foreach (var videogame in result)
            {
                Console.WriteLine(videogame);

            }

            Console.WriteLine("--------------------------");



        }
    }
}
