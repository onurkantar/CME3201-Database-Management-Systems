using OTOTO.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static OTOTO.DataAccess.EmployeeEntityBase;

namespace WebApplication3
{
    public partial class registerEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            int general_id;
            general_id = Convert.ToInt16(Request.Form.Get("idField"));

            EmployeeEntity temp = Employees.SelectEmployee(general_id);

            if (temp != null) { 

            id1.Value = Convert.ToString(temp.id);
            name.Value = temp.Name;
            surname.Value = temp.SurName;
            salary.Value = Convert.ToString(temp.Salary);
            select1.Value = temp.isPartTime;
            phone_number.Value = temp.Phone;
            mail_box.Value = temp.Mail;
            select2.Value = temp.Position;
            select3.Value = temp.Workdays;
            ssn_number.Value = temp.SSN;
            calendar.Value = Convert.ToString(temp.Birthday);
            }
            */
        }

        protected void insertEmployee(object sender, EventArgs e)
        {
            Employees.InsertEmployee(name.Value, surname.Value, Convert.ToInt32(salary.Value), select1.Value, phone_number.Value , mail_box.Value, select2.Value , select3.Value , ssn_number.Value, Convert.ToDateTime(calendar.Value));
            Response.Redirect("Admin_Panel.aspx");

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void UpdateEmployee(object sender, EventArgs e)
        {

            
            Employees.UpdateEmployee(Convert.ToInt16(id1.Value), name.Value, surname.Value, Convert.ToInt32(salary.Value), select1.Value, phone_number.Value, mail_box.Value, select2.Value, select3.Value, ssn_number.Value, Convert.ToDateTime(calendar.Value));
            Response.Redirect("Admin_Panel.aspx");

        }
    }
}