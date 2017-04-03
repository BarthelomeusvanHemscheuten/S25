using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Users
{
    class Employee : User
    {
        public Employee(string username, string name, string password, string emailAddress, string telnr, string address, DateTime dateOfBirth) : base(username, name, password, emailAddress, telnr, address, dateOfBirth)
        {

        }
        public bool AddVisitor(Visitor visitor)
        {
            return false;
        }

        public bool DeleteVisitor(Visitor visitor)
        {
            return false;
        }
    }
}
