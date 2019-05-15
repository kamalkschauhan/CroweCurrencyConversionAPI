using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CroweCurrencyConversionAPI.Models
{
    public class ServiceProvider : ICroweServiceProvider
    {


        public ICurrencyConverter GetServiceProvider(string serviceProviderName)
        {

            ICurrencyConverter serviceProvider = null;

            try
            {

                ServiceProviderEnum provider = EnumUtility.ParseEnum<ServiceProviderEnum>(serviceProviderName.ToUpper());

                //If Enumeration parsing is not completed then throw the exception 
                // check the currency provider is active is   

                CommonValidation validation = new CommonValidation();

                // if service provider is active then create the object 
                if (validation.IsServiceProviderActive(serviceProviderName))
                {

                    switch (provider)
                    {
                        case ServiceProviderEnum.GOOGLE:

                            serviceProvider = new GoogleServiceProvider();
                            break;

                        case ServiceProviderEnum.OANDA:
                            serviceProvider = new OandaServiceProvider();
                            break;

                        case ServiceProviderEnum.XE:
                            serviceProvider = new XEServiceProvider();
                            break;

                        case ServiceProviderEnum.YAHOO:
                            serviceProvider = new YahooServiceProvider();
                            break;

                    }
                }

            }

            catch (Exception ex)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(serviceProviderName + "provider Not Found"),
                    ReasonPhrase = serviceProviderName + " Not Found"
                };

                throw new HttpResponseException(resp);

            }


            return serviceProvider;
        }
    }
}