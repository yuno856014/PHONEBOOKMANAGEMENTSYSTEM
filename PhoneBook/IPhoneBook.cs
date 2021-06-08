using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    interface IPhoneBook
    {
        void InsertPhone(string name, string phone);
        void RemovePhone(string name);
        void UpdatePhone(string name, string newphone);
        void SearchPhone(string name);
        void Sort();
    }
}
