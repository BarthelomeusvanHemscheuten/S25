using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;

namespace Models.ReservationSystem
{
    class Material
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double Price { get; private set; }
        public Visitor Visitor { get; private set; }

        public Material(string name, string description, DateTime startDate, DateTime endDate, double price)
        {
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Price = price;
        }

        public bool RentMaterial(Visitor visitor)
        {
            this.Visitor = visitor;
            return false;
        }
    }
}
