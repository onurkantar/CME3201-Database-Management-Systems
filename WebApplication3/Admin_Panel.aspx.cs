using OTOTO.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Admin_Panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grid112.DataSource = OTOTO.Business.Employees.GetAllLogs();
            grid112.DataBind();
        }
    }
}