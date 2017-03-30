using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaSharingSysteem
{
    class Admin : User
    {
        public Admin()
        {

        }

        public void AddEvent(string name)
        {
            Event myevent = new Event(name);
        }
        public void AddMaterial(string desc, string name, decimal price)
        {
            Material material = new Material(desc, name, price);

        }

        public void DeleteUser(Visitor visitor)
        {
            visitor = null;
        }
    }
}
