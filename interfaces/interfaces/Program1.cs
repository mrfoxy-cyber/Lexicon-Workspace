using System;
using System.Collections.Generic;
using System.Text;

namespace interfaces
{
    public class Program1 : IProgram, IStop
    {
        // Implements IProgram.Run (void)

        public void Run()
        {
            Console.WriteLine("My class run");
        }
        void IProgram.Run()
        {
            Console.WriteLine("Program run");
        }

        public void Start()
        {
            Console.WriteLine("Hello I am an interface");
            ((IProgram)this).Run();
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        // Implements IStop.Run (int)
        int IStop.Run()
        {
            Console.WriteLine("Interface Istop");
            return 7;
        }
    }
}
