using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12HW
{
    abstract class Car
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Speed { get; set; }

        public delegate void RaceEventHandler(string message);

        public event RaceEventHandler RaceEvent;

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
            Position = 0;
        }

        public void Move()
        {
            Position += Speed;
            RaceEvent?.Invoke($"{Name} on position {Position}");
        }
    }
}
