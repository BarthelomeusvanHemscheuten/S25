using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialEvent
{
    class Item
    {
        private string name;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private double price;

        public Item(string name, string description, DateTime startDate, DateTime endDate, double price)
        {
            this.name = name;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.price = price;
        }
    }
}
