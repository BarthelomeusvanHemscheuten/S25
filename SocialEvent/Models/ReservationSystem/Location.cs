using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.ReservationSystem
{
    class Location
    {
        public int Number { get; private set; }
        public string Features { get; private set; }
        public string Type { get; private set; }

        public Location(int number, string features, string type)
        {
            this.Number = number;
            this.Features = features;
            this.Type = type;
        }
    }
}
