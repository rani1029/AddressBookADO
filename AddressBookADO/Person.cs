﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookADO
{
    public class Person
    {
        public string AddressBookName { get; set; }
        public string Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
    }
}
