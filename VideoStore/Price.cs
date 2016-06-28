namespace VideoStore
{
    public abstract class Price
    {
        public abstract int GetPriceCode();

        public abstract double GetCharge(int daysRented);

        public virtual int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }

    public class ChildrensPrice : Price
    {
         /// <summary>
         /// Gets the pricing code for child movies.
         /// </summary>
         /// <returns>Returns the value of the pricing code.</returns>
        public override int GetPriceCode()
        {
            return Movie.Childrens;            
        }

        public override double GetCharge(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
            {
                result += (daysRented - 2) * 1.5;
            }
            return result;
        }
    }

    public class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NewRelease;
        }

        public override double GetCharge(int daysRented)
        {
            int result = daysRented*3;
            return result;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return daysRented > 1 ? 2 : 1;
        }
    }

    public class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.Regular;
        }

        public override double GetCharge(int daysRented)
        {
            double result = 1.5;
            if (daysRented > 3)
            {
                result += (daysRented - 3) * 1.5;
            }
            return result;
        }
    }
}
