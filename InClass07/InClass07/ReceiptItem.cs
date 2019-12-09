using System;
using System.Collections.Generic;
using System.Text;

namespace InClass07
{
    class ReceiptItem
    {
        public string description;
        public double amount;
        public int quantity;

        public ReceiptItem(string description, double amount, int quantity)
        {
            this.description = description;
            this.amount = amount;
            this.quantity = quantity;
        }

        public void Print()
        {
            Console.Write($"{this.quantity + "x", 3}");
            Console.Write($"{this.description + "   ", 15}");
            Console.Write($"{"@$" + this.amount, 5}");
            Console.Write($"{"$" + (this.amount*this.quantity), 5}");
        }
    }
}
