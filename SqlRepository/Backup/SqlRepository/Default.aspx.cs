using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Linq;
using System.Data.SqlClient;


namespace SqlRepository
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlItemCollection col = new SqlItemCollection();
            GridView1.DataSource = col.Items;
            GridView1.DataBind();
        }

        protected void ButtonExecute_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM Newsletter";

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TargleConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            object o = cmd.ExecuteScalar();
            string anz = o.ToString();

            LabelResult.Text = anz;
            con.Close();
        }
    }
}
