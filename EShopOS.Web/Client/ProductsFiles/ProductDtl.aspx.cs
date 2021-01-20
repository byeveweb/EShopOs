using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Client.ProductsFiles
{
    public partial class ProductDtl : System.Web.UI.Page
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
            if (idt != null)
            {

                if (int.TryParse(Request.QueryString["id"], out id))
                {
                    Product product = productManager.GetById(id);
                    LoadProduct(product);
                }
            }

        }

        private void LoadProduct(Product product)
        {
            txtId.Value = product.Id.ToString();
            txtNameProduct.Text = product.NameProduct;
            
        }
    }
}