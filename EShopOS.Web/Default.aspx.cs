using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AccesCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client/ProductsFiles/ProductCat.aspx");
        }

        protected void CatAccss_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client/ProductsFiles/ProductCat.aspx");
        }
    }
}