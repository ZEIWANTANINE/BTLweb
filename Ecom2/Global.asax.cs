using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Ecom2
{
    public class Global : System.Web.HttpApplication
    {
        public const string PRODUCT_LIST = "DSSP";
        protected void Application_Start(object sender, EventArgs e)
        {
            Application[PRODUCT_LIST] = createProductList();
        }
        private List<Product> createProductList()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Ao thun ni", Price = 120000, Imageurl = "Source/img/Phong.png" },
                new Product { Id = 2, Name = "Áo sơ mi nam", Price = 200000, Imageurl = "Source/img/meo.jpg" },
                new Product { Id = 3, Name = "Áo thun", Price = 200000, Imageurl = "Source/img/meo2.jpg" },
                new Product { Id = 4, Name = "Quần jeans", Price = 200000, Imageurl = "Source/img/meo3.jpg" },
            };
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}