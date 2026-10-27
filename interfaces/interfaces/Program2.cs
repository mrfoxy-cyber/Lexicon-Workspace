using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    internal class Program2: IProgram
    {
        public void Go()
        {
            Console.WriteLine("Program 2 Go");
        }

        public void Start()
        {
            Console.WriteLine("Hello I am an interface");
            Go();
        }

        public void Run()
        {
            Console.WriteLine("I am interface Iporgram run inside Porgram2");
        }
    }
}
