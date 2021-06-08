using System;
using System.Collections.Generic;

namespace PhoneBook
{
    class Program
    {
        private static PhoneBook phoneBook = new PhoneBook();
        const int Insert = 1;
        const int Remove = 2;
        const int Update = 3;
        const int Search = 4;
        const int Sort = 5;
        const int Exit = 0;
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu() 
        { 
        int choice = 0;
            do
            {
                Console.WriteLine("|--------Menu--------|");
                Console.WriteLine("|1. Insert Phone     |");
                Console.WriteLine("|2. Remove Phone     |");
                Console.WriteLine("|3. Update Phone     |");
                Console.WriteLine("|4. Search Phone     |");
                Console.WriteLine("|5. Sort Phone       |");
                Console.WriteLine("|0. Exit             |");
                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = 1;
                }
                 Console.Clear();
                switch (choice)
                {
                    case Insert:
                        InsertP();
                        phoneBook.Show();
                        break;
                    case Remove:
                        RemoveP();
                        phoneBook.Show(); 
                        break;
                    case Update:
                        UpdateP();
                        phoneBook.Show();
                        break;
                    case Search:
                        SearchP();
                        break;
                    case Sort:
                        SortP();
                        break;
                    case Exit:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0) ;
        }
        public static void  InsertP()
        {
            Console.Write("Enter Name :");
            string name = Console.ReadLine();
            Console.Write("Enter Phone :");
            string phone = Console.ReadLine();
            phoneBook.InsertPhone(name, phone);
        }
        public static void RemoveP()
        {
            Console.Write("Enter Remove Name :");
            string name = Console.ReadLine();
            phoneBook.RemovePhone(name);
        }
        public static void UpdateP()
        {
            Console.Write("Enter NameUpdate :");
            string name = Console.ReadLine();
            Console.Write("Enter New PhoneNumber :");
            string newphone = Console.ReadLine();
            phoneBook.UpdatePhone(name, newphone);
        }
        public static void SearchP()
        {
            Console.Write("Enter Search Name :");
            string name = Console.ReadLine();
            phoneBook.SearchPhone(name);
        }    
        public static void SortP()
        {
            phoneBook.Show();
        }
    }
}
