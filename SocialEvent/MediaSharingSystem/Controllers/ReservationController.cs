using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ReservationSystem;
using DAL.Repositories;
using DAL.SQLContext;

namespace MediaSharingSystem.Controllers
{
    public class ReservationController
    {
        ReservationRepository reservationRepo;
        static Event EVENT;

        public ReservationController(string name)
        {
            reservationRepo = new ReservationRepository(new ReservationSQLContext());
            EVENT = new Event(name);
        }
        
        public static Event GetEvent { get { return EVENT; } }

        public bool AddLocation()
        {
            return false;
        }

        public bool AddMaterial(string name, string description, double price, int quantity)
        {
            if (name != null && description != null && price > 0 && quantity > 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    EVENT.AddMaterial(name, description, price);
                }

                return true;
            }
            return false;
        }

        public bool GetAndShowMaterialFromDatabase()
        {
            if (quantity > 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    
                }

                return true;
            }
            return false;
        }
    }
}
