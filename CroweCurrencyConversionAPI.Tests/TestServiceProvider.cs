using CroweCurrencyConversionAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class TestServiceProvider
    {

        ICroweServiceProvider provider = new ServiceProvider();

        [TestMethod]
        public void Get_Yahoo_Service_Provider()
        {
            ICurrencyConverter converter = provider.GetServiceProvider("Yahoo");
            Assert.IsNotNull(converter);
        }

        [TestMethod]
        public void Get_Conversion_Value_from_Yahoo_Service_Provider()
        {

            ICurrencyConverter converter = provider.GetServiceProvider("Yahoo");
            double result = converter.GetCurrencyRate("USD", "INR", 2);
            Assert.AreNotEqual(0.0, result);
        }

        [TestMethod]
        public void Get_Google_Service_Provider()
        {
            ICurrencyConverter converter = provider.GetServiceProvider("GoOgle");
            Assert.IsNull(converter);
        }

        [TestMethod]
        public void Get_Conversion_Value_From_Google_Service_Provider()
        {
            ICurrencyConverter converter = provider.GetServiceProvider("GoOgle");
            // Could not implemented beacause google api issue 
        }

        [TestMethod]
        public void Get_XE_Service_Provider()
        {
            ICurrencyConverter converter = provider.GetServiceProvider("XE");
            Assert.IsNull(converter);
        }

        [TestMethod]
        public void Get_Conversion_Value_From_XE_Service_Provider()
        {
            ICurrencyConverter converter = provider.GetServiceProvider("XE");
            //Could not implemented because of XE APi issue
        }

        [TestMethod]
        public void Get_Oanda_Service_Provider()
        {
            ICurrencyConverter converter = provider.GetServiceProvider("Oanda");
            Assert.IsNull(converter);
        }

        [TestMethod]
        public void Get_Conversion_Value_From_Oanda_Service_Provider()
        {
            ICurrencyConverter converter = provider.GetServiceProvider("Oanda");
            //Could not implemetd because of oanda api token issue
        }

       
    }
}
