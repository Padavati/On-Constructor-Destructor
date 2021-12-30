using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Constructor ctr1= new Constructor();
            Constructor ctr2 = new Constructor("I'm a next Parameterized msg");
            Constructor ctr3 = new Constructor(5,15);

            Console.ReadKey();
        }
    }
    public class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("I'm a default constructor");
        }
        public Constructor(string message)
        {
            Console.WriteLine(message);
        }
        public Constructor(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Adding of two numbers:" + sum);
        }
    }

}
