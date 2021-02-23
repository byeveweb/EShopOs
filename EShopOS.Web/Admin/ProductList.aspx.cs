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

            try { 
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);


                var products = productManager
                                .GetAll()
                                .OrderBy(i => i.Id);
            string formatlink = "<a href='ProductDetailAndUpdate.aspx?Id={0}' class='link'>{1}</a>";


            foreach (var product in products)
            {
                var row = new TableRow();
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, product.Id, product.Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, product.Id, product.NameProduct.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.Price.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.Stock.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.ProductStatus.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, product.Id, "Editar") });
                tbody.Controls.Add(row);

            }

            }
            catch
            {

                //TODO: error, no encontrado
                result.Text = "No se ha encontrado el listado de productos indicada";
                result.CssClass = "has-error";


            }

        }



    }
}