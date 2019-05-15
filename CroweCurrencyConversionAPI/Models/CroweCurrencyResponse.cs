
namespace CroweCurrencyConversionAPI.Models
{
    public class CroweCurrencyResponse
    {
        public string ProviderName { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public double Amount { get; set; }
        public double ConvertedAmount { get; set; }

    }
}