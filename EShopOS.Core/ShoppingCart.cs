﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Core
{
    public class ShoppingCart
    {        
        public int Id { get; set; }
     
        [ForeignKey("User")]
        public string User_Id { get; set; }        
        public ApplicationUser User { get; set; }

        [ForeignKey("Product")]
        public int Product_Id { get; set; }        
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
