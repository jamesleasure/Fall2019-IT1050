using System;
using System.Collections.Generic;

namespace InClass07
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipt receipt1 = new Receipt();
            receipt1.AddItem("Classic Italian Sub", 2.49, 1);
            receipt1.AddItem("Side of Fruit", 1.25, 2);
            receipt1.PrintReceipt();
        }
    }
}
