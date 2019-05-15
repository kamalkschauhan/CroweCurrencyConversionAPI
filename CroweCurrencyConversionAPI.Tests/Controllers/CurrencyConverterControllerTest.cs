using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweCurrencyConversionAPI.Controllers;
using System.Net.Http;
using System.Web.Http;
using CroweCurrencyConversionAPI.Models;

namespace CroweCurrencyConversionAPI.Tests.Controllers
{
    [TestClass]
    public class CurrencyConverterControllerTest
    {
        [TestMethod]
        public void UserYahooServiceProvider()
        {
            // Arrange
            CurrencyConverterController controller = new CurrencyConverterController();

            controller.Request = new HttpRequestMessage();
            //controller.Request.Headers.Add("Authorize", "Bearer E44jlg9gAp6QDTe26Ew5ar5mFAYSnO4eEMpXfGojQyopNAlx1zH2B4Jf5yDWO4XubSxu3Et4ujPSy6aGz11s4x37jM2qdxqSpBL7DJmPVayI9oX-l163SY1r4R-joQZxomEae3Zlk9fDGK5XXFMyL8vTPusyz-9RcuePuuPhtVhjA71FgeF1jWbuLDCa8e1VOklxURkxtOOXUXEXgbZyU-zcR-hfKfBdCcSm7vsjShryedPZYS4xZJ8_1m-KKh4YsPe44EDZeHB0-zvulY8mZbe-iwMhaV87lzRyBxzQgr1rC8iGP2h0qMApzZ04JtXYULqMqkfoaa3jecN8SCaNTQs3Y3J7mzKWvxG-wDX5uthhfc6GAjW1n3mEyZbRKmUFJkexO8yF-uiBk-zkJupPlGZdYjeXjnSPEIcbaCcrz-ua7O6mLKU_LAZ2tZpZAYcadBhF-gXgfMt51rJzxUBxaraskBrxkjMr9nBreiMdzHM3cdoP2c7KFfYQoUvQIyOO0");
            controller.Configuration = new HttpConfiguration();
            CroweCurrencyResponse response = controller.GetCurrencyConversionfromProvider("Yahoo", "USD", "INR", 1);
            Assert.IsNotNull(response);

        }
    }
}
