using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Admin_Page_Stocks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grid3.DataSource = OTOTO.Business.Stocks.GetAllStock();
            grid3.DataBind();
        }
    }
}