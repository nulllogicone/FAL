using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAL.Annotation
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.AnnotationDataContext dc = new Annotation.DAL.AnnotationDataContext();
            var annos = from xx in dc.Annotation select xx;

            GridView1.DataSource = annos;
            GridView1.DataBind();
        }
    }
}
