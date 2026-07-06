/**
 * Object
 *
 * An object in C++ is an instance of a class that represents a real-world entity.
 * It is used to access the data members and member functions defined in the class.
 *
 * State: Represents the current values of an object's data members.
 * Behavior: Represents the actions an object can perform through its member functions.
 * Identity: Every object has a unique memory location that distinguishes it from other objects, even if they contain the same data.
 *
 * Example: Dog is a class, while Tommy is an object (instance) of that class.
 */

#include <iostream>

class Car
{
public:
    std::string brand;

    void display()
    {
        std::cout << "Car brand is: " << brand << std::endl;
    }
};

int main()
{
    Car car1;
    car1.brand = "Toyota";
    car1.display();
    return 0;
}