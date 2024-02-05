namespace ProductData.Model
{
    /// <summary>
    /// Market price of certain financial product at certain date
    /// </summary>
    public class Price
    {
        public DateTime Date { get; set; }
        public string ProductKey { get; set; }
        public decimal Value { get; set; }
    }
}
