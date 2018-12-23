using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraWPanstwa.Baza
{
    public partial class Rules : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDalej_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Poziomy/Level1.aspx");
        }
    }
}