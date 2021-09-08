using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AddressBookADO
{
    class DatabaseManager
    {
        public void CreateDatabase()
        {
            //Sql Connection
            SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDb)\localdb;Initial Catalog=AddressBookService;Integrated Security=True");

            //Sql Query to Create Databse
            String str = "CREATE DATABASE AddressBook ";

            SqlCommand Command = new SqlCommand(str, Connect);
            try
            {
                Connect.Open();
                Command.ExecuteNonQuery();
                Console.WriteLine("DataBase is Created Successfully");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (Connect.State == ConnectionState.Open)
                {
                    Connect.Close();
                }
            }
        }
    }
}