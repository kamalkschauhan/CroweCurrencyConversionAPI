using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CroweCurrencyConversionAPI.Models
{
    public class XEServiceProvider : ICurrencyConverter
    {
        public Double GetCurrencyRate(String fromCurrency, String toCurrency, Double amount)
        {

            Double value = default(Double);
            throw new NotImplementedException("This method is not implemented");
            #region Not Working Code
           /* try
            {


                string request = String.Format("http://www.xe.com/ucc/convert.cgi?Amount={0}&From={1}&To={2}", amount, fromCurrency, toCurrency);

                WebClient webClient = new WebClient();

                string response = webClient.DownloadString(request);

                webClient.Dispose();

                string header = String.Format("XE.com: {0} to {1} rate:", fromCurrency, toCurrency);
                response = response.Replace(header, "");
                string outValue = response.Split('=')[1];
                outValue = outValue.Replace(toCurrency, "");
                value = Double.Parse(outValue, System.Globalization.CultureInfo.InvariantCulture);
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
            */
            #endregion
            return value;

        }
    }
}