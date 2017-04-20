using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.ReservationSystem
{
    public class Event
    {
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        
        public List<Visitor> Visitors { get; private set; }
        public List<Location> Locations { get; private set; }
        public List<Material> Material { get; private set; }

        // constructor om nieuwe event aan te maken
        public Event(string name, string description)
        {
            this.ID = reservationRepo.GetEventID(name);
            this.Name = name;
            this.Description = description;
            Visitors = new List<Visitor>();
            Material = new List<Material>();
        }

        // constructor om event aan te maken die al bestaat in database
        public Event(string name)
        {
            this.ID = reservationRepo.GetEventID(name);
            this.Name = name;
            this.Description = reservationRepo.GetEventDescription(this.ID);

            //Deze moet eigenlijk ipv een nieuwe lijst maken een lijst pakken met alle visitors uit de database die bij dit event horen
            Visitors = new List<Visitor>();
            Material = new List<Material>();
        }

        public Location AddLocation(int number, string features, string type)
        {
            if (number >= 0 && features != null && type != null)
            {
                Location location = new Location(number, features, type);
                this.Locations.Add(location);

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

                return material;
            }
            return null;
        }
    }
}
