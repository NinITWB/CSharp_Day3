using System;

namespace FanTask
{
    class Program
    {
        
        static void Main(string [] args)
        {
            Fan fan1 = new Fan();
            fan1.Speed = 5;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;
            Console.WriteLine(fan1.ToString());

            Fan fan2 = new Fan();
            fan2.Speed = 2;
            Console.WriteLine(fan2.ToString());
        }
    } 
}

