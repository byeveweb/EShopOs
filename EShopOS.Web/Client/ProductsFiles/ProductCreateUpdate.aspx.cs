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
    public partial class ProductCreateUpdate : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        ProductManager productManager = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            //Traemos el contexto de los datos de producto capa de datos
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);

            selStatusProduct.DataSource = Enum.GetValues(typeof(ProductStatus));
            var pS = selStatusProduct.SelectedValue;
            selStatusProduct.DataBind();
            selStatusProduct.SelectedValue = pS;

            

            int id = 0;
            var idt = Request.QueryString["id"];
            var product = productManager.GetById(new object[] { id });
            if (int.TryParse(idt, out id))
            {
                LoadProduct(product);
            }

            //if (idt!=null) {

            //    int id = 0;
            //    if (int.TryParse(idt, out id))
            //    {
                   
            //        var product = productManager.GetById(new object[] { id });
            //        if(product != null)
            //        {
            //            LoadProduct(product);
            //            if (!IsPostBack)
            //            {
            //                selStatusProduct.SelectedValue = product.ProductStatus.ToString();
            //            }

            //        }

                  
            //    }


            //        //if(int.TryParse(Request.QueryString["id"], out id))
            //        //{
            //        //    var product = productManager.GetById(id);
            //        //    LoadProduct(product);
            //        //}
            //    }




        }
        private void LoadProduct(Product product)
        {
            txtId.Value = product.Id.ToString();
            txtNameProduct.Text = product.NameProduct;
            txtDescriptionProduct.Text = product.Description;
            txtPriceProduct.Text = product.Price.ToString();
            txtStockProduct.Text = product.Stock.ToString();
            selStatusProduct.SelectedValue = ((int)product.ProductStatus).ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtId.Value))
            {


                Product product = new Product
                {
                    NameProduct = txtNameProduct.Text,
                    Description = txtDescriptionProduct.Text,
                    Price = Decimal.Parse(txtPriceProduct.Text),
                    Stock = Int32.Parse(txtStockProduct.Text),
                    ProductStatus = (ProductStatus)Enum.Parse(typeof(ProductStatus), selStatusProduct.SelectedValue)

             };

                productManager.Add(product);
                productManager.Context.SaveChanges();
                Response.Redirect("home");
            }

            else
            {

                 Product product = new Product
                {
                    NameProduct = txtNameProduct.Text,
                    Description = txtDescriptionProduct.Text,
                    Price = Decimal.Parse(txtPriceProduct.Text),
                    Stock = Int32.Parse(txtStockProduct.Text),
                     ProductStatus = (ProductStatus)Enum.Parse(typeof(ProductStatus), selStatusProduct.SelectedValue)

                };
                productManager.Context.SaveChanges();
                Response.Redirect("home");
            }

            
        }
    }
}