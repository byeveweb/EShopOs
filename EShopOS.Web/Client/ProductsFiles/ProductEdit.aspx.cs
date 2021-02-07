using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client
{
    public partial class ProductEdit : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        ProductManager productManager = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Traemos el contexto de los datos de producto capa de datos
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);


            int id = 0;
            var idt = Request.QueryString["id"];
            //Traemos el
            if (idt!=null) {

                if(int.TryParse(Request.QueryString["id"], out id))
                {
                    var product = productManager.GetById(id);
                    LoadProduct(product);
                }
            }




        }
        private void LoadProduct(Product product)
        {
            txtId.Value = product.Id.ToString();
            txtNameProduct.Text = product.NameProduct;
            txtDescriptionProduct.Text = product.Description;
            txtPriceProduct.Text = product.Price.ToString();
            txtStockProduct.Text = product.Stock.ToString();
            selStatusProduct.Text = product.ProductStatus.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                NameProduct = txtNameProduct.Text,
                Description = txtDescriptionProduct.Text,
                Price = Decimal.Parse(txtPriceProduct.Text),
                Stock = Int32.Parse(txtStockProduct.Text)

            };
            productManager.Context.SaveChanges();
            Response.Redirect("home");

        }
    }
}