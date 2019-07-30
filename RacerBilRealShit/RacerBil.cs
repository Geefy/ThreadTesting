using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RacerBilThread
{
    class RacerBil
    {

        Random rnd = new Random(DateTime.Now.Millisecond);
        string driverName;
        string carSponsor;
        int speed = 5000;


        public RacerBil(string driverName, string carSponsor)
        {
            this.driverName = driverName;
            this.carSponsor = carSponsor;
        }

        public void Drive()
        {
            for (int runde = 1; runde <= 5; runde++)
            {
                IsCarBroken();
                BabyOnRoad();
                OilOnRoad();
                Thread.Sleep(speed);
                Console.WriteLine(driverName + " finished round " + runde);
            }
                Console.WriteLine(driverName + " finished race now " + DateTime.Now.TimeOfDay);
        }

        private void IsCarBroken()
        {
           
            if(rnd.Next(1, 10) > 8)
            {
                Thread.Sleep(5000);
            }
        }
        
        private void BabyOnRoad()
        {
            if(rnd.Next(1, 30) > 15)
            {
                this.speed += 500;

                if(rnd.Next(1, 30) > 25)
                {
                    Console.WriteLine("Yeet");
                }
            }
        }

        private void OilOnRoad()
        {
            if(rnd.Next(1, 20) > 10)
            {
                this.speed -= 500;
            }
        }
    }
}
