using ProductData.Model;

namespace ProductData.Utility
{
    public class Products
    {
        public static void GetProductDetails()
        {
            Price[] prices = GetPrices();
            Position[] positions = GetPosition();

            if(prices != null && positions != null && prices.Count() > 0 && positions.Count() > 0)
            {
                List<ProductResult> products = new List<ProductResult>();
                Console.WriteLine("Product Data as below...");

                products.AddRange(from pric in prices
                                  join pos in positions on pric.ProductKey equals pos.ProductKey
                                  orderby pric.ProductKey
                                  select new ProductResult()
                                  {
                                      ProductKey = pric.ProductKey,
                                      Value = pric.Value,
                                      MarketValue = pric.Value * pos.Amount
                                  });
               
                if (products.Count > 0)
                    products.ForEach(products => Console.WriteLine("Product Key:" + products.ProductKey + ", Price:" + products.Value + ", Market Value:" + products.MarketValue));
            }
        }
        private static Price[] GetPrices()
        {
            return [
                new Price() { Date = new DateTime(2007, 11, 05), ProductKey ="A", Value = 20},
                new Price() { Date = new DateTime(2021,03,08), ProductKey ="D", Value = 25},
                new Price() { Date = new DateTime(2019,11,19), ProductKey ="B", Value = 30},
                new Price() { Date = new DateTime(2017,04,12), ProductKey ="C", Value = 67},
                new Price() { Date = new DateTime(2022,02,24), ProductKey ="E", Value = 10},
                new Price() { Date = new DateTime(2023,08,26), ProductKey ="K", Value = 50},
                new Price() { Date = new DateTime(2023,09,05), ProductKey ="N", Value = 60}];
        }
        private static Position[] GetPosition()
        {
            return [
                new Position() { Date = new DateTime(2007, 11, 05), ProductKey ="A", Amount = 10},
                new Position() { Date = new DateTime(2021, 03, 08), ProductKey ="D", Amount = 10},
                new Position() { Date = new DateTime(2019, 11, 19), ProductKey ="B", Amount = 25},
                new Position() { Date = new DateTime(2017, 04, 12), ProductKey ="C", Amount = 30},
                new Position() { Date = new DateTime(2022, 02, 24), ProductKey ="E", Amount = 80}];
        }

    }
}
