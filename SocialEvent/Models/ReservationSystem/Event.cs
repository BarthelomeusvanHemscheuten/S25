using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;

namespace Models.ReservationSystem
{
    class Event
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        
        public List<Visitor> Visitors { get; private set; }
        public List<Location> Locations { get; private set; }

        
        public Event(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public bool Reserve(List<Visitor> visitors, List<Location> locations)
        {
            this.Visitors = visitors;
            this.Locations = locations;
            return false;
        }
    }
}
