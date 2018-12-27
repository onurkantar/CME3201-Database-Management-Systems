using System;
using System.Collections.Generic;
using OTOTO.DataAccess;
using static OTOTO.DataAccess.CustomerEntityBase;

namespace OTOTO.Business
{
    public class Customers
    {
        public static List<CustomerEntity> GetAllCustomers()
        {
            return DataAccess.CustomerDAO.GetAllCustomers();
        }

        public static CustomerEntity SelectCustomer(int id)
        {
            if (id > 0)
                return DataAccess.CustomerDAO.SelectCustomerById(id);
            else
                return null;
        }

        public static CustomerEntity SelectCustomer(string value)
        {
            throw new NotImplementedException();
        }

       
        public static CustomerEntity DeleteCustomer(int id)
        {

            if (id > 0)
                return DataAccess.CustomerDAO.DeleteCustomer(id);
            else
                return null;


        }

        public static CustomerEntity InsertCustomer(string Name, string SurName ,string Phone, string Mail,  string SSN)
        {

            return DataAccess.CustomerDAO.InsertCustomer(Name, SurName, Phone, Mail, SSN);

        }

        public static CustomerEntity UpdateCustomer(int id,string Name, string SurName, string Phone, string Mail, string SSN)
        {

            return DataAccess.CustomerDAO.UpdateCustomer(id, Name, SurName, Phone, Mail, SSN);

        }

    }
}
