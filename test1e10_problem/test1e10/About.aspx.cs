using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1e10
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["cook"] != null)
            {
                Response.Write("No Cookie");
                Response.End();
            }
            else
            {
                Response.Write("cookie value:" + Request.Cookies["cook"]);
                Response.End();
            }
        }
    }
}
