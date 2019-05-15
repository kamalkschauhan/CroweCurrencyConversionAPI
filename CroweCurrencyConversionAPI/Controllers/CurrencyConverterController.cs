using System.Net;
using System.Net.Http;
using System.Web.Http;
using CroweCurrencyConversionAPI.Models;
using CroweCurrencyConversionAPI.Filters;

namespace CroweCurrencyConversionAPI.Controllers
{
    [NotImplExceptionFilter]
    [Authorize]
    public class CurrencyConverterController : ApiController
    {
        // GET api/values/5
        [Authorize]
        public CroweCurrencyResponse GetCurrencyConversionfromProvider(string provider, string FromCurrency, string toCurrency, double amount)
        {
            double result = default(double);

            ICroweServiceProvider serviceProvider = new ServiceProvider();
            ICurrencyConverter converter = serviceProvider.GetServiceProvider(provider);

            if (converter != null)
            {
                result = converter.GetCurrencyRate(FromCurrency, toCurrency, amount);
                return new CroweCurrencyResponse { ProviderName = provider, FromCurrency = FromCurrency, ToCurrency = toCurrency, Amount = amount, ConvertedAmount = result };
            }
            else
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(provider + " provider is not active"),
                    ReasonPhrase = provider + " provider is not active"
                };

                throw new HttpResponseException(resp);
            }

        }

    }
}