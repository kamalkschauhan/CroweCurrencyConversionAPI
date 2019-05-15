using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweCurrencyConversionAPI.Models;

namespace UnitTesting
{
    [TestClass]
    public class ValidationTesting
    {
        CommonValidation validation = new CommonValidation();
        [TestMethod]
        public void IS_Yahoo_Provider_Active()
        {
            bool result = validation.IsServiceProviderActive("Yahoo");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IS_XE_Provider_Active()
        {
            bool result = validation.IsServiceProviderActive("XE");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IS_Google_Provider_Active()
        {
            bool result = validation.IsServiceProviderActive("Google");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IS_Oanda_Provider_Active()
        {
            bool result = validation.IsServiceProviderActive("Oanda");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Is_INR_Currency_Availble()
        {
            bool result = validation.IsCurrencyCodeValid("Yahoo", "INR");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Is_XXX_Currency_Availble()
        {
            bool result = validation.IsCurrencyCodeValid("Yahoo", "XXX");
            Assert.AreEqual(false, result);
        }

    }
}
