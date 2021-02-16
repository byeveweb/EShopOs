using EShopOS.Web.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace EShopOS.Web.Helpers
{
    public static class UserControls
    {
        public static string RenderUserControl(string path, Dictionary<string, object> parameters)
        {
            Page pageHolder = new Page();
            Control viewControl = pageHolder.LoadControl(path);
            if (viewControl != null)
            {
                if (parameters != null && parameters.Any())
                {
                    foreach (var parameter in parameters)
                    {
                        var property = viewControl.GetType().GetProperty(parameter.Key);
                        if(property!=null)
                        {
                            property.SetValue(viewControl, parameter.Value);
                        }
                    }
                }
                pageHolder.Controls.Add(viewControl);
                using (StringWriter output = new StringWriter())
                {
                    HttpContext.Current.Server.Execute(pageHolder, output, false);
                    return output.ToString();
                }
            }
            return string.Empty;
        }
    }
}