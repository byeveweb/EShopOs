using EShopOS.Core;
using EShopOS.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EShopOS.Web.Admin
{
    public partial class UserList : System.Web.UI.Page
    {
        ApplicationDbContext context = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            context = new ApplicationDbContext();
            UserManager<ApplicationUser> userManager =
                 new UserManager<ApplicationUser>(
                     new UserStore<ApplicationUser>(context));

                 var use = userManager.Users;

           //var usee = Membership.GetAllUsers();


                string formatlink = "<a href='UserDetail.aspx?Id={0}'>{1}</a>";


            foreach (var us in use)
            {
                
                var row = new TableRow();
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, us.Id, us.Id.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, us.Id, us.City) });
                row.Cells.Add(new TableCell { Text = string.Format(us.Email) });
                //row.Cells.Add(new TableCell { Text = string.Format(us.Id, us.Roles.Count.ToString()) });
                row.Cells.Add(new TableCell { Text = string.Format(formatlink, us.Id, "Ver/Editar") });
                tbody.Controls.Add(row);
            }

        }
    }
}