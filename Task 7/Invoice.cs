using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Invoice
    {
        public int Account { get; }      // (Счет) Инициализируется в конструкторе, не изменяется
        public string Customer { get; } //Покупатель
        public string Provider { get; } //Поставщик

        private string article;       // Товар
        private int quantity;      // Количество
        private double pricePerUnit; // Цена за единицу

        public Invoice(int account, string customer, string provider, string article, int quantity, double pricePerUnit) 
        {
            Account = account;
            Customer = customer;
            Provider = provider;
            this.article = article;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
        }

        // Стоимость без НДС
        public double CalculatePriceWithoutVAT()
        {
            return quantity * pricePerUnit;
        }

        // Стоимость с НДС (например 20%)
        public double CalculatePriceWithVAT()
        {
            return CalculatePriceWithoutVAT() * 1.20;
        }

        public void ShowInvoice(bool includeVAT)
        {
            Console.WriteLine($"Счёт: {Account}");
            Console.WriteLine($"Покупатель: {Customer}");
            Console.WriteLine($"Поставщик: {Provider}");
            Console.WriteLine($"Товар: {article}");
            Console.WriteLine($"Количество: {quantity}");
            Console.WriteLine($"Цена за единицу: {pricePerUnit:F2} BYN");

            if (includeVAT)
            {
                Console.WriteLine($"Итого с НДС: {CalculatePriceWithVAT():F2} BYN");
            }
            else
            {
                Console.WriteLine($"Итого без НДС: {CalculatePriceWithoutVAT():F2} BYN");
            }
        }
    }
}
