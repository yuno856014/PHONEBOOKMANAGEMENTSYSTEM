using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class PhoneBook : IPhoneBook
    { 
        public string name { get; set; }
        public string phone { get; set; }
        SortedList<string,string> sortPhone = new SortedList<string,string>();
        public void InsertPhone(string name , string phone)
        {
            string checkName = null;
            if (sortPhone.ContainsKey(name))
            {
                checkName = sortPhone[name];
                sortPhone.Remove(name);
                sortPhone.Add(name, checkName + ":" + phone);
            }
            else sortPhone.Add(name, phone);
        }
        public void Show()
        {
            foreach (KeyValuePair<string, string> phonebook in sortPhone)
            {
                Console.Write($"Name : {phonebook.Key} Phone : {phonebook.Value}\n");
            }
        }
        public void RemovePhone(string name)
        {
            sortPhone.Remove(name);
        }
        public void UpdatePhone(string name, string newphone)
        {
            if (sortPhone.ContainsKey(name))
            {
                sortPhone.Remove(name);
                sortPhone.Add(name, newphone);
            }
            else Console.WriteLine("Does not exist");
        }
        public void SearchPhone(string name)
        {
            if (sortPhone.ContainsKey(name))
            {
                Console.WriteLine($"Name : {name} Phone : {sortPhone[name]}");
            }
            else Console.WriteLine("K co");
        }
        public void  Sort()
        {
            
        }
    }
}
