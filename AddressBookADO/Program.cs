using System;

namespace AddressBookADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to addressbook with Ado.net");
            DatabaseManager manager = new DatabaseManager();

            //UC1
            manager.CreateDatabase();
        }
    }



}





