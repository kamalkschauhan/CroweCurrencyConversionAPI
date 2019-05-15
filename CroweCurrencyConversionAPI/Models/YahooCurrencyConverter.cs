using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CroweCurrencyConversionAPI.Models
{
    public class YahooServiceProvider : ICurrencyConverter
    {

        private const string providerName = "Yahoo";

        public Double GetCurrencyRate(String fromCurrency, String toCurrency, Double amount)
        {
            Double value = default(Double);
            WebClient web = new WebClient();

            CommonValidation validation = new CommonValidation();
            try
            {
                if (validation.IsCurrencyCodeValid(providerName, fromCurrency) && validation.IsCurrencyCodeValid(providerName, toCurrency))
                {

                    const string urlPattern = "http://finance.yahoo.com/d/quotes.csv?s={0}{1}=X&f=l1";
                    string url = String.Format(urlPattern, fromCurrency, toCurrency);
                    // Get response as string
                    string response = new WebClient().DownloadString(url);
                    // Convert string to number
                    decimal exchangeRate = decimal.Parse(response, System.Globalization.CultureInfo.InvariantCulture);
                    value = Convert.ToDouble(exchangeRate) * amount;
                }
            }
            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(resp);
            }

            return value;
        }
    }
}