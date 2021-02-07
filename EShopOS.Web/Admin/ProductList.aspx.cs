using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client
{
    public partial class ProductList : System.Web.UI.Page
    {

        ApplicationDbContext context = null;
        ProductManager productManager = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);

            var idtext = Request.QueryString["Id"];

            var products = productManager
                            .GetAll()
                            .OrderBy(i => i.NameProduct).OrderBy(i => i.Stock);
            string formatlink = "<a href='ProductDetailAndUpdate.aspx?Id={0}'>{1}</a>";
            


            foreach (var product in products)
            {
                var row = new TableRow();
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, product.Id, product.Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, product.Id, product.NameProduct.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.Price.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.Stock.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.ProductStatus.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, product.Id, "Editar") });
                row.Cells.Add(new TableCell { Text = string.Format("X") });
                tbody.Controls.Add(row);
            }




        }



    }
}