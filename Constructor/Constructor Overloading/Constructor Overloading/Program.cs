using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetails us = new UserDetails();
            UserDetails us1 = new UserDetails("Lavanya", 21);

            Console.ReadKey();
        }
    }
    public class UserDetails
    {
        string user;
        int age;
        //Default Constructor
        public UserDetails()
        {
            user = "Puneeth";
            age = 22;
            Console.WriteLine("Previous User {0} and he is {1} years old", user, age);
        }
        //Parameterized Constructor
        public UserDetails(string name, int n)
        {
            user = name;
            age = n;
            Console.WriteLine("Current User {0} and she is {1} years old", user, age);
        }
         ~UserDetails()
        {
            Console.WriteLine("I'm a Destructor and i clean  the resources and free up memory as soon as prgm closed"); 
        }
    }
}


