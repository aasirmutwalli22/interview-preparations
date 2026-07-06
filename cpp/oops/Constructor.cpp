/**
 * Constructor
 *
 * A constructor is a special member function of a class that is automatically called when an object is created.
 * It is mainly used to initialize the object's data members and establish its initial state.
 *
 * - A constructor has the same name as the class.
 * - It does not have a return type, not even void.
 * - It is automatically invoked whenever an object of the class is created.
 * - It helps initialize object properties during object creation.
 *
 * Example: When creating a Car object, a constructor can automatically initialize data members such as brand, model, and color.
 *
 * Types of Constructors
 *
 * C++ provides different types of constructors that are used to initialize objects in different ways.
 *
 * - Default Constructor: A constructor that takes no parameters and initializes an object with default values.
 * - Parameterized Constructor: A constructor that accepts one or more parameters to initialize an object with user-defined values.
 * - Copy Constructor: A constructor that creates a new object by copying the state of an existing object of the same class.
 * - Move Constructor (C++11): A constructor that transfers the resources of a temporary object to a new object instead of copying them, improving performance.
 */

#include <iostream>

// default constructor
class Fruit
{
public:
    std::string name;
};

class Car
{
public:
    std::string model;

    // default constructor
    Car()
    {
    }
    // parameterized constructor
    Car(std::string modelName)
    {
        model = modelName;
    }
    // copy constructor
    Car(Car &car)
    {
        model = car.model;
    }
};

class Animal
{
public:
    std::string name;
    // Move Constructor
    Animal(std::string &&a) : name(move(a))
    {
        std::cout << "Move constructor called!" << std::endl;
    }
    void display()
    {
        std::cout << name << std::endl;
    }
};

int main()
{
    Car car1("Audi");

    // Creating another object from a1
    Car car2(car1);

    std::cout << car2.model << std::endl;
    /////////

    std::string animalName = "Cat";
    Animal animal1(move(animalName));
    animal1.display();

    return 0;
}
