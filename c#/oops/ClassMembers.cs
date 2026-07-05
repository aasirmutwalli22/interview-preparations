///
/// Class Members
/// Fields and methods inside classes are often referred to as "Class Members":
/// 
/// 

// The class
namespace Test;

public class Car
{
    // Class members
    public string Color;                // field
    public int MaxSpeed = 200;          // field
    public void FullThrottle()          // method
    {
        var color = Color;
        Console.WriteLine("The car is going as fast as it can!");
    }

    public static void Main()
    {
        var car = new Car();
        car.Color = "Red";
        car.MaxSpeed = 0;
        car.FullThrottle();
    }
}

