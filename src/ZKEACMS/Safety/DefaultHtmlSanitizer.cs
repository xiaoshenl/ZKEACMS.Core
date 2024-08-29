/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Extend;
using Ganss.Xss;

namespace ZKEACMS.Safety
{
    public class DefaultHtmlSanitizer : IHtmlSanitizer
    {
        private static HtmlSanitizer _sanitizer;
        static DefaultHtmlSanitizer()
        {
            _sanitizer = new HtmlSanitizer();
            _sanitizer.AllowedSchemes.Add("mailto");
            _sanitizer.AllowedAttributes.Add("class");
        }

        public string Sanitize(string html)
        {
            if (html.IsNullOrEmpty()) return html;

            return _sanitizer.Sanitize(html);
        }
    }
}
