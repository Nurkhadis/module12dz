using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12HW
{
    class Program
    {
        static void Main()
        {
            RacingGame racingGame = new RacingGame();

            SportsCar sportsCar = new SportsCar("Sports Car", 5);
            SedanCar sedanCar = new SedanCar("Sedan Car", 3);
            Truck truck = new Truck("Truck", 2);
            Bus bus = new Bus("Bus", 1);

            sportsCar.RaceEvent += PrintRaceInfo;
            sedanCar.RaceEvent += PrintRaceInfo;
            truck.RaceEvent += PrintRaceInfo;
            bus.RaceEvent += PrintRaceInfo;

            racingGame.StartRaceEvent += sportsCar.Move;
            racingGame.StartRaceEvent += sedanCar.Move;
            racingGame.StartRaceEvent += truck.Move;
            racingGame.StartRaceEvent += bus.Move;

            racingGame.FinishRaceEvent += PrintWinner;

            racingGame.StartRace();

            while (sportsCar.Position < 100)
            {
                object value = racingGame.StartRaceEvent?.Invoke();
            }

            racingGame.FinishRace(sportsCar.Name);

            Console.ReadKey();
        }

        static void PrintRaceInfo(string message)
        {
            Console.WriteLine(message);
        }

        static void PrintWinner(string winner)
        {
            Console.WriteLine($"Winner: {winner}");
        }
    }
}
