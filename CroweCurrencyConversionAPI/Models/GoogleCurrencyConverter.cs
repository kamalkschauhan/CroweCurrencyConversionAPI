using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;

namespace CroweCurrencyConversionAPI.Models
{
    public class GoogleServiceProvider : ICurrencyConverter
    {
        public Double GetCurrencyRate(String fromCurrency, String toCurrency, Double amount)
        {
            Double value = default(Double);

            throw new NotImplementedException("Google Provider is not implemented");

            #region Not Working Code
            /*WebClient web = new WebClient();

            try
            {
                string url = string.Format("http://www.google.co.in/ig/calculator?hl=en&q={2}{0}%3D%3F{1}", fromCurrency.ToUpper(), toCurrency.ToUpper(), amount);
                string response = web.DownloadString(url);
                Regex regex = new Regex(@":(?<rhs>.+?),");
                string[] arrDigits = regex.Split(response);
                string rate = arrDigits[3];
                value = Convert.ToDouble(rate);
            }
            catch(Exception ex)
            {

                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(ex.Message),
                    ReasonPhrase = ex.Message
                };

                throw new HttpResponseException(resp);

            } */
            #endregion

            return value;
        }
    }
}