using System;

// ABSTRACTION
abstract class Animal
{
    public string Name { get; set; }

    // Abstract method
    public abstract void MakeSound();

    // Normal method
    public void Eat()
    {
        Console.WriteLine(Name + " is eating.");
    }
}

// INHERITANCE
class Dog : Animal
{
    // POLYMORPHISM (Method Overriding)
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

// ENCAPSULATION
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

class Program
{
    static void Main(string[] args)
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

        Console.ReadLine();
    }
}