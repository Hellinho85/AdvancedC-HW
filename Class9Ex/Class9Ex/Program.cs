using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9Ex
{
    class Program
    {
        // Magic Delegate for StringMagic Method for Task 4;
        public delegate bool MagicDelegate(string magic1, string magic2);

        static void Main(string[] args)
        {
            // Task 1 - Create Lists of 3 dogs, 3 casts and 3 birds and use Linq for various tasks;
                        
            // Lists of Animals (Dog, Cat, Bird);
            
            List<Dog> dogs = new List<Dog>()
            {
                new Dog ("Sharko", 7, Animal.Color.Black, Race.GermanSpic),
                new Dog ("Sljapko", 4, Animal.Color.Red, Race.GermanShepard),
                new Dog ("Butch", 2, Animal.Color.Brown, Race.GermanShepard)
            };

            List<Cat> cats = new List<Cat>()
            {
                new Cat ("Tom", 12, Animal.Color.Blue, true),
                new Cat ("Chappy", 1, Animal.Color.Green, false),
                new Cat ("Kia", 3, Animal.Color.Yellow, true)
            };

            List<Bird> birds = new List<Bird>()
            {
                new Bird ("Pipi", 2, Animal.Color.Purple, false),
                new Bird ("Mappy", 7, Animal.Color.Blue, false),
                new Bird ("Jinx", 1, Animal.Color.Blue, true)
            };

            // Linq - get dogs by race;
            var dogTotal = dogs.Where(x => x.Race == Race.GermanShepard)
                .OrderBy(x => x.Name)
                .ToList();
            
            // Linq - get the last lazy cat;      
            var catTotal = cats.Where(x => x.IsLazy == true)
                .Last(x => x.IsLazy == true);
            //Console.WriteLine(catTotal.Name);
           
            // Get all wild birds that are younger then 3 and ordered by their name;
            var birdTotal = birds.Where(x => x.IsWild == true && x.Age < 3)
                .OrderBy(x => x.Name)
                .ToList();

            Console.WriteLine("------------------------------------------------------------");
            
            // Task 2 - Create Extensions Methods and do the below tasks:
            
            var firstName = "Gjorgji";
            // Get the first letter of the string;
            Console.WriteLine(firstName.FirstLetter());
            // Get the last letter of the string;
            Console.WriteLine(firstName.LastLetter());

            var evenN = 7;
            // Check if the number is even;
            Console.WriteLine(evenN.isEven());

            // Input an int a returns the first (n) integers from a list;
            List<int> someNumbers = new List<int>() { 1, 7, 15, 23, 34, 48, 79, 82, 96, 100 };
            List<string> someNames = new List<string>()
            {
                "Dzole", "Riste", "Kitevac", "Nidzo", "Kiki", "Vale", "Vlatce", "Toshka"
            };

            Generics generics = new Generics();
            generics.PrintList(someNumbers.GetNfromList(5));
            generics.PrintList(someNames.GetNfromList(4));
            
            Console.WriteLine("------------------------------------------------------------");
            
            // Task 3 - Create Generic Methods - PrintList and PrintAnimals that print various inputs in the console;
            generics.PrintList(someNames);
            generics.PrintAnimals(dogs);
            
            Console.WriteLine("------------------------------------------------------------");

            // Task 4 - Create a delegate that accepts two strings and returns bool;
            
            string s1 = "Nina";
            string s2 = "Ana";

            // Compare the strings length;
            StringMagic(s1, s2, (a, g) =>
            {
                if (s1.Length > s2.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            /* Check if the first letter of the first string
            is equal to the first letter of the second string */
            StringMagic(s1, s2, (a, g) =>
            {
                if (s1.ToCharArray().First() == g.ToCharArray().First())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            /* Check if the last letter of the first string
            is equal to the last letter of the second string */
            StringMagic(s1, s2, (a, g) =>
            {
                if (s1.ToCharArray().Last() == g.ToCharArray().Last())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            Console.WriteLine("------------------------------------------------------------");

            // Task 5 - Create Publisher and 3 Subscribers for public event Message;
            
            // Event Publisher;
            Publisher p = new Publisher();

            // Event Subscribers;
            Sub1 f1 = new Sub1();
            Sub2 f2 = new Sub2();
            Sub3 f3 = new Sub3();
            
            p.EventMessageHandler += f1.FirstSubMsg;
            p.EventMessageHandler += f2.SecondSubMsg;
            p.EventMessageHandler += f3.ThirdSubMsg;
            
            // Event Message;
            p.ComposeMessage("Risto Panchevski", "SG1", "PRASHANJA :P");
        
            Console.ReadLine();

        }
               
        // String Magic Method;
        public static void StringMagic(string first, string second, MagicDelegate magicka)
        {
            var full = magicka(first, second);
            Console.WriteLine($"{first} {second}, {full.ToString()}.");
        }
        
    }
}
