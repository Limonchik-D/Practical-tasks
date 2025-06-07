using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Converter
    {
        private double usdRate; // курс USD к BYN
        private double eurRate; // курс EUR к BYN
        private double rubRate; // курс RUB к BYN

        public Converter(double usd, double eur, double rub) //Конструктор
        {
            usdRate = usd;
            eurRate = eur;
            rubRate = rub;
        }
        public double FromBYN(double amountBYN, string currency) // Конвертация из BYN в другую валюту
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return amountBYN / usdRate;
                case "EUR":
                    return amountBYN / eurRate;
                case "RUB":
                    return amountBYN / rubRate;
                default:
                    throw new ArgumentException("Неизвестная валюта");
            }
        }
        public double ToBYN(double amountCurrency, string currency) // Конвертация из другой валюты в BYN
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return amountCurrency * usdRate;
                case "EUR":
                    return amountCurrency * eurRate;
                case "RUB":
                    return amountCurrency * rubRate;
                default:
                    throw new ArgumentException("Неизвестная валюта");
            }
        }
    }
}
