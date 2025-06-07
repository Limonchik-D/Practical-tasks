using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(2.5, 3.0, 0.035); // Пример курса: 1 USD = 2.5 BYN, 1 EUR = 3 BYN, 1 RUB = 0.035 BYN

            Console.Write("Введите сумму в BYN для конвертации: ");
            double amountBYN = double.Parse(Console.ReadLine());

            Console.Write("Введите валюту для конвертации из BYN (USD, EUR, RUB): ");
            string currency = Console.ReadLine();

            double converted = converter.FromBYN(amountBYN, currency);
            Console.WriteLine($"{amountBYN} BYN = {converted:F2} {currency.ToUpper()}");

            Console.Write("\nВведите сумму в валюте для конвертации в BYN: ");
            double amountCurrency = double.Parse(Console.ReadLine());

            Console.Write("Введите валюту (USD, EUR, RUB): ");
            string currency2 = Console.ReadLine();

            double convertedToBYN = converter.ToBYN(amountCurrency, currency2);
            Console.WriteLine($"{amountCurrency} {currency2.ToUpper()} = {convertedToBYN:F2} BYN");

            Console.ReadKey();
        }
    }
}
