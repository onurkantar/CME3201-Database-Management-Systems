using OTOTO.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class AddStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertStock(object sender , EventArgs e) {

            Stocks.InsertStock(Convert.ToDateTime(calendar.Value), Convert.ToInt32(quantity.Value), Convert.ToInt32(price.Value), fromwhere.Value, sto_name.Value);
            Response.Redirect("Admin_Panel.aspx");

        }
    }
}