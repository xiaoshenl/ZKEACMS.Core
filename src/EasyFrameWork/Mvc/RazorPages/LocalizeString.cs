/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Extend;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Text.Encodings.Web;

namespace Easy.Mvc.RazorPages
{
    public class LocalizeString : IHtmlContent
    {
        public LocalizeString(string content, HttpContext httpContext)
        {
            Content = content;
            _httpContext = httpContext;
        }
        public LocalizeString(string content, string cultureCode, HttpContext httpContext)
        {
            Content = content;
            CultureCode = cultureCode;
            _httpContext = httpContext;
        }
        private string _translatedContent;
        public string Content { get; set; }


        public string CultureCode { get; set; }
        public string Text { get { return Get(); } }
        private HttpContext _httpContext;
        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            writer.Write(Get());
        }

        private string Get()
        {
            if (_translatedContent.IsNotNullAndWhiteSpace())
            {
                return _translatedContent;
            }
            var localize = _httpContext.RequestServices.GetService<ILocalize>();
            if (CultureCode.IsNotNullAndWhiteSpace())
            {
                _translatedContent = localize.Get(Content, CultureCode);
            }
            else
            {
                _translatedContent = localize.Get(Content);
            }
            return _translatedContent;
        }

        public override string ToString()
        {
            return this.Get();
        }
    }
}
