namespace SalaryConverter.API.Models
{
    public class SettingsAPI
    {
        public string BaseUrl { get; set; }
        public string RatesUrl { get; set; }
        public string NationalRatesUrl { get; set; }
        public int UsdCurrencyCode { get; set; }
    }
}
