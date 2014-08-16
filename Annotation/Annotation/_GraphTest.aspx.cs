using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using GoogleChartGenerator;

namespace FAL.Annotation
{
    public partial class _GraphTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO - den Code aus der Testseite *DRINGEND* wieder löschen

            DataTable dataTable; // die muss gefüllt werden
            string constr = ConfigurationManager.ConnectionStrings["LotboxConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);

            string sql = "select top 20 ";
            sql += " datediff(ww, created, lastlogindate) AS AktiveWochen, ";
            sql += " count(*) AS AnzahlSpieler ";
            sql += " from playerview ";
            sql += " where SumOfPayIn > 0 and status=0 ";
            sql += " group by datediff(ww, created, lastlogindate) ";
            sql += " order by datediff(ww, created, lastlogindate) ";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataTable = ds.Tables[0];

            // -- Daten sind fertig
            GridView1.DataSource = dataTable;
            GridView1.DataBind();

            GCG g = new GCG();
            g.ChartData = dataTable;
            g.ChartTitle = "erster Test";
            g.ChartType = GCG.ChartTypes.Line;

            g.Width = 300;
            g.Height = 200;

            string url = g.ImageUrl;
            Image1.ImageUrl = url;




        }
    }
}
