using System;

namespace OOPpractice
{
    class Car
    {   
        //we name it public so that the program class can access the color variable 
        string color = "red";
        int maxSpeed = 200;
        int year;
    

    // class MyCar
    // {
    //     string color = "red";
    //     int maxSpeed = 200;
    //     public void fullThrottle()
    //     {
    //         Console.WriteLine("The car is in maximum overdrive");
    //     }
    // }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // class is fruit, apples and oranges are objects of the fruit class
            // class is car, toyota and ford are objects of the car class
            // class is a template for objects, and an object is an instance of the class
            //when objects are created, they inherit all variables and methods from the class
            
            // Car is class, myObj is the name of instance of the class car.
            //new is a new car being created

            // Car myObj = new Car();
            // Car myObj2 = new Car();
            // Console.WriteLine(myObj.color);
            // Console.WriteLine(myObj2.color);

            //the following will crate an object of the carr class with the name myObj. 
            //then we print the value of the fields color and max speed
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);

        }
    }
    }
}