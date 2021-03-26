using CurrencyConverter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace CurrencyConverter.ExchangeRate
{
    public class ExchangeRates
    {
        public static HttpClient webClient = new HttpClient();
        public (string currency, decimal rates) GetExchangeRate(string apiUrl, string currency)
        {
            var webResponse = webClient.GetAsync(apiUrl).Result;
            var data = webResponse.Content.ReadAsAsync<Currency>().Result;

            var prop = data.Rates.GetType().GetProperties();
            bool exist = prop.ToList().Exists(x => x.Name == currency);
            decimal rate = 0;
            if (exist == false)
            {
                return (null, 0);
            }
            currency = prop.FirstOrDefault(x => x.Name == currency).Name;
            rate = Convert.ToDecimal(prop.FirstOrDefault(x => x.Name == currency).GetValue(data.Rates, null));
            return (currency, rate);
        }
    }
}
