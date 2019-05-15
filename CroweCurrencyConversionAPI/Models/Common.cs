using System;

namespace CroweCurrencyConversionAPI.Models
{
    public enum ServiceProviderEnum
    {
        XE, GOOGLE, YAHOO, OANDA
    }

    public static class EnumUtility
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }

}