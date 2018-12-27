using System;
using System.Collections.Generic;
using OTOTO.DataAccess;
using static OTOTO.DataAccess.EmployeeEntityBase;
using static OTOTO.DataAccess.LogEntityBase;

namespace OTOTO.Business
{
    public class Employees
    {
        public static List<LogEntity> GetAllLogs()
        {
            return DataAccess.LogDAO.GetAllLogs();
        }

        public static List<EmployeeEntity> GetAllEmployees()
        {
            return DataAccess.EmployeeDAO.GetAllEmployees();
        }

        public static EmployeeEntity SelectEmployee(int id)
        {
            if (id > 0)
                return DataAccess.EmployeeDAO.SelectEmployeeById(id);
            else
                return null;
        }

        public static EmployeeEntity SelectEmployee(string value)
        {
            throw new NotImplementedException();
        }
        
        public static EmployeeEntity DeleteEmployee(int id) {

            if (id > 0)
                return DataAccess.EmployeeDAO.DeleteEmployee(id);
            else
                return null;


        }

        public static EmployeeEntity InsertEmployee(string Name, string SurName, int Salary, string isPartTime, string Phone, string Mail, string Position, string Workdays, string SSN,  
            DateTime Birthday) {

            return DataAccess.EmployeeDAO.InsertEmployee(Name,SurName,Salary,isPartTime,Phone,Mail,Position,Workdays,SSN,Birthday);

        }

        public static EmployeeEntity UpdateEmployee(int id ,string Name, string SurName, int Salary, string isPartTime, string Phone, string Mail, string Position, string Workdays, string SSN, DateTime Birthday)
        {

            return DataAccess.EmployeeDAO.UpdateEmployee(id ,Name, SurName, Salary, isPartTime, Phone, Mail, Position, Workdays, SSN, Birthday);

        }

    }
}
