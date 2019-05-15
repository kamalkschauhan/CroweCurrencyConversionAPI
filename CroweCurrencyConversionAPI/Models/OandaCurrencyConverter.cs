using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace CroweCurrencyConversionAPI.Models
{
    public class OandaServiceProvider : ICurrencyConverter
    {

        private const string OANDA_KEY = "OandaKey";
        public Double GetCurrencyRate(String fromCurrency, String toCurrency, Double amount)
        {
            Double value = default(Double);

            throw new NotImplementedException("This method is not implemented");

            #region Not Working Code
            /*try
            {
                var url = "https://www.oanda.com/rates/api/v1/currencies.json";
                var request = (HttpWebRequest)WebRequest.Create(url);

                string json = "";
                string credentialHeader = String.Format("Bearer " + ConfigurationManager.AppSettings[OANDA_KEY].ToString());
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", credentialHeader);

                HttpWebResponse webresponse = (HttpWebResponse)request.GetResponse();

                var sw = new StreamReader(webresponse.GetResponseStream(), System.Text.Encoding.ASCII);
                json = sw.ReadToEnd();
                sw.Close();

                var response = (new JavaScriptSerializer()).Deserialize<Dictionary<string, List<object>>>(json);

                foreach (Dictionary<string, object> currency in response["currencies"])
                {
                    Console.WriteLine("{0} : {1}", currency["code"], currency["description"]);
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
            */
            #endregion

            return value;

        }
    }
}