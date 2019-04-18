using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9Ex
{

    // Abstract Class - Animal (Dog, Cat and Bird innherit from this Class);

    public abstract class Animal
    {
        public string Name { get; set; }
        private int _age { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value > 175)
                {
                    Console.WriteLine($"Incorrect value {value}. Try again!");
                }
                else _age = value;
            }
        }

        public Color Colo { get; set; }

        public Animal()
        {

        }

        public Animal(string name, int age, Color colo)
        {
            Name = name;
            Age = age;
            Colo = colo;
        }

        // Abstract Method;
        public abstract void PrintAll();

        // Enum - Color;
        public enum Color
        {
            Black,
            Blue,
            Red,
            Brown,
            Green,
            Yellow,
            Purple
        }

    }
}
