using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OTOTO.DataAccess.CustomerEntityBase;

namespace OTOTO.DataAccess
{
    public class CustomerDAO
    {
        public static List<CustomerEntity> GetAllCustomers()
        {
            List<CustomerEntity> list = null;
            SqlCommand com = new SqlCommand("spSelectCustomer", Connection.Con);

            if (com.Connection.State == ConnectionState.Closed)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                list = new List<CustomerEntity>();
                while (rd.Read())
                {
                    list.Add(new CustomerEntity
                    {
                        Name = rd["c_name"].ToString(),
                        SurName = rd["c_lname"].ToString(),
                        Phone = rd["c_phone"].ToString(),
                        Mail = rd["c_mail"].ToString(),
                        SSN = rd["c_ssn"].ToString(),
                    });
                }
            }
            com.Dispose();
            com.Connection.Close();
            return list;
        }

        public static CustomerEntity SelectCustomerById(int id)
        {
            SqlCommand com = new SqlCommand("sp_GetCustomerByID @ID", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);

            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {

                rd.Read();

                return new CustomerEntity
                {
                    Name = rd["e_name"].ToString(),
                    SurName = rd["e_lname"].ToString(),
                    Phone = rd["e_phone"].ToString(),
                    Mail = rd["e_mail"].ToString(),
                    SSN = rd["e_ssn"].ToString()
                };

            }
            com.Dispose();
            com.Connection.Close();

            return null;
        }


        public static CustomerEntity InsertCustomer(string Name, string SurName, string Phone, string Mail,string SSN)
        {
            SqlCommand com = new SqlCommand("SP_InsertCustomer @NAME ,@SURNAME ,@PHONE ,@MAIL ,@SSN ", Connection.Con);
            com.Parameters.AddWithValue("@NAME", Name);
            com.Parameters.AddWithValue("@SURNAME", SurName);
            com.Parameters.AddWithValue("@PHONE", Phone);
            com.Parameters.AddWithValue("@MAIL", Mail);
            com.Parameters.AddWithValue("@SSN", SSN);

            com.Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();



            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();


            com.Dispose();
            com.Connection.Close();

            return null;
        }

        public static CustomerEntity UpdateCustomer(int id, string Name, string SurName,string Phone, string Mail, string SSN)
        {


            SqlCommand com = new SqlCommand("SP_UpdateCustomer @ID ,@NAME ,@SURNAME ,@PHONE ,@MAIL ,@SSN", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);
            com.Parameters.AddWithValue("@NAME", Name);
            com.Parameters.AddWithValue("@SURNAME", SurName);
            com.Parameters.AddWithValue("@PHONE", Phone);
            com.Parameters.AddWithValue("@MAIL", Mail);
            com.Parameters.AddWithValue("@SSN", SSN);

            com.Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();

            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();

            com.Dispose();
            com.Connection.Close();

            return null;
        }

        public static CustomerEntity DeleteCustomer(int id)
        {


            SqlCommand com = new SqlCommand("SP_DeleteCustomer @ID", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);

            com.Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();

            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            adapter.InsertCommand = com;
            adapter.InsertCommand.ExecuteNonQuery();

            com.Dispose();
            com.Connection.Close();

            return null;
        }


    }
}
