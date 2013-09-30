using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test1e10
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook", "chicken");
            cookie.Secure = true;
            Response.Cookies.Add(cookie);
            Response.Redirect("~/About.aspx");
        }
    }
}
