using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FAL.Annotation.DAL;

namespace FAL.Annotation.GUI
{
    public partial class AnnotationRepeater : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            base.OnPreRender(e);
            AnnotationDataContext db = new AnnotationDataContext();
            var a = from x 
                        in db.Annotation
                        where x.Priority > 0
                        orderby x.Datum descending
                     select x;

            Repeater1.DataSource = a;
            Repeater1.DataBind();
        }


    }
}