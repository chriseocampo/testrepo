using System;

namespace Inheritance
{
   
    public class LivingThing:Animal 
    {
        public void Grow()
        {
            Console.WriteLine("LivingThing is growing.");
        }

        public void Move()
        {
            Console.WriteLine("LivingThing is moving.");
        }

        public void Response()
        {
            Console.WriteLine("LivingThing is responding.");
        }

        public void Reproduce()
        {
            Console.WriteLine("LivingThing is reproducing.");
        }

        public void Respire()
        {
            Console.WriteLine("LivingThing is respiring.");
        }

        public void Excrite()
        {
            Console.WriteLine("LivingThing is excriting.");
        }
    }
}
