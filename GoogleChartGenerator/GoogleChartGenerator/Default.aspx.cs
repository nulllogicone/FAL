using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.Collections.Specialized;

namespace GoogleChartGenerator
{
    public partial class _Default : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            

            
            int[] data = { 12, 10, 131, 18, 112, 17 };
            int[] data2 = { 237, 115, 13, 8, 125, 16 };
            string[] legend = { "ich", "bin", "hier", "auch", "die", "welt" };


            GCG c = new GCG();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Zeit", typeof(string)));
            dt.Columns.Add(new DataColumn("Wert", typeof(int)));
            foreach(int i in data2)
            {
                DataRow newR = dt.NewRow();
                newR[1] = i;
                dt.Rows.Add(newR);
            }
            c.ChartData = (dt);

            c.Width = int.Parse(TextBoxWidth.Text);
            c.Height = int.Parse(TextBoxHeight.Text);
            if (RadioButtonPie.Checked) c.ChartType = GCG.ChartTypes.Pie;
            if (RadioButtonBar.Checked) c.ChartType = GCG.ChartTypes.Bar;
            if (RadioButtonLine.Checked) c.ChartType = GCG.ChartTypes.Line;
            

            c.ChartTitle = TextBoxTitel.Text;
            

            string url = c.ImageUrl;
            ImageGoogleChart.ImageUrl = url;
            TextBoxUrl.Text = url;


        }
    }
}
