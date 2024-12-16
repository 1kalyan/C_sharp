using System;

// Parent class
class Animal
{
    // Virtual method that can be overridden in a child class
    public virtual void Sound()
    {
        Console.WriteLine("Some animal sound");
    }
}

// Child class 1
class Dog : Animal
{
    // Overriding the Sound method
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Child class 2
class Cat : Animal
{
    // Overriding the Sound method
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a parent class reference and child class objects
        Animal myAnimal;   // Base class reference

        myAnimal = new Dog();
        myAnimal.Sound();  // Outputs: Dog barks

        myAnimal = new Cat();
        myAnimal.Sound();  // Outputs: Cat meows

        Console.ReadLine();
    }
}
