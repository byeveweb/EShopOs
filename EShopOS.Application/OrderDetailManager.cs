using EShopOS.Core;
using EShopOS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopOS.Application
{
    public class OrderDetailManager: GenericManager<OrderDetail>
    {
        public OrderDetailManager(ApplicationDbContext context)
           : base(context)
        {

        }
    }
}
