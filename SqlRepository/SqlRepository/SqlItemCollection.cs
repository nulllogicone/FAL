using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Linq;

namespace SqlRepository
{
    public class SqlItemCollection
    {
        string filePath = HttpContext.Current.Server.MapPath("TestSet.xml");

        public object Items
        {
            get
            {
                XDocument doc = XDocument.Load(filePath);
                var tt = from t in doc.Elements("SqlRepository").Elements()
                         select new {
                             Title=t.Attribute("Title").Value, 
                             Text=t.Element("Text").Value,
                             Command=t.Element("Command").Value 
                         };
                return tt;
            }
        }
    }
}
