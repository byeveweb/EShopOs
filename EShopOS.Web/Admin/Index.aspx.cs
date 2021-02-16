using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Admin
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GoToProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductList.aspx");
        }
        protected void GoToOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderList.aspx");
        }
        protected void GoToUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserList.aspx");
        }
    }
}