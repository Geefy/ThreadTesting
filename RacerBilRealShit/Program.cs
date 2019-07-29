using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacerBilThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread Car1 = new Thread(new RacerBil("Peter","Redbull").Drive);
            Thread Car2 = new Thread(new RacerBil("Homie", "Monster").Drive);
            Car1.Start();
            Car2.Start();
            Console.WriteLine("Welcome to the world championship in racing");
            Console.ReadKey();

        }
 
    }
}
