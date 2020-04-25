using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utspbosoal2
{
    class RetailItem
    {
        private String description;
        private int unitsOnHand;
        private double price;
        // Constructor
        public RetailItem(String description, int unitsOnHand, double price)
        {
            this.description = description;
            this.unitsOnHand = unitsOnHand;
            this.price = price;
        }

        // Accessor Method
        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getDescription()
        {
            return description;
        }

        public void setUnitsOnHand(int unitsOnHand)
        {
            this.unitsOnHand = unitsOnHand;
        }

        public int getUnitsOnHand()
        {
            return unitsOnHand;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public double getPrice()
        {
            return price;
        }

    }
}
