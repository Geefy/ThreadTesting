using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacerBilThread
{
    class RacingTrack
    {
        private List<Thread> racers = new List<Thread>();
        public RacingTrack(int racers)
        {
            for (int i = 1; i <= racers; i++)
            {
                Thread a;
                this.racers.Add(a = new Thread(new RacerBil("Racer " + i, "Sponsor" + i).Drive));
            }
        }

        public void RaceStart()
        {
            foreach (Thread racer in this.racers)
            {
                racer.Start();
            }
        }
    }
}
