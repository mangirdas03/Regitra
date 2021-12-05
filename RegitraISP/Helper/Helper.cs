using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RegitraISP.Helper
{
    public static class CustomHTMLHelper
    {
        public static string FixDateFormat(this IHtmlHelper htmlHelper, DateTime date)
        {
            return date.ToShortDateString();
        }
    }
}
