/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ZKEACMS.Article.Extend
{
    public static class HtmlHelperExtend
    {
        public static IHtmlContent RawCount(this IHtmlHelper html, int count)
        {
            if (count < 1000)
            {
                return html.Raw(count);
            }
            return html.Raw($"{((double)count / 1000).ToString("F1")}k");
        }
    }
}
