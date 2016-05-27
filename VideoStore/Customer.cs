using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    internal class Customer
    {
        private String name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(String name)
        {
            this.name = name;
        }
        /// <summary>
        /// Adds a rental to the customer.
        /// </summary>
        /// <param name="arg">A rental to add to the customer.</param>
        public void AddRental(Rental arg)
        {
            this.rentals.Add(arg);
        }

        public String GetName()
        {
            return this.name;
        }

        public String Statement()
        {            
            String result = "Rental Record for " + this.GetName() + "\n";
            foreach (var each in this.rentals)
            {
                //show figures for this rental
                result += "\t" + each.GetMovie().GetTitle() + "\t" +
                          each.GetCharge() + "\n";
            }
            //add footer lines
            result += "Amount owed is " + this.GetTotalCharge() +
                      "\n";
            result += "You earned " + this.GetTotalFrequentRenterPoints()
                      +
                      " frequent renter points";
            return result;
        }

        public String HtmlStatement()
        {
            String result = "<H1>Rentals for <EM>" + this.GetName() + "</EM></H1 ><P >\n";
            foreach (var rental in this.rentals)
            {

                //show figures for each rental
                result += rental.GetMovie().GetTitle() + ": " +
                          rental.GetCharge() + "<BR>\n";
                //add footer lines
                result += "<P>You owe <EM>" + this.GetTotalCharge() + "</EM><P>\n";
                result += "On this rental you earned <EM>" +
                          this.GetTotalFrequentRenterPoints() +
                          "</EM> frequent renter points<P>";
            }
            return result;    
    }

        private double GetTotalCharge()
        {
            double result = 0;
            foreach (var rental in this.rentals)
            {
                result += rental.GetCharge();
            }
            return result;
        }

        private int GetTotalFrequentRenterPoints()
        {
            int result = 0;
            foreach (var rental in this.rentals)
            {
                result += rental.GetFrequentRenterPoints();
            }
            return result;
        }


    }
}
