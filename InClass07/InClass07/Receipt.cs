using System;
using System.Collections.Generic;
using System.Text;

namespace InClass07
{
    class Receipt
    {
        public string storeName;
        public string address;
        public string phone;
        public string transactionId;
        public List<ReceiptItem> receiptItems;
        public string footer;

        public Receipt()
        {
            storeName = "Aldi's";
            address = "6849 SL Dr.\nParma, OH 44130";
            phone = "440-888-8872";
            //itemDescription = new List<string>();
            //itemAmount = new List<double>();
            //itemQuantity = new List<int>();
            //this.receiptItem = new ReceiptItem("Sandwich", 2.5, 2);
            receiptItems = new List<ReceiptItem>();
            footer = "Have a nice day!";
            transactionId = Guid.NewGuid().ToString("N");
        }

        public void AddItem(string desc, double amt, int quantity)
        {
            /*
             * this.itemDescription.Add(desc);
            this.itemAmount.Add(amt);
            this.itemQuantity.Add(quantity);
            */
            ReceiptItem newReceiptItem = new ReceiptItem(desc, amt, quantity);
            this.receiptItems.Add(newReceiptItem);
        }

        public int ItemCount()
        {
            //return this.itemDescription.Count;
            return 1;
        }

        public void PrintReceipt()
        {
            Console.WriteLine(this.storeName);
            Console.WriteLine(this.address);
            Console.WriteLine(this.phone);
            Console.WriteLine();
            Console.WriteLine($"Trans. Id:\n{this.transactionId}");
            Console.WriteLine();

            // TODO: Print items and totals
            /*
            for (int i = 0; i < this.ItemCount(); i++)
            {
                Console.Write("{0,2}x", this.itemQuantity[i]);
                Console.Write("{0,10}", this.itemDescription[i]);
                Console.Write(" @{0,5}", this.itemAmount[i]);
                Console.Write(" {0,5}", (this.itemAmount[i] * this.itemQuantity[i]));
                Console.WriteLine();

            }
            */
            foreach(ReceiptItem item in this.receiptItems)
            {
                item.Print();
            }

            Console.WriteLine();
            Console.WriteLine(this.footer);
        }
    }
}