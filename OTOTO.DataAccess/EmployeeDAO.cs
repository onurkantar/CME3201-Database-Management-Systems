using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OTOTO.DataAccess.EmployeeEntityBase;

namespace OTOTO.DataAccess
{
    public class EmployeeDAO
    {
        public static List<EmployeeEntity> GetAllEmployees()
        {
            List<EmployeeEntity> list = null;
            SqlCommand com = new SqlCommand("spSelectEmployee", Connection.Con);

            if (com.Connection.State == ConnectionState.Closed)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                list = new List<EmployeeEntity>();
                while (rd.Read())
                {
                    list.Add(new EmployeeEntity
                    {
                        id = Convert.ToInt16(rd["e_id"]),
                        Name = rd["e_name"].ToString(),
                        SurName = rd["e_lname"].ToString(),
                        Salary = Convert.ToInt32(rd["e_salary"]),
                        isPartTime =rd["isPartTime"].ToString(),
                        Phone = rd["e_phone"].ToString(),
                        Mail = rd["e_mail"].ToString(),
                        Position = rd["e_position"].ToString(),
                        Workdays = rd["e_workdays"].ToString(),
                        SSN = rd["e_ssn"].ToString(),
                        Birthday = Convert.ToDateTime(rd["e_bday"])
                    });
                }
            }
            com.Dispose();
            com.Connection.Close();
            return list;
        }

        public static EmployeeEntity SelectEmployeeById(int id)
        {
            SqlCommand com = new SqlCommand("sp_GetEmployeeByID @ID", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);

            if (com.Connection.State != ConnectionState.Open)
            {
                com.Connection.Open();
            }

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {

                rd.Read();

                return new EmployeeEntity
                {
                    Name = rd["e_name"].ToString(),
                    SurName = rd["e_lname"].ToString(),
                    Salary = Convert.ToInt32(rd["e_salary"]),
                    isPartTime = rd["isPartTime"].ToString(),
                    Phone = rd["e_phone"].ToString(),
                    Mail = rd["e_mail"].ToString(),
                    Position = rd["e_position"].ToString(),
                    Workdays = rd["e_workdays"].ToString(),
                    SSN = rd["e_ssn"].ToString(),
                    Birthday = Convert.ToDateTime(rd["e_bday"])
                };

            }
            com.Dispose();
            com.Connection.Close();

            return null;
        }


        public static EmployeeEntity InsertEmployee(string Name, string SurName,int Salary , string isPartTime , string Phone , string Mail , string Position , string Workdays , string SSN , DateTime Birthday)
        {
            SqlCommand com = new SqlCommand("SP_InsertEmployee @NAME ,@SURNAME ,@SALARY ,@ISPARTTIME ,@PHONE ,@MAIL ,@POSITION ,@WORKDAYS ,@SSN ,@BIRTHDAY", Connection.Con);
            com.Parameters.AddWithValue("@NAME", Name);
            com.Parameters.AddWithValue("@SURNAME", SurName);
            com.Parameters.AddWithValue("@SALARY", Salary);
            com.Parameters.AddWithValue("@ISPARTTIME", isPartTime);
            com.Parameters.AddWithValue("@PHONE", Phone);
            com.Parameters.AddWithValue("@MAIL", Mail);
            com.Parameters.AddWithValue("@POSITION", Position);
            com.Parameters.AddWithValue("@WORKDAYS", Workdays);
            com.Parameters.AddWithValue("@SSN", SSN);
            com.Parameters.AddWithValue("@BIRTHDAY", Birthday);

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

        public static EmployeeEntity UpdateEmployee(int id,string Name, string SurName, int Salary, string isPartTime, string Phone, string Mail, string Position, string Workdays, string SSN, DateTime Birthday)
        {


            SqlCommand com = new SqlCommand("SP_UpdateEmployee @ID ,@NAME ,@SURNAME ,@SALARY ,@ISPARTTIME ,@PHONE ,@MAIL ,@POSITION ,@WORKDAYS ,@SSN ,@BIRTHDAY", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);
            com.Parameters.AddWithValue("@NAME", Name);
            com.Parameters.AddWithValue("@SURNAME", SurName);
            com.Parameters.AddWithValue("@SALARY", Salary);
            com.Parameters.AddWithValue("@ISPARTTIME", isPartTime);
            com.Parameters.AddWithValue("@PHONE", Phone);
            com.Parameters.AddWithValue("@MAIL", Mail);
            com.Parameters.AddWithValue("@POSITION", Position);
            com.Parameters.AddWithValue("@WORKDAYS", Workdays);
            com.Parameters.AddWithValue("@SSN", SSN);
            com.Parameters.AddWithValue("@BIRTHDAY", Birthday);

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

        public static EmployeeEntity DeleteEmployee(int id)
        {


            SqlCommand com = new SqlCommand("SP_DeleteEmployee @ID", Connection.Con);
            com.Parameters.AddWithValue("@ID", id);


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
