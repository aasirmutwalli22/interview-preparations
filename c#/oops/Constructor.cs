/// <summary>
/// A constructor is a special method that is used to initialize objects. 
/// The advantage of a constructor, is that it is called when an object of a class is created. 
/// It can be used to set initial values for fields:
/// </summary>

// Create a Car class
class Car
{
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car(string ModelName)
    {
        model = ModelName; // Set the initial value for model
    }

    static void Main(string[] args)
    {
        var Ford = new Car("Mustang");  // Create an object of the Car Class (this will call the constructor)
        Console.WriteLine(Ford.model);  // Print the value of model
    }
}

// Outputs "Mustang"