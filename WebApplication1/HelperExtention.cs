using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public static class HelperExtention
    {
        public static MvcHtmlString InjectebaleHelperFor(this HtmlHelper helper, string value)
        {
            return MvcHtmlString.Create(value);
        }
    }
}