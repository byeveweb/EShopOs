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
        Product product = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            //Traemos el contexto de los datos de producto capa de datos
            context = new ApplicationDbContext();
            productManager = new ProductManager(context);



            selStatusProduct.DataSource = Enum.GetValues(typeof(ProductStatus));
            var pS = selStatusProduct.SelectedValue;
            selStatusProduct.DataBind();
            selStatusProduct.SelectedValue = pS;


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
                            if (!Page.IsPostBack)
                            {

                                txtId.Value = product.Id.ToString();
                                txtNameProduct.Text = product.NameProduct;
                                txtDescriptionProduct.Text = product.Description;
                                txtPriceProduct.Text = product.Price.ToString();
                                txtStockProduct.Text = product.Stock.ToString();
                                selStatusProduct.Text = product.ProductStatus.ToString();
                                txtIdProduct.Text = product.Id.ToString();
                            }

                            nuevoPd.Visible = false;
                            editarPd.Visible = true;
                            btnDelete.Visible = true;
                            txtShowId.Visible = true;
                            btnSubmit.Text = "Editar producto";

                        }
                        else
                        {
                            //TODO: error, no encontrado
                            result.Text = "No se ha encontrado el producto indicado";
                            nuevoPd.Visible = true;
                            editarPd.Visible = false;
                            txtShowId.Visible = false;
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrWhiteSpace(txtId.Value))
                {

                    //ADD NEW PRODUCT

                    string path = Server.MapPath("~/Content/Images/") + FileUpload1.PostedFile.FileName;
                    FileUpload1.SaveAs(path);

                    product = new Product
                    {
                        NameProduct = txtNameProduct.Text,
                        Description = txtDescriptionProduct.Text,
                        Price = Decimal.Parse(txtPriceProduct.Text),
                        Stock = Int32.Parse(txtStockProduct.Text),
                        ProductStatus = (ProductStatus)Enum.Parse(typeof(ProductStatus), selStatusProduct.SelectedValue),
                        ImageUrl = "~/Content/images/" + FileUpload1.PostedFile.FileName,

                    };

                    productManager.Add(product);
                    productManager.Context.SaveChanges();
                    Response.Redirect("ProductList.aspx");


                }
                else
                {
                    #region modificar


                    product.NameProduct = txtNameProduct.Text;
                    product.Description = txtDescriptionProduct.Text;
                    product.Price = Decimal.Parse(txtPriceProduct.Text);
                    product.Stock = Int32.Parse(txtStockProduct.Text);
                    product.ProductStatus = (ProductStatus)Enum.Parse(typeof(ProductStatus), selStatusProduct.SelectedValue);


                    #endregion
                }

                productManager.Context.SaveChanges();
                result.Text = "Producto guardada con exito.";
                result.CssClass = "has-success";
            }
            catch (Exception ex)
            {
                result.Text = "Se ha producido un error, si este persiste contacte con el administrador";
                result.CssClass = "has-error";
                //TODO: Guardar un log con el error
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var idtext = Request.QueryString["Id"];
            var pd = productManager.GetAll().Where(u => u.Id.ToString() == idtext);

            foreach (var p in pd)
            {
                productManager.Remove(p);
            }

            productManager.Context.SaveChanges();
            Response.Redirect("ProductList.aspx");

        }
    }
}