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
