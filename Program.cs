using System;

namespace OTUS_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrocopter quadrocopter = new Quadrocopter();
            quadrocopter.Charge();
            Console.ReadKey(true);
        }
    }
}
