using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookADO
{
    public class OperationManager
    {

        private string connectionString = ConnectionString.CName;
        public bool AddContact(Person contact)
        {

            if (contact.PhoneNumber != null && contact.FirstName != null && contact.Address != null)
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    SqlCommand cmdn = new SqlCommand("spAddContact", con);
                    cmdn.CommandType = CommandType.StoredProcedure;
                    cmdn.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                    cmdn.Parameters.AddWithValue("@FirstName", contact.FirstName);
                    cmdn.Parameters.AddWithValue("@Address", contact.Address);
                    if (contact.LastName == null)
                    {
                        cmdn.Parameters.AddWithValue("@LastName", "");
                    }
                    if (contact.LastName != null)
                    {
                        cmdn.Parameters.AddWithValue("@LastName", contact.LastName);
                    }
                    if (contact.State == null)
                    {
                        cmdn.Parameters.AddWithValue("@State", "");
                    }
                    if (contact.State != null)
                    {
                        cmdn.Parameters.AddWithValue("@State", contact.State);
                    }
                    cmdn.Parameters.AddWithValue("@City", contact.City);
                    cmdn.Parameters.AddWithValue("@Zip", contact.ZipCode);
                    cmdn.Parameters.AddWithValue("@Email", contact.EmailId);
                    cmdn.Parameters.AddWithValue("@AddressBookName", contact.AddressBookName);
                    con.Open();
                    cmdn.ExecuteNonQuery();
                    con.Close();
                    return true;

                }


            }
            return false;

        }
    }
}
