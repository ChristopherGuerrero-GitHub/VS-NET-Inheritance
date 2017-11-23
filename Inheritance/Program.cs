using System;

namespace Inheritance
{
    //This program will create a instance of the class Dog which has no instant variable/members and no
    //access modifiers/properties such as getter/setters/ access methods. However since the class Dog 
    //inherits from the parent class Animal therefore Dog object would operate with the Animal class's
    //access methods/properties/getter/setters and data members/instant variables.
    class Program
    {
        static void Main(string[] args)
        {
            
            Dog spot = new Dog();
            spot.move();

        }
    }
}