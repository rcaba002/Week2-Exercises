using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Long Road Home: A Mad Libs Word Game");
            Console.WriteLine();
            Console.WriteLine("Story 1: Boy Who Cried Wolf");
            Console.WriteLine("Story 2: Big Bad Wolf");
            Console.WriteLine("Story 3: Three Little Pigs");

            chooseStory();
        }

        static void chooseStory()
        {
            Console.WriteLine();
            Console.Write("Pick a story (1-3) or enter a negative number to exit: ");
            string userInput = Console.ReadLine();
            int value;

            if (userInput == "1" || userInput == "2" || userInput == "3")
            {
                if (userInput == "1")
                    story1();
                else if (userInput == "2")
                    story2();
                else story3();
            }
            else
            {
                if (int.TryParse(userInput, out value) && value < 0)
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("I did not understand your entry.");
                    chooseStory();
                }
            }
        }

        static void story1()
        {
            Console.Write("Give me a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Give me an adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Give me Plural Noun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("Give me a verb ending in -ing: ");
            string verb = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Let's begin!");
            Console.WriteLine();

            Console.WriteLine("There once was a shepherd boy who lived in a village. He didn't care about anything but his "
                + noun + ". The villagers were fed up with his " + adjective + " lies. When the boy was " + verb + ", the villagers "
                + "threw him in a van and sent him to " + pluralNoun + ".");
            chooseStory();
        }

        static void story2()
        {
            Console.Write("Give me a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Give me an adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Give me Plural Noun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("Give me a verb ending in -ing: ");
            string verb = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Let's begin!");
            Console.WriteLine();

            Console.WriteLine("In a land far far away, lived a little girl with " + adjective + " hair. She was on her way to "
                + "her grandmother's house when she came across a wolf. Startled, she began " + verb + "! To distract herself "
                + "she pulled out her " + noun + " and sang songs about " + pluralNoun + ".");
            chooseStory();
        }

        static void story3()
        {
            Console.Write("Give me a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Give me an adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Give me Plural Noun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("Give me a verb ending in -ing: ");
            string verb = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Let's begin!");
            Console.WriteLine();

            Console.WriteLine("There were three little pigs that lived in a " + noun + ". They never left their home because they "
                + "were afraid of the big " + adjective + " wolf. One day while they were " + verb + ", they heard a knock on "
                + "their door. It was not the wolf. It was just a man sellig magazine subscriptions to " + pluralNoun + " weekly.");
            chooseStory();
        }
    }
}