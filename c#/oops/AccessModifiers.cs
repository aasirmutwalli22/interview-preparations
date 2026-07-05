///
/// Access Modifiers
/// 
/// 1. public 
/// > The code is accessible for all classes
/// 2. private 
/// > The code is only accessible within the same class
/// 3. protected 
/// > The code is accessible within the same class, or in a class that is inherited from that class. 
/// > Check usage in `Inheritance`
/// 4. internal 
/// > The code is only accessible within its own assembly, but not from another assembly. 
/// 

namespace Test.AccessModifiers;
class Car
{
    private string model = "Mustang";
}

class Program
{
    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.model);
    }
}