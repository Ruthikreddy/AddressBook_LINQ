using System;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Linq");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            addressBookDataTable.GetAllContacts();
            addressBookDataTable.UpdateContact("Ruthik", "Reddy", "Address", "Sri Nagar");
            addressBookDataTable.GetAllContacts();
        }
    }
}
