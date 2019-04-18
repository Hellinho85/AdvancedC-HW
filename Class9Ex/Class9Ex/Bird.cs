using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9Ex
{

    // Bird Class;
    public class Bird : Animal
    {
        public bool IsWild { get; set; }

        public Bird(string name, int age, Color colo, bool isWild) : base(name, age, colo)
        {
            Name = name;
            Age = age;
            Colo = colo;
            IsWild = isWild;
        }

        // Bird Method - FlySouth;
        public void FlySouth()
        {
            if (IsWild == true)
            {
                Console.WriteLine($"Bird fly south!");
            }
            else if (IsWild == false)
            {
                Console.WriteLine("This is a domesticated bird!");
            }
        }

        // Innherited Method from Animal - PrintAll;
        public override void PrintAll()
        {
            Console.WriteLine($"BirdName: {Name}, " +
                $"BirdAge: {Age}, " +
                $"BirdColor: {Colo}, " +
                $"BirdStatus: {IsWild}. ");
        }
    }
}
