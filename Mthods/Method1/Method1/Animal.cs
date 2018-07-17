
//overriding exmaple

using System;

namespace Method1
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating..");
        }
    }

    public class Dog: Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bun");

        }
    }
    public class TestOverriding
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.eat();
        }
    }
}
