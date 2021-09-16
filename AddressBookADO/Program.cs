using System;

namespace AddressBookADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to addressbook with Ado.net");


            //UC1


            Person person = new Person();
            person.FirstName = "Rohit";
            person.LastName = "kumar";
            person.Address = "cp rd";
            person.PhoneNumber = "7697654390";
            person.ZipCode = 678787;
            person.City = "kolkata";
            person.State = "wb";
            person.EmailId = "example@gmail.com";
            person.AddressBookName = "rk";
            person.Type = "Family";
            OperationManager manager = new OperationManager();

            bool result = manager.AddContact(person);
            if (result)
            {
                Console.WriteLine("contact added");
            }
            else
                Console.WriteLine("error ");


        }
    }



}





