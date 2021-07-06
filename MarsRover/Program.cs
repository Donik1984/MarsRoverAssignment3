using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine();
            Rover myRover = new Rover(20, "fdsf");
            Console.WriteLine("\n" + myRover.ToString() + "\nRover is captured by Aliens");


        }
    }
}
