using System;
namespace Course
{
    abstract class Animal
    {
        public abstract void Eat();
    }

    class Eagle : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("I am flying");
        }
        public override void Eat()
        {
            Console.WriteLine("I am eating worm");
        }
        public override void Speed()
        {
            Console.WriteLine("My speed 50 km/hour");
        }
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();

        public virtual void Speed()
        {
            Console.WriteLine("My speed 100 km/hour");
        }
    }



    abstract class Fish : Animal { }

    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("I am eating fish");
        }
    }
}
