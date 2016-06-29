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

        /// <summary>
        /// GetDaysRented.
        /// </summary>
        /// <returns>Returns days rented.</returns>
        public int GetDaysRented()
        {
            return this.daysRented;
        }

        public Movie GetMovie()
        {
            return this.movie;
        }

        /// <summary>
        /// GetCharge.
        /// </summary>
        /// <returns>Returns charge.</returns>
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
