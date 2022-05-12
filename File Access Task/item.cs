using System;
using System.Collections.Generic;

namespace File_Access_Task
{
    public class Item
    {
        public string title { get; set; }
        public int quantity { get; set; }
        public int unitPrice { get; set; }

            public Item(string pTitle, int Pquantity, int punitPrice){
                title =pTitle;
                quantity =Pquantity;
                unitPrice=punitPrice;
            }
            
    }
}
