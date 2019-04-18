using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9Ex
{

    // Cat Class;
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }

        public Cat(string name, int age, Color colo, bool isLazy) : base(name, age, colo)
        {
            Name = name;
            Age = age;
            Colo = colo;
            IsLazy = isLazy;
        }

        // Cat Method - Meow;
        public void CatMeow()
        {
            Console.WriteLine("MEOW MEOW!!!");
        }

        // Innherited Method from Animal - PrintAll;
        public override void PrintAll()
        {

            Console.WriteLine($"CatName: {Name}, " +
                $"CatAge: {Age}, " +
                $"CatColor: {Colo}, " +
                $"CatStatus: {IsLazy}. ");
        }
    }
}
