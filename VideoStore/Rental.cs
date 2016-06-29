namespace VideoStore
{
    class Rental
    {
        private readonly Movie movie;
        private readonly int daysRented;

        /// <summary>
        /// Rental
        /// </summary>
        /// <param name="movie">The movie.</param>
        /// <param name="daysRented">Days rented.</param>
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

        /// <summary>
        /// GetMovie.
        /// </summary>
        /// <returns>Retursn the movie.</returns>
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
