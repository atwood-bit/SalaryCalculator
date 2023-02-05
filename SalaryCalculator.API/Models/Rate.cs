namespace SalaryConverter.API.Models
{
    public class Rate
    {
        public double SellRate { get; set; }
        public string SellIso { get; set; }
        public int SellCode { get; set; }
        public double BuyRate { get; set; }
        public string BuyIso { get; set; }
        public int BuyCode { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
