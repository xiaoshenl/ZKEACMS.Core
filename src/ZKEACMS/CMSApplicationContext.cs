/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using ZKEACMS.Currency;
using ZKEACMS.Filter;
using ZKEACMS.Site;

namespace ZKEACMS
{
    public class CMSApplicationContext : ApplicationContext
    {

        private Uri _requestUrl;

        public CMSApplicationContext(IHttpContextAccessor httpContextAccessor) :
            base(httpContextAccessor)
        {
            HeaderPart = new List<IHtmlContent>();
            FooterPart = new List<IHtmlContent>();
            Styles = new List<string>();
            Scripts = new List<string>();
        }

        public Uri RequestUrl
        {
            get
            {
                if (_requestUrl == null)
                {
                    if (HttpContextAccessor.HttpContext != null)
                    {
                        _requestUrl = new Uri(HttpContextAccessor.HttpContext.Request.Path);
                    }
                }
                return _requestUrl;
            }
            set { _requestUrl = new Uri(value.AbsoluteUri); }
        }

        public string MapPath(string path)
        {
            if (HttpContextAccessor.HttpContext != null)
            {
                HostingEnvironment.MapPath(path);
            }
            return path;
        }

        public PageViewMode PageMode { get; set; }
        public bool IsDesignMode { get { return PageMode == PageViewMode.Design; } }
        public bool IsPreViewMode { get { return PageMode == PageViewMode.PreView; } }
        /// <summary>
        /// Append to html/head
        /// </summary>
        public List<IHtmlContent> HeaderPart { get; set; }
        /// <summary>
        /// Append the content before body close
        /// </summary>
        public List<IHtmlContent> FooterPart { get; set; }
        /// <summary>
        /// Append system styles to page footer
        /// </summary>
        public List<string> Styles { get; set; }
        /// <summary>
        /// Append system script to page footer
        /// </summary>
        public List<string> Scripts { get; set; }
        public bool OuterChainPicture { get { return Get<bool>(nameof(OuterChainPicture)); } }
        public bool EnableResponsiveDesign { get { return Get<bool>(nameof(EnableResponsiveDesign)); } }
        public SiteInformation SiteInformation { get { return Get<SiteInformation>(nameof(SiteInformation)); } }
        public CurrencyOption Currency { get { return Get<CurrencyOption>(nameof(Currency)); } }
    }
}
