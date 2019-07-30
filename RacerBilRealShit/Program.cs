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

            RacingTrack mainTrack = new RacingTrack(9);
            mainTrack.RaceStart();
            Console.WriteLine("Welcome to the world championship in racing");
            Console.ReadKey();

        }
 
    }
}
