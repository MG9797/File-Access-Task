using System;
using System.Collections.Generic;
using System.IO;

namespace File_Access_Task
{
    class Program
    {

        public static List<Item> p = new List<Item>();

        static void Main(string[] args)
        {

            while (true){
                string[] menu = new string[6];
                menu[0] = "1. Add New Item";
                menu[1] = "2. List All Items";
                menu[2] = "3. Show Total Cost";
                menu[3] = "4. Clear List";
                menu[4] = "5. Save List";
                menu[5] = "6. Exit";
                Console.WriteLine("Please make a selection");
                Console.WriteLine(menu[0]);
                Console.WriteLine(menu[1]);
                Console.WriteLine(menu[2]);
                Console.WriteLine(menu[3]);
                Console.WriteLine(menu[4]);
                Console.WriteLine(menu[5]);

                string selection = Console.ReadLine();

                if (selection == "1"){
                    AddItem();
                }
                if (selection == "2"){
                    ListAllItems();
                }
                if (selection == "3"){
                    ShowTotalCost();
                }
                if (selection == "4"){
                    ClearList();
                }
                if (selection == "5"){
                    SaveList();
                }
                if (selection == "6"){
                    Exit();
                    break;
                }
            }

        }

        static void AddItem(){
            Console.WriteLine("Please enter a title");
            string title = Console.ReadLine();

            Console.WriteLine("Please enter a quantity");
            int qty = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a unitprice");
            int price = int.Parse(Console.ReadLine());

           p.Add(new Item(title, qty, price));
            

        }
        static public void ListAllItems(){

            foreach(Item i in p){
                Console.WriteLine(i.title + " " + i.quantity.ToString() + " " + i.unitPrice.ToString());
            }
        }
        static void ShowTotalCost(){
            Console.WriteLine("Your Total is " + p);
           /* foreach(Item i in p)
            {
                Console.WriteLine(i);
            } */
            
        }
        static void ClearList(){
           p.Clear();
           Console.WriteLine("Resets the shopping list to an empty list");

        }
        
         static public void SaveList()
        {

            using (StreamWriter writer = new StreamWriter("./data.csv"))
            {
                foreach(Item i in p)
                {
                    writer.WriteLine(i.title+ "," + i.quantity.ToString() + "," + i.unitPrice.ToString());
                }
            }
        } 

 
          static public void Exit(){
             Console.WriteLine("Thanks for using the Shopping List App");
         } 
        
    }
}
