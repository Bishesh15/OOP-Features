using System;

namespace FullstackDemo
{
    abstract class Animal
    {
        public string Name { get; set; }

        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine(Name + " is eating.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(Name + " says: Woof Woof!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(Name + " says: Meow!");
        }
    }

    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }

        public void ShowAge()
        {
            Console.WriteLine("Age: " + age);
        }
    }

    internal class Features
    {
        public void Run()
        {
            Person p = new Person();
            p.Age = 19;
            p.ShowAge();

            Animal dog = new Dog();
            dog.Name = "Tommy";
            dog.MakeSound();
            dog.Eat();

            Animal cat = new Cat();
            cat.Name = "Kitty";
            cat.MakeSound();
            cat.Eat();
        }
    }
}