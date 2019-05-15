using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace CroweCurrencyConversionAPI.Models
{
    public class CommonValidation
    {
        public const int ACTIVE = 1;
        public const string IS_ACTIVE = "isActive";

        XmlDataDocument xmldoc = new XmlDataDocument();

        public CommonValidation()
        {
            string fileName = string.Empty;

            try
            {

                if (HttpContext.Current != null)
                {
                    // for Web API 
                    fileName = HttpContext.Current.Server.MapPath("~/App_Data/ServiceProviders.xml");
                }
                else
                {
                    // for unit testing 
                    fileName = @"ServiceProviders.xml";
                }

                xmldoc.Load(fileName);
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

        }

        public bool IsServiceProviderActive(string providerName)
        {
            bool result = false;

            string xpath = "//Provider[@Name='" + providerName + "']";

            XmlNode provider = xmldoc.SelectSingleNode(xpath);

            if (provider != null)
            {
                if (provider.Attributes[IS_ACTIVE] != null && provider.Attributes[IS_ACTIVE].Value == ACTIVE.ToString())
                {
                    result = true;
                }
            }

            return result;
        }

        public bool IsCurrencyCodeValid(string providerName, string currencyCode)
        {

            bool result = false;

            string xpath = "//Provider[@Name='" + providerName + "']/CurrencyCode[text()='" + currencyCode + "']";

            XmlNode provider = xmldoc.SelectSingleNode(xpath);

            if (provider != null)
            {
                result = true;
            }

            return result;
        }

    }

}