﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Admin_Page_Customers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grid.DataSource = OTOTO.Business.Customers.GetAllCustomers();
            grid.DataBind();

        }
    }
}