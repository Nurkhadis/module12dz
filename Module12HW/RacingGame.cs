using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12HW
{
    class RacingGame
    {
        public event Car.RaceEventHandler StartRaceEvent; 

        public delegate void FinishRaceDelegate(string winner);
        public event FinishRaceDelegate FinishRaceEvent;

        public void StartRace()
        {
            Console.WriteLine("The race is started!!");
            StartRaceEvent?.Invoke("The race is started!");
        }

        public void FinishRace(string winner)
        {
            Console.WriteLine($"The race is over! Winner: {winner}");
            FinishRaceEvent?.Invoke(winner);
        }
    }
}
