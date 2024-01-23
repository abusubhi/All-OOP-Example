using System;

// Base class with encapsulation and abstraction
public abstract class Animal
{
    private string _name;

    // Property for encapsulation
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Abstract method for abstraction
    public abstract void MakeSound();
}

// Derived class (inheritance)
public class Dog : Animal
{
    private int _age;

    // Property for encapsulation
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // Constructor
    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Implementing the abstract method (abstraction)
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

// Another derived class demonstrating polymorphism
public class Cat : Animal
{
    // Constructor
    public Cat(string name)
    {
        Name = name;
    }

    // Implementing the abstract method (abstraction)
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism - using Animal as a common type
        Animal myDog = new Dog("Buddy", 3);
        Animal myCat = new Cat("Whiskers");

        // Accessing properties and invoking methods through the common type
        Console.WriteLine($"My dog's name is {myDog.Name} and it is {((Dog)myDog).Age} years old.");
        myDog.MakeSound();

        Console.WriteLine($"My cat's name is {myCat.Name}");
        myCat.MakeSound();
    }
}
