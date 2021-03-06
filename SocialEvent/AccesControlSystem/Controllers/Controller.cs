﻿using System;
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

        public bool hasPayed(string RFID)
        {
            return userRepo.GetPayedFromRFID(RFID);
        }

        public string GetUsername(string RFID)
        {
            return userRepo.GetUsernameFromRFID(RFID);
        }

        public bool CheckIn(string RFID)
        {
            return userRepo.CheckOutOrIn(RFID, 1);
        }

        public bool CheckOut(string RFID)
        {
            return userRepo.CheckOutOrIn(RFID, 0);
        }

        public List<string> GetAllPresentUsers()
        {
            return userRepo.GetAllPresentUsers();
        }
    }
}
