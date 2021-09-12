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

            Person person = new Person();
            person.FirstName = "Rani";
            person.LastName = "Gupta";
            person.Address = "Mumbai";
            person.PhoneNumber = "997654390";
            person.ZipCode = 678743;
            person.City = "mum";
            person.State = "mh";
            person.EmailId = "rani@gmail.com";
            person.AddressBookName = "rg";
            person.Type = "Family";

            manager.AddEmployee(person);
        }
    }



}





