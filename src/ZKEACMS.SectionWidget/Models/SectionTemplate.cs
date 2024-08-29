/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Models;
using Easy.RepositoryPattern;
using System.ComponentModel.DataAnnotations;

namespace ZKEACMS.SectionWidget.Models
{
    [DataTable("SectionTemplate")]
    public class SectionTemplate : EditorEntity
    {
        [Key]
        public string TemplateName { get; set; }
        public string Thumbnail { get; set; }
        public string ExampleData { get; set; }
    }


}