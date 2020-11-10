using System;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Linq");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
          // addressBookDataTable.GetAllContacts();
            //addressBookDataTable.DeleteContact("Ruthik", "Reddy");
            //addressBookDataTable.GetAllContacts();
            addressBookDataTable.RetrieveByCityOrState("Mirzapur", "Chennnai");
        }
    }
}
