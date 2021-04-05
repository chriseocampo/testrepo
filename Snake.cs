using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;
namespace Exercise6
{
    interface ISnake
    {
        void Glides();
        void Hiss();
        void EmitsVenom();
    }
    public class Snake : LivingThing, ISnake
    {
        public string Color { get; set; }
        public string Habitat { get; set; }
        public int SizeInFeet { get; set; }
        
        
        //Methods of the snake class
        public void Glides()
        {
            Console.WriteLine("Snake is gliding.");
        }

        public void Hiss()
        {
            Console.WriteLine("Snake is hissing.");
        }

        public void EmitsVenom()
        {
            Console.WriteLine("Snake is emitting venom.");
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Snake is making noise.");
        }

        public override void Sleep()
        {
            Console.WriteLine("Snake is sleeping.");
        }
    }
}
