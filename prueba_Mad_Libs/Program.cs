using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             This program is a mad libs word game and we need to complete the blank space with the words.
             Author: @Justine Arriaga
            */

            Console.WriteLine("The game has started!");
            string title = "Word game!";

            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter a adjective: ");
            string adjective_1 = Console.ReadLine();

            Console.Write("Enter a adjective: ");
            string adjective_2 = Console.ReadLine();

            Console.Write("Enter a adjective: ");
            string adjective_3 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter two nouns: ");
            string noun1 = Console.ReadLine();
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter one of each of this: \n An animal \n A food \n A fruit \n A superhero \n A country \n A dessert \n a Year \n");
            string animal = Console.ReadLine();
            string food = Console.ReadLine();
            string fruit = Console.ReadLine();
            string superhero = Console.ReadLine();
            string country = Console.ReadLine();
            string dessert = Console.ReadLine();
            string year = Console.ReadLine();



            string story = $"This morning {name} woke up feeling {adjective_1}. 'It is going to be a {adjective_2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective_3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";
            Console.WriteLine(story);
        }
    }
}
