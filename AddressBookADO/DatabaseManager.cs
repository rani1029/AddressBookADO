using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AddressBookADO
{
    public class DatabaseManager
    {
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDb)\localdb;Initial Catalog=AddressBookService;Integrated Security=True");
        public void CreateDatabase()
        {
            //Sql Connection
            SqlConnection Connect1 = new SqlConnection(@"Data Source=(LocalDb)\localdb;Integrated Security=True");

            //Sql Query to Create Databse
            String str = "CREATE DATABASE AddressBook ";

            SqlCommand Command = new SqlCommand(str, Connect);
            try
            {
                Connect1.Open();
                Command.ExecuteNonQuery();
                Console.WriteLine("DataBase is Created Successfully");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (Connect1.State == ConnectionState.Open)
                {
                    Connect1.Close();
                }
            }


        }
        public bool AddEmployee(Person person)
        {
            try
            {
                using (this.Connect)
                {
                    SqlCommand command = new SqlCommand("sp_AddPersonDetails", this.Connect);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AddressBookName", person.AddressBookName);
                    command.Parameters.AddWithValue("@Type", person.Type);
                    command.Parameters.AddWithValue("@FirstName", person.FirstName);
                    command.Parameters.AddWithValue("@LastName", person.LastName);
                    command.Parameters.AddWithValue("@Address", person.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", person.PhoneNumber);
                    command.Parameters.AddWithValue("@zipcode", person.ZipCode);
                    command.Parameters.AddWithValue("@City", person.City);
                    command.Parameters.AddWithValue("@State", person.State);
                    command.Parameters.AddWithValue("@EmailId", person.EmailId);


                    this.Connect.Open();
                    var result = command.ExecuteNonQuery();
                    this.Connect.Close();
                    if (result != 0)
                        return true;

                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.Connect.Close();
            }
            return false;
        }
        public bool UpdatePerson(Person person)
        {
            try
            {
                using (this.myConn)
                {
                    SqlCommand command = new SqlCommand("sp_updatePersonDetails", this.myConn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AddressBookName", person.AddressBookName);
                    command.Parameters.AddWithValue("@Address", person.Address);

                    this.myConn.Open();
                    var result = command.ExecuteNonQuery();
                    this.myConn.Close();
                    if (result != 0)
                        return true;

                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.myConn.Close();
            }
            return false;
        }
        public bool UpdatePerson(Person person)
        {
            try
            {
                using (this.myConn)
                {
                    SqlCommand command = new SqlCommand("sp_updatePersonDetails", this.myConn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AddressBookName", person.AddressBookName);
                    command.Parameters.AddWithValue("@Address", person.Address);

                    this.myConn.Open();
                    var result = command.ExecuteNonQuery();
                    this.myConn.Close();
                    if (result != 0)
                        return true;

                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.myConn.Close();
            }
            return false;
        }
        public bool DeletePerson(Person person)
        {
            try
            {
                using (this.myConn)
                {
                    SqlCommand command = new SqlCommand("sp_deletePersonDetails", this.myConn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", person.FirstName);

                    this.myConn.Open();
                    var result = command.ExecuteNonQuery();
                    this.myConn.Close();
                    if (result != 0)
                        return true;

                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.myConn.Close();
            }
            return false;
        }
        public bool RetrievePersonByCityOrState(Person person)
        {
            try
            {
                using (this.myConn)
                {
                    SqlCommand command = new SqlCommand("sp_RetrievePerson", this.myConn);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@City", person.City);
                    command.Parameters.AddWithValue("@State", person.State);

                    this.myConn.Open();
                    var result = command.ExecuteNonQuery();
                    this.myConn.Close();
                    if (result != 0)
                        return true;

                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.myConn.Close();
            }
            return false;
        }
    }
}




