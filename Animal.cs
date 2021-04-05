using System;

namespace Inheritance
{
    public class Animal
    {
        public AnimalType Type { get; set; }
        public string Breed { get; set; }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }
    }

}
