class Car
{
    public string Color = "Red";
}

class Program
{
    static void Main()
    {
        var car = new Car();
        Console.WriteLine("Car color is: " + car.Color);
    }
}