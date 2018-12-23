﻿using System;
using GraWPanstwa.Models;
using System.Web.UI.WebControls;
using GraWPanstwa.Repozytorium;

namespace GraWPanstwa.Poziomy
{
    public partial class Level1 : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            Gracz gracz = new Gracz();
            gracz.Nazwa = (string)Session["gracz"];
            gracz.Punkty = 0;
            string[] s = new string[] { "K", "A", "N", "A", "D", "A" };
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
                foreach (var item in (string[])Session["poZmieszaniu"])
                {
                    Button btn = new Button
                    {
                        Text = item,
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
                Nazwa = (string)Session["gracz"],
                Punkty = 0
            };
            Session["graczLevel1Login"] = gracz.Nazwa;
            BazaPanstw baza = new BazaPanstw();
            if (baza.Panstwa().Contains(txtAnswear.Text) && counter==0)
            {
                gracz.Punkty += 5;
                Session["graczLevel1Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level2.aspx");
            }
            else if((baza.Panstwa().Contains(txtAnswear.Text) && counter == 1))
            {
                gracz.Punkty += 4;
                Session["graczLevel1Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level2.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter == 2))
            {
                gracz.Punkty += 3;
                Session["graczLevel1Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level2.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter == 3))
            {
                gracz.Punkty += 2;
                Session["graczLevel1Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level2.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter == 4))
            {
                gracz.Punkty += 1;
                Session["graczLevel1Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level2.aspx");
            }
            else if ((baza.Panstwa().Contains(txtAnswear.Text) && counter > 4))
            {
                gracz.Punkty += 0;
                Session["graczLevel1Punkty"] = gracz.Punkty;
                Response.Redirect("/Poziomy/Level2.aspx");
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