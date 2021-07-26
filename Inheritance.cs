// Use classes from the System namespace
using System;
// Organize code 
namespace Inheritance
{   
    // Create a class (parent)
    class Size
    {
        //Declaring fields
        public int q1;
        public int q2;
    }
    // The Area class (child) inherits the fields from the Size class (parent)
    class Area : Size
    {
        // Create a method 
        public int GetArea()
        {
        //Terminates execution of the method, and returns the area value
        return base.q1*base.q2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object 
            Area myAr = new Area();
            // Output text
            Console.WriteLine("Enter width (m):");
            /* The user input is taken, the string is converted to an int and stored in myAr.q1; 
            (the field "q1" in the parent class is accessed through the dot syntax)
            */  
            myAr.q1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length (m):");
            myAr.q2 = Convert.ToInt32(Console.ReadLine());
            // Call the  method from the child class on the "myAr" object
            Console.WriteLine("The area is: " + myAr.GetArea() + " sq.m \n");
            Console.WriteLine("Press a key to continue ...");
            // The program waits for a key to be pressed
            Console.ReadKey();
        }
    }
}

