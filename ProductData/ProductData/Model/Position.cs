namespace ProductData.Model
{
    /// <summary>
    /// Represents amount of certain financial product that was present in client's portfolio at certain date
    /// </summary>
    public class Position
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string ProductKey { get; set; }
    }

    public class ProductResult
    {
        public string ProductKey { get; set; }
        public decimal Value { get; set; }
        public decimal MarketValue { get; set; }
    }
}
