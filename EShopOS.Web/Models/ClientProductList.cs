using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShopOS.Web.Models
{
    public class ClientProductList
    {

        public int Id { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }


    }
}