using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9Ex
{
    
    // Dog Class;

    public class Dog : Animal
    {

        public Race Race { get; set; }

        public Dog(string name, int age, Color colo, Race race) : base(name, age, colo)
        {
            Name = name;
            Age = age;
            Colo = colo;
            Race = race;
        }

        // Dog Method - Barking;
        public void DogBark()
        {
            Console.WriteLine("BARK BARK!!!");
        }


        // Innherited Method from Animal - PrintAll;
        public override void PrintAll()
        {
            Console.WriteLine($"DogName: {Name}, " +
                $"DogAge: {Age}, " +
                $"DogColor: {Colo}, " +
                $"DogRace: {Race}. ");
        }

    }

    // Dog enum - Race;
    public enum Race
    {
        Bulldog,
        Mastif,
        GermanSpic,
        Hask,
        GermanShepard,
        Pitbull,
    }
}
