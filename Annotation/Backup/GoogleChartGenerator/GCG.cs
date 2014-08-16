using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Linq.Expressions;

namespace GoogleChartGenerator
{
    public class GCG
    {
        DataTable dt;
        int minX;
        int maxX;
        int minY;
        int maxY;

        // Konstate
        // --------
        const string BASE_URL = "http://chart.apis.google.com/chart?";

        // Aufzählungen
        // ------------
        public enum ChartTypes  { Pie, Bar, Line};

        // Instanzvariable
        // ---------------
        string title = "ohne Titel";
        ChartTypes type = ChartTypes.Pie;
        int width = 160;
        int height = 90;

        // Konstruktor
        // -----------

        public GCG()
        {
        }

        // Eigenschaften
        // -------------------------

        public string ImageUrl
        {
            get { return makeUrl(); }
        }

        public string ChartTitle
        {
            set { title = value; }
            get { return title; }
        }

        public int Width
        {
            set { width = value; }
            get { return width; }
        }

        public int Height
        {
            set { height = value;}
            get { return height; }
        }

        public ChartTypes ChartType
        {
            set { type = value; }
            get { return type; }
        }

        // Methoden
        // ----------------

        public DataTable ChartData
        {
            get{return dt;}
            set
            {
                dt = value;
                var valsX = from x in dt.AsEnumerable() select x.Field<int>(0);
                minX = (from x in valsX select valsX.Min()).FirstOrDefault();
                maxX = (from x in valsX select valsX.Max()).FirstOrDefault();

                var valsY = from x in dt.AsEnumerable() select x.Field<int>(1);
                minY = (from x in valsY select valsY.Min()).FirstOrDefault();
                maxY = (from x in valsY select valsY.Max()).FirstOrDefault();
            }
            
        }

        private string makeUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(BASE_URL);

           
            sb.Append(string.Format("chtt={0}&", ChartTitle));
            sb.Append(string.Format("cht={0}&", chartTypeToString(ChartType)));
            sb.Append(string.Format("chs={0}x{1}&", width.ToString(), height.ToString()));

            // Data
            sb.Append(string.Format("chd=t:{0}&", chartData));
            // Scaling
            sb.Append(string.Format("chds=0,{0}&", maxY.ToString()));

            // Legend
            sb.Append("chxt=x,y&");
            //sb.Append(string.Format("chxl=0:|{0}|1:|{1}|&", chartLegend.Replace(",","|"), chartData.Replace(",","|") ));

            // Range
            sb.Append(string.Format("chxr=0,{0},{1}|1,0,{2}&", minX.ToString(), maxX.ToString(), maxY.ToString()));

            // zurückgeben
            return sb.ToString();
        }



        private string chartTypeToString(ChartTypes type)
        {
            switch (type)
            {
                case ChartTypes.Pie:
                    return "p3";
                case ChartTypes.Bar:
                    return "bvs";
                case ChartTypes.Line:
                    return "lc";
                default:
                    return "";
            }
        }


        private string chartLegend
        {
            get
            {
                string s0 = "";
                StringBuilder sbColumn0 = new StringBuilder();
                foreach (DataRow dr in dt.Rows)
                {
                    sbColumn0.Append(dr[0].ToString() + ",");
                }
                // letzte Komma abschneiden
                if (sbColumn0.ToString().Length > 0)
                {
                    s0 = sbColumn0.ToString().Substring(0, sbColumn0.ToString().Length - 1);
                }
                return s0;
            }
        }
        private string chartData
        {
            get
            {
                StringBuilder sbColumn1 = new StringBuilder();
                foreach (DataRow dr in dt.Rows)
                {
                    sbColumn1.Append(dr[1].ToString() + ",");
                }
                // letzte Komma abschneiden
                string s1 = sbColumn1.ToString().Substring(0, sbColumn1.ToString().Length - 1);

                return s1;
            }
        }

        public static string MakeSimpleUrl(string title, int maxY, string xData, string yData)
        {
            string s = string.Format("http://chart.apis.google.com/chart?chs=400x150&cht=ls&chco=0077CC&chm=B,E6F2FA,0,0,0&chtt={0}&chxt=y&chxr=0,0,{1}&chds=0,{1}&chls=1,0,0&chd=t:{2}&chl={3}", title, maxY.ToString(), yData.ToString(), xData.ToString());
            return s;
        }

    }
}
