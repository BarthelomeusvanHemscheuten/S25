using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;

namespace Models.ReservationSystem
{
    class Event
    {
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        
        public List<Visitor> Visitors { get; private set; }
        public List<Location> Locations { get; private set; }
        public List<Material> Material { get; private set; }

        
        public Event(string name, string description)
        {
            this.ID = reservationRepo.CountEvents() + 1;
            this.Name = name;
            this.Description = description;
        }

        public Location AddLocation(int number, string features, string type)
        {
            if (number >= 0 && features != null && type != null)
            {
                Location location = new Location(number, features, type);
                this.Locations.Add(location);
                reservationRepo.InsertLocation(number, features, type); //check

                return location;
            }
            return null;
        }

        public Material AddMaterial(string name, string description, double price)
        {
            if (name != null && description != null && price >= 0)
            {
                Material material = new Material(name, description, price);
                this.Material.Add(material);
                reservationRepo.InsertMaterial(name, description, price); //check

                return material;
            }
            return null;
        }
    }
}
