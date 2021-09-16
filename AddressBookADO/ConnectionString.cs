using System;
using System.Collections.Generic;
using System.Text;


namespace AddressBookADO
{
    public class ConnectionString
    {

        private static string cName = @"Data Source=(LocalDb)\localdb; Initial Catalog=AddressBook;Integrated Security=true";

        public static string CName
        {
            get => cName;
        }
    }
}
