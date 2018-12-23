using GraWPanstwa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraWPanstwa
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTak_Click(object sender, EventArgs e)
        {
            lblLogin.Visible = true;
            txtLogin.Visible = true;
            btnNie.Visible = false;
            btnTak.Visible = false;
            btnGracz.Visible = true;
        }

        protected void btnNie_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Baza/ExitPage.aspx");            
        }

        protected void btnGracz_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length == 0)
            {
                lblError.Visible = true;
            }
            else
            {
                Gracz gracz = new Gracz
                {
                    Nazwa = txtLogin.Text,
                    Punkty = 0
                };
                Session["gracz"] = txtLogin.Text;
                Response.Redirect("/Baza/Rules.aspx");
            }
        }
    }
}