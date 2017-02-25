using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints Hello World!
            Console.WriteLine("Hello World!"); //prints Hello World! to the command window.
            Console.WriteLine("Input what you want to see on the screen");
            string input = Console.ReadLine();
            Console.WriteLine("You typed " + input + ".");
            Console.ReadLine();  //lets the command window stay on screen without disappearing.
        }
    }
}
