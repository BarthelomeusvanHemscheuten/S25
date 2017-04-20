using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.SQLContext;

namespace AccesControlSystem.Controllers
{
    class Controller
    {
        ReservationRepository reservationRepo = new ReservationRepository(new ReservationSQLContext());
        UserRepository userRepo = new UserRepository(new UserSQLContext());
        public Controller()
        {

        }

        public bool ScanNew(string RFID)
        {
            return userRepo.GetPayedFromRFID(RFID);
        }

    }
}
