using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialEvent
{
    class Event
    {
        private string name;
        private Reservation reservation;
        private Item item;
        public Event(string name, Reservation reservation, Item item)
        {
            this.reservation = reservation;
            this.item = item;
            this.name = name;
        }
    }
}
