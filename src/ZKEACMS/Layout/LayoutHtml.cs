/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Models;
using Easy.RepositoryPattern;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ZKEACMS.Layout
{
    [DataTable("CMS_LayoutHtml")]
    public class LayoutHtml : EditorEntity
    {
        [Key]
        public int LayoutHtmlId { get; set; }
        public string LayoutId { get; set; }
        public string PageId { get; set; }
        public string Html { get; set; }

        public string NoStyleHtml
        {
            get { return CustomRegex.CssStyle().Replace(Html, string.Empty); }
        }
    }
    public class LayoutHtmlCollection : Collection<LayoutHtml>
    {

    }

}
