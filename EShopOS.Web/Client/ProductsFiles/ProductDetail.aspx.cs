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
    public partial class ProductDetail : System.Web.UI.Page
    {
        ApplicationDbContext context = null;
        ProductManager productManager = null;
        Product product = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Traemos el contexto de los datos de producto capa de datos
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);



            try
            {


                var idtext = Request.QueryString["Id"];

                if (idtext != null)
                {

                    int id = 0;

                    if (int.TryParse(idtext, out id))
                    {
                        product = productManager.GetById(new object[] { id });
                        if (product != null)
                        {
                           

 
                                txtNameProduct.Text = product.NameProduct;
                                txtDescription.Text = product.Description;
                                txtPrice.Text = product.Price.ToString();
                                txtStock.Text = product.Stock.ToString();
                                txtProductStatus.Text = product.ProductStatus.ToString();
                                txtProductId.Text = product.Id.ToString();
                           

                        }
                        else
                        {
                            //TODO: error, no encontrado
                            result.Text = "No se ha encontrado el producto indicado";
                           
                        }
                    }
                    else
                    {
                        //TODO: Error de parseo
                        result.Text = "No se ha encontrado la producto indicado";

                    }
                }

            }
            catch (Exception ex)
            {
                result.Text = "Se ha producido un error, si este persiste contacte con el administrador";
                result.CssClass = "has-error";
                //TODO: Guardar un log con el error
            }

        }
    }
}