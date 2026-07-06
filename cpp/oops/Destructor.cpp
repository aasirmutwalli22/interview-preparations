/**
 * Destructor
 *
 * A Destructor is a special member function that is automatically invoked when an object is destroyed.
 * It is primarily used to release resources such as dynamically allocated memory, open files, or network connections.
 *
 * - Destructor name is the same as the class name, preceded by a tilde (~).
 * - A class can have only one destructor.
 * - It does not accept parameters and has no return type.
 * - It is automatically called when an object goes out of scope or is deleted.
 *
 * Example: When a File object is destroyed, its destructor can automatically close the file and release associated resources.
 */

#include <iostream>

class Animal
{
public:
    // User-Defined Constructor
    Animal()
    {
        std::cout << "Constructor called" << std::endl;
    }
    // User-Defined Destructor
    ~Animal()
    {
        std::cout << "Destructor called" << std::endl;
    }
};

class Car
{
private:
    // Pointer to dynamically
    // allocated memory
    int *data;

public:
    Car(int value)
    {
        data = new int;
        *data = value;
        std::cout << *data << std::endl;
    }

    // User-defined destructor: Free
    // the dynamically allocated memory
    ~Car()
    {
        // Deallocate the dynamically
        // allocated memory
        delete data;
        std::cout << "Destructor: Memory deallocated" << std::endl;
    }
};

int main()
{
    Animal cat;

    Car ford(20);

    return 0;
}
/**
 * where, tilda(~) is used to create destructor of a className.
 *
 * When do we need to write a user-defined destructor?
 *
 * - If we don’t write a destructor, the compiler provides a default one.
 * - The default destructor works fine for classes without dynamic memory or pointers.
 * - If a class has pointers or dynamically allocated memory, we must write a destructor.
 * - A user-defined destructor releases memory or other resources before the object is destroyed.
 * - Writing a destructor in such cases prevents memory leaks.
 */

/**
 * When is the destructor called?
 *
 * - When the function ends.
 * - When the program ends.
 * - When when a block containing local variables ends.
 * - When a delete operator is called.
 *
 * ```
 * #include <iostream>
 * using namespace std;
 *
 * int Count = 0;
 *
 * class Test {
 * public:
 *     Test(){
 *
 *         // Number of times constructor is called
 *         Count++;
 *         cout << "No. of Object created: "
 *              << Count << endl;
 *     }
 *     ~Test() {
 *
 *         // It will print count in decending order
 *         cout << "No. of Object destroyed: " << Count
 *              << endl;
 *         Count--;
 *     }
 * };
 *
 * int main() {
 *     Test t, t1, t2, t3;
 *     return 0;
 * }
 * ```
 *
 * output:
 * ``` bash
 * No. of Object created: 1
 * No. of Object created: 2
 * No. of Object created: 3
 * No. of Object created: 4
 * No. of Object destroyed: 4
 * No. of Object destroyed: 3
 * No. of Object destroyed: 2
 * No. of Object destroyed: 1
 * ```
 *
 */

/**
 * How to call destructors explicitly?
 *
 * Destructor can also be called explicitly for an object. We can call the destructors explicitly using the following statement:
 *
 * ``` cpp
 * object_name.~class_name()
 * ```
 * e.g. ford.~Car();
 */