using System;
using Exercise6;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This application will create a Snake object.");
                Console.WriteLine();

                //Creating an instance of the derived class, and assigning value to all of the object properties
                Snake snake = new Snake() { Color = "Black", Habitat = "Forest", SizeInFeet = 7 };
                snake.Breed = "Black Mamba";
                snake.Type = AnimalType.Reptile;

                //Displaying the value of object properties
                Console.WriteLine("The snake is a {0}.", snake.Type);
                Console.WriteLine("The breed of the snake is {0}.", snake.Breed);
                Console.WriteLine("The snake is color {0}.", snake.Color);
                Console.WriteLine("The habitat of the snake is the {0}.", snake.Habitat);
                Console.WriteLine("The size of the snake in feet is {0}.", snake.SizeInFeet);
                Console.WriteLine();

                //Invoking all of the object actions
                Console.WriteLine("Actions inherited by the snake:");
                Console.WriteLine();
                snake.Grow();
                snake.Move();
                snake.Response();
                snake.Reproduce();
                snake.Respire();
                snake.Excrite();
                snake.MakeNoise();
                snake.Sleep();

                Console.WriteLine();
                Console.WriteLine("Actions by the snake:");
                Console.WriteLine();
                snake.Glides();
                snake.Hiss();
                snake.EmitsVenom();

                Console.Read();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
