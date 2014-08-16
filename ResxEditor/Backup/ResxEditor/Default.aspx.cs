using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace ResxEditor
{
    public partial class Default : System.Web.UI.Page
    {
        string fullpath = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/App_Data");
            fullpath = Path.Combine(path, "Guide.aspx.resx");
        }

        protected void ButtonLoad_Click(object sender, EventArgs e)
        {


            DataSet ds = new DataSet();
            ds.ReadXml(fullpath);

            dataSet = ds;

            GridView1.DataSource = dataSet.Tables["data"];
            GridView1.DataBind();
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow gvr in GridView1.Rows)
            {
                Label lb = (Label)gvr.FindControl("LabelName");
                string name = lb.Text;
                TextBox tb = (TextBox)gvr.FindControl("TextBoxValue");
                string value = tb.Text;

                DataRow dr = dataSet.Tables["data"].Select(string.Format("name='{0}'", name))[0];
                dr["value"] = value;

            }
            dataSet.WriteXml(fullpath);
        }

        private DataSet dataSet
        {
            set { Session["dts"] = value; }
            get { return (DataSet)Session["dts"]; }
        }

    }
}
