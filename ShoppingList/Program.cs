using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {

 
        public class Item
        {
        string name;
        string price;

            public Item(string _name, string _price)
            {
                name = _name;
                price = _price;
            }
        }

        static void Main(string[] args)
        {
            WriteShopingList();
        }

        public static void WriteShopingList()
        {
            List<string> shoppingList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Item:");
                string item = Console.ReadLine();
                Console.WriteLine("Enter price:");
                string price = Console.ReadLine();
                string line = $"{item}/{price}";
                shoppingList.Add(line);


            }string filePath = @"C:\Users\opilane\samples";
            string fileName = @"ShoppingList.txt";
        }
        
            
    }
}
