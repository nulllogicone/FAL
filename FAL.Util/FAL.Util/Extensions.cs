using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAL.Util
{
    public static class Extensions
    {
        public static string MakeHtmlLineBreaks(this string input)
        {
            return input.Replace(System.Environment.NewLine, "<br />");
        }

        public static string LastXCharacters(this string me, int count)
        {
            if (me.Length > count)
                me = me.Substring(me.Length - count, count);
            return me;
        }
    }
}
