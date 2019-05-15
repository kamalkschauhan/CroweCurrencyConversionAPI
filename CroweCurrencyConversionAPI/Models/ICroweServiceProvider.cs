using System;
namespace CroweCurrencyConversionAPI.Models
{
    public interface ICroweServiceProvider
    {
        ICurrencyConverter GetServiceProvider(string serviceProviderName);
    }
}
