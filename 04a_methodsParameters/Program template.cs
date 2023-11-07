// Kyomari Brunswick, MethodsParameters, v0.3
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD -- named block of code, can be used over and over.
        // All methods have a SIGNATURE that defines their name, parameters, and output.
        // EXAMPLE Signature
        static void MyMethod() 
        {
            Console.WriteLine("I like mine with lettuce and tomatoes, Heinz 57, and french fried potatoes.\n");
        }
        // static -- This method belongs to the current class, it's NOT an object
        // void -- This method has no return value 

        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            //sum *= 2;
            //console.WriteLine(sum);
            return sum;
        }

        // Methods with Parameters
        static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("One golden, bacon pancake coming up!\n");
            }
        }

        static void MakeEggs(int num, string style)
        {
            Console.WriteLine("You have ordered" + num + "eggs cooked " + style + ".\n");
        }

        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I'm going to cook " + num + "cheeseburgers.\n");
        }


        // Named Arguments
        static void Allmychildren(string child1, string child2, string child3)
        {
            console.WriteLine("My favorite child is " + child3)
        }

        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            //MakePancakes(10);
            //MakeEggs(10, "Scrambled with cheese");
            //MakeBurger();
            //MakeBurger(10);
            Allmychildren(child3: "Steve", child2: "Susan", child1: "Chew");
        }
    }
}
