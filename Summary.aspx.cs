using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GraWPanstwa.Baza
{
    public partial class Summary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                TableCell cell3 = new TableCell();
                TableCell cell4 = new TableCell();
                cell1.Text = Session["gracz"].ToString();
                cell2.Text = (i + 1).ToString();
                if (cell2.Text=="1")
                {
                    cell3.Text = Session["graczLevel1Punkty"].ToString();
                }
                else
                {
                    cell3.Text = (Convert.ToInt32(Session[String.Format("graczLevel{0}Punkty", i + 1)]) - Convert.ToInt32(Session[String.Format("graczLevel{0}Punkty", i)])).ToString();
                }
                cell4.Text = "5";
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                tblPodsumowanie.Rows.Add(row);
            }

        }
        protected void btnDalej_Click(object sender, EventArgs e)
        {
            Server.Transfer("/Baza/ExitPage.aspx");
        }
        
    }
}