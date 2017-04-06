using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.ReservationSystem
{
    public class Material
    {
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double Price { get; private set; }

        // constructor om nieuwe material aan te maken 
        public Material(string name, string description, double price)
        {
            this.ID = reservationRepo.CountMaterials() + 1;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        // constructor om material aan te maken die al bestaat in database
        public Material(int id, string name, string description, double price)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
