using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaSharingSysteem
{
    class Event
    {
        private string name;
        private List<Reservation> reservations;
        private List<Material> materials;
        public Event(string name, List<Reservation> reservations, List<Material> materials)
        {
            this.reservations = reservations;
            this.materials = materials;
            this.name = name;
        }
    }
}
