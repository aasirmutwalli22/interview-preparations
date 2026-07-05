///
/// Properties and Encapsulation | GET and SET
/// 
/// Encapsulation: 
/// The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
/// - declare fields/variables as private
/// - provide public get and set methods, through properties, to access and update the value of a private field
/// 
/// Properties: 
/// A property is like a combination of a variable and a method, and it has two methods: a get and a set method:
/// 
/// 

namespace Test.Encapsulation;

class Person
{
    private string name; // field

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }

    public string Color { get; set; } // (automatic) property
}

class Program
{
    static void Main(string[] args)
    {
        var myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}

/// Why Encapsulation?
/// 
/// - Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
/// - Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
/// - Flexible: the programmer can change one part of the code without affecting other parts
/// - Increased security of data
