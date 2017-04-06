using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Users;
using DAL.Repositories;
using DAL.SQLContext;

namespace Models.ReservationSystem
{
    public class Location
    {
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());

        public int ID { get { return reservationRepo.GetLocationID(this.Number); } }
        public int Number { get; private set; }
        public string Features { get; private set; }
        public string Type { get; private set; }

        public List<Visitor> Visitors { get; private set; }

        public Location(int number, string features, string type)
        {
            this.Number = number;
            this.Features = features;
            this.Type = type;
        }
    }
}
