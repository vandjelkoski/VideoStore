using System;

namespace VideoStore
{
    public class Movie
    {
        public const int Childrens = 2;
        public const int Regular = 0;
        public const int NewRelease = 1;
        private readonly string title;
        private Price price;

        public Movie(String title, int priceCode)
        {
            this.title = title;
            this.SetPriceCode(priceCode);
        }
        /// <summary>
        /// GetPriceCode
        /// </summary>
        /// <returns></returns>
        public int GetPriceCode()
        {
            return price.GetPriceCode();
        }
        public void SetPriceCode(int arg)
        {
            switch (arg)
            {
                case Regular:
                    price = new RegularPrice();
                    break;
                case NewRelease:
                    price = new NewReleasePrice();
                    break;
                case Childrens:
                    price = new ChildrensPrice();
                    break;
            }
        }
        public String GetTitle()
        {
            return title;
        }

        public double GetCharge(int daysRented)
        {
            return price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            if ((this.GetPriceCode() == NewRelease) && daysRented > 1)
                return 2;
            else
                return 1;            
        }
    }
}
