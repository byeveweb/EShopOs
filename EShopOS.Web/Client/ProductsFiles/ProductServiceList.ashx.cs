using EShopOS.Application;
using EShopOS.Core;
using EShopOS.DAL;
using EShopOS.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.Script.Serialization;

namespace EShopOS.Web.Client
{
    /// <summary>
    /// Descripción breve de ProductServiceList
    /// </summary>
    public class ProductServiceList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            //var iDisplayStart = int.Parse(context.Request["iDisplayStart"]);
            //var iDisplayLength = int.Parse(context.Request["iDisplayLength"]);
            //var sSearch = context.Request["sSearch"];
            //var iSortCol = context.Request["iSortCol_0"];
            //var iSortDir = context.Request["iSortDir_0"];
            //var sortColum = context.Request.QueryString["mDataProp_" + iSortCol];

            ApplicationDbContext contextdb = new ApplicationDbContext();
            ProductManager productManager = new ProductManager(contextdb);
            var allProducts = productManager.GetAll();


            //var allProducts = productManager;

            //#region Filter
            //if(!string.IsNullOrWhiteSpace(sSearch))
            //{
            //    string where = @"Id.ToString().Contains(@0 ||
            //                    ProductName.ToString.Contains(@0";
            //    _ = allProducts.Where(where, sSearch);
            //}
            //#endregion

            //#region Paginate
            //allProducts = allProducts
            //    .OrderBy(sortColum + " " + iSortDir)
            //    .Skip(iDisplayStart)
            //    .Take(iDisplayLength);
            //#endregion


            //var result = new
            //{
            //    iTotalRecords = allProducts.Count(),
            //    iTotalDisplayRecords = allProducts.Count(),
            //    aaData = allProducts

            //};


            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(allProducts);
            context.Response.ContentType = "application/json";
            context.Response.Write(json);

            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hola a todos");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}