using CurrencyConverter.ExchangeRate;
using CurrencyConverter.Schedule;
using System;
using System.Configuration;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter currency:");
            string inputCurrency1 = Console.ReadLine();

            Console.Write("Enter amount:");
            decimal amount1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter currency:");
            string inputCurrency2 = Console.ReadLine();

            Console.Write("Enter date(YYYY-MM-DD): ");
            string dateStr = Console.ReadLine();            

            DateTime convertedDate;
            bool isDateType = DateTime.TryParse(dateStr, out convertedDate);

            string apiUrl = "";
            if (isDateType)
            {
                apiUrl = ConfigurationManager.AppSettings.Get("apiUrl") + dateStr + "?" + ConfigurationManager.AppSettings.Get("access_key");
            }
            else
            {
                apiUrl = ConfigurationManager.AppSettings.Get("apiUrl") + "latest?" + ConfigurationManager.AppSettings.Get("access_key");
            }

            ExchangeRates ex = new ExchangeRates();
            var c1 = ex.GetExchangeRate(apiUrl, inputCurrency1);
            var c2 = ex.GetExchangeRate(apiUrl, inputCurrency2);

            if (c1.currency == null || c2.currency == null)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            Console.WriteLine("\n--------- Exchange rates ----------");
            Console.WriteLine($"{apiUrl} \n");
            decimal c1_rate = c1.rates / c1.rates;
            decimal c2_rate = c2.rates / c1.rates;
            Console.WriteLine($"{c1.currency}: {c1.rates / c1.rates} =  {c2.currency}: {c2.rates / c1.rates}");
            decimal currency1_amount = amount1 * c1_rate;
            decimal currency2_amount = amount1 * c2_rate;
            Console.WriteLine($"{c1.currency}: {currency1_amount}  = {c2.currency}: {currency2_amount}");            
        }
    }
}
