using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;

namespace Models.ReservationSystem
{
    class Material
    {
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());

        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double Price { get; private set; }

        public Material(string name, string description, double price)
        {
            this.ID = reservationRepo.CountMaterial() + 1;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
