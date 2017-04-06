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

        public bool AddLocation(int number, string features, string type)
        {
            if (number > 0 && features != null && type != null)
            {
                EVENT.AddLocation(number, features, type);

                return true;
            }
            return false;
        }

        public List<Material> AddMaterial(string name, string description, double price, int quantity)
        {
           List<Material> result = new List<Material>();

            if (name != null && description != null && price > 0 && quantity > 0)
            {
                for (int i = 0; i < quantity; i++)
                {
                    result.Add(EVENT.AddMaterial(name, description, price));
                }

                return result;
            }
            return null;
        }

        public List<Material> GetAndShowMaterialFromDatabase()
        {
            List<Material> result = new List<Material>();

            List<double> price = new List<double>();
            List<string> name = new List<string>();
            List<string> description = new List<string>();

            price = reservationRepo.GetAllMaterialsPrice();
            name = reservationRepo.GetAllMaterialsName();
            description = reservationRepo.GetAllMaterialsDescription();

            for (int i = 0; i < name.Count; i++)
            {
                Material material = new Material(name[i], description[i], price[i]);
                result.Add(material);
            }

            return result;
        }
    }
}
