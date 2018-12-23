using GraWPanstwa.Models;
using GraWPanstwa.Repozytorium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraWPanstwa.Poziomy
{
    public partial class Level4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Gracz gracz = new Gracz();
            gracz.Nazwa = (string)Session["graczLevel3Login"];
            gracz.Punkty = (int)Session["graczLevel3Punkty"];
            string[] s = new string[] { "A", "Z", "E", "R", "B", "E", "J", "D", "Ż", "A", "N" };
            string[] poZmieszaniu;
            if (!IsPostBack)
            {
                lblStatus.Text = String.Format("{0} twój obecny wynik to: {1}", gracz.Nazwa, gracz.Punkty);
                Mieszanie m = new Mieszanie();
                poZmieszaniu = m.ZmianaKolejnosci(s);
                Session["poZmieszaniu"] = poZmieszaniu;
                foreach (var item in poZmieszaniu)
                {
                    Button btn = new Button
                    {
                        Text = item
                    };
                    btn.Click += new EventHandler(btn_Click);
                    buttons.Controls.Add(btn);
                }
            }
            if (IsPostBack)
            {
                lblStatus.Text = String.Format("{0} twój obecny wynik to: {1}", gracz.Nazwa, gracz.Punkty);
                foreach (string item in (string[])Session["poZmieszaniu"])
                {
                    Button btn = new Button
                    {
                        Text = item
                    };
                    btn.Click += new EventHandler(btn_Click);
                    buttons.Controls.Add(btn);

                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var current = sender as Button;
            txtAnswear.Text += current.Text;
            current.Enabled = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < buttons.Controls.Count; i++)
            {
                if (((Button)buttons.Controls[i]).Enabled)
                {
                    counter++;
                }
            }
            Gracz gracz = new Gracz
            {
                Nazwa = (string)Session["graczLevel3Login"],
                Punkty = (int)Session["graczLevel3Punkty"]
            };
            Session["graczLevel4Login"] = gracz.Nazwa;
            BazaPanstw baza = new BazaPanstw();
            if (baza.Panstwa().Contains(txtAnswear.Text) && counter == 0)
            {
                gracz.Punkty += 5;
                Session["graczLevel4Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level5.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter == 1))
            {
                gracz.Punkty += 4;
                Session["graczLevel4Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level5.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter == 2))
            {
                gracz.Punkty += 3;
                Session["graczLevel4Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level5.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter == 3))
            {
                gracz.Punkty += 2;
                Session["graczLevel4Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level5.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter == 4))
            {
                gracz.Punkty += 1;
                Session["graczLevel4Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level5.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter > 4))
            {
                gracz.Punkty += 0;
                Session["graczLevel4Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level5.aspx");
            }
            else
            {
                lblMessage.Text = "Błędna odpowiedź.";
            }
        }
        protected void btnBackspace_Click(object sender, EventArgs e)
        {
            int answear = txtAnswear.Text.Length;
            if (answear == 0)
            {
                lblMessage.Text = "Brak liter do usunięcia";
            }
            else
            {
                string letter = txtAnswear.Text[answear - 1].ToString();
                txtAnswear.Text = txtAnswear.Text.Remove(answear - 1);
                for (int i = 0; i < buttons.Controls.Count; i++)
                {
                    if (((Button)buttons.Controls[i]).Text == letter && !((Button)buttons.Controls[i]).Enabled)
                    {
                        ((Button)buttons.Controls[i]).Enabled = true;
                        break;
                    }
                }
            }
        }
    }
}