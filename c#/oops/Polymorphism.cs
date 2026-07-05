///
/// Polymorphism and Overriding Methods
/// 
/// Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
/// 
/// Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. 
/// Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways.
/// 
/// For example, think of a base class called Animal that has a method called animalSound(). 
/// Derived classes of Animals could be Pigs, Cats, Dogs, Birds - 
/// And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.):
/// 
/// Remember from the Inheritance chapter that we use the : symbol to inherit from a class.

namespace Test.Polymorphism;

class Animal  // Base class (parent) 
{
    public void greet()
    {
        Console.WriteLine("The animal makes a sound");
    }
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public void greet()
    {
        Console.WriteLine("The pig says: wee wee");
    }
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public void greet()
    {
        Console.WriteLine("The dog says: bow wow");
    }
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

/// 
/// Not The Output I Was Looking For
/// 
/// The output from the example above was probably not what you expected. 
/// That is because the base class method overrides the derived class method, when they share the same name.
/// 
/// However, C# provides an option to override the base class method, 
/// by adding the virtual keyword to the method inside the base class, 
/// and by using the override keyword for each derived class methods:
/// 


class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        myAnimal.greet();       // outputs: The animal makes a sound
        myPig.greet();          // outputs: The animal makes a sound
        myDog.greet();          // outputs: The animal makes a sound

        myAnimal.animalSound(); // outputs: The animal makes a sound
        myPig.animalSound();    // outputs: The pig says: wee wee
        myDog.animalSound();    // outputs: The dog says: bow wow


    }
}

///
/// Why And When To Use "Inheritance" and "Polymorphism"?
/// - It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.
/// 