using System;

namespace CroweCurrencyConversionAPI.Models
{
    public interface ICurrencyConverter
    {
        double GetCurrencyRate(String fromCurrency, String toCurrency, Double amount);
    }
}
