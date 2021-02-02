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
            string formatlink = "<a href='ProductDtl.aspx?Id={0}'>{1}</a>";

            HtmlButton b = new HtmlButton();
            b.Attributes.Add("onClick", "GreetingBtn_Click()");
            b.ID = "button1";
            b.InnerText = "+";
            b.ServerClick += new System.EventHandler(this.myFunction);

            var Quantity = 0;
            TableCell header = new TableCell();
            //header.RowSpan = 1;
            //header.ColumnSpan = 3;
            //header.Font.Bold = true;
            //header.HorizontalAlign = HorizontalAlign.Center;
            //header.VerticalAlign = VerticalAlign.Middle;
            //header.CssClass = "btn btn-primary";
            header.Controls.Add(b) ;

            foreach (var product in products)
            {
                var row = new TableRow();
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, product.Id, product.NameProduct.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.Description.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.Price.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.Stock.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(product.ProductStatus.ToString()) });
                row.Cells.Add(new TableCell { Text = "+",  CssClass = "btn btn-primary"  } );
                row.Cells.Add(new TableCell { Text = string.Format(Quantity.ToString()) });
                row.Cells.Add(new TableCell { Text = "-", CssClass = "btn btn-primary" });


                tbody.Controls.Add(row);


            }




        }

        void GreetingBtn_Click(Object sender, EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.

            Button clickedButton = (Button)sender;
            clickedButton.Text = "...button clicked...";
//            clickedButton.Enabled = false;

        }

        void myFunction(Object sender, EventArgs e)
        {
            TextBox1.Text = "hola";
        }


    }
}