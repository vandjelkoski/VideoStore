using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Rental
    {
        private Movie movie;
        private int daysRented;

        public Rental(Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        public int GetDaysRented()
        {
            return this.daysRented;
        }

        /// <summary>
        /// GetMovie.
        /// </summary>
        /// <returns>Retursn the movie.</returns>
        public Movie GetMovie()
        {
            return this.movie;
        }

        public double GetCharge()
        {
            return this.GetMovie().GetCharge(this.daysRented);
        }

        public int GetFrequentRenterPoints()
        {
            return this.GetMovie().GetFrequentRenterPoints(this.daysRented);
        }
    }
}
