using OTOTO.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static OTOTO.DataAccess.StockEntityBase;

namespace WebApplication3
{
    public partial class SearchAndDeleteStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grid4.DataSource = Stocks.GetAllStock();
            grid4.DataBind();

        }

        protected void SearchStock(object sender, EventArgs e) {
            List<StockEntity> temp = new List<StockEntity>();
            if (!idF.Value.Equals("")) {
                temp.Add(Stocks.SelectStock(Convert.ToInt16(idF.Value)));
                grid4.DataSource = temp;
                grid4.DataBind();
            }
        }

        protected void DeleteStock(object sender, EventArgs e) {

            Stocks.DeleteStock(Convert.ToInt16(idF.Value));
            grid4.DataSource = Stocks.GetAllStock();
            grid4.DataBind();
        }
    }
}