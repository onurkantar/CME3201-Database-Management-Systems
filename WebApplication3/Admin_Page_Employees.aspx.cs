using OTOTO.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static OTOTO.DataAccess.EmployeeEntityBase;

namespace WebApplication3
{
    public partial class Admin_Page_Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (grid != null) {
                grid.DataSource = OTOTO.Business.Employees.GetAllEmployees();
                grid.DataBind();
            }
        }

        protected void SearchEmployee(object sender, EventArgs e)
        {
            List<EmployeeEntity> searchItem = new List<EmployeeEntity>();
            if (!idField3.Value.Equals(""))
            {
                searchItem.Add(Employees.SelectEmployee(Convert.ToInt16(idField3.Value)));
                grid.DataSource = searchItem;
                try
                {
                    if (!searchItem.ElementAt(0).Equals(""))
                    {

                        grid.DataBind();

                    }
                }
                catch {

                    grid.DataSource = null;
                    grid.DataBind();

                }

                

            }
        }

        protected void DeleteEmployee(object sender, EventArgs e)
        {

            if (!idField3.Value.Equals("")) {

            Employees.DeleteEmployee(Convert.ToInt16(idField3.Value));
            grid.DataSource = OTOTO.Business.Employees.GetAllEmployees();
            grid.DataBind();

            }
        }

        protected void redirectEmployee(object sender , EventArgs e) {

            
            Response.Redirect("UpdateEmployee.aspx");
        }

        

        
    }
}