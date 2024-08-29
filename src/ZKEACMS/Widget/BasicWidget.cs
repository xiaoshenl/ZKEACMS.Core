/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Constant;
using Easy.RepositoryPattern;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZKEACMS.Widget
{
    [DataTable("CMS_WidgetBase")]
    public sealed class WidgetBasePart : WidgetBase
    {

    }
    public class BasicWidget : WidgetBase
    {
        [Key]
        public override string ID
        {
            get; set;
        }
        [NotMapped]
        public override string AssemblyName
        {
            get; set;
        }
        [NotMapped]
        public override string FormView
        {
            get; set;
        }
        [NotMapped]
        public override bool IsSystem
        {
            get; set;
        }
        [NotMapped]
        public override bool IsTemplate
        {
            get; set;
        }
        [NotMapped]
        public override string LayoutId
        {
            get; set;
        }
        [NotMapped]
        public override string PageId
        {
            get; set;
        }
        [NotMapped]
        public override int? RuleID
        {
            get; set;
        }
        [NotMapped]
        public override string PartialView
        {
            get; set;
        }
        [NotMapped]
        public override int? Position
        {
            get; set;
        }
        [NotMapped]
        public override string ServiceTypeName
        {
            get; set;
        }
        [NotMapped]
        public override string StyleClass
        {
            get; set;
        }
        [NotMapped]
        public override string Thumbnail
        {
            get; set;
        }
        [NotMapped]
        public override string ViewModelTypeName
        {
            get; set;
        }
        [NotMapped]
        public override string WidgetName
        {
            get; set;
        }
        [NotMapped]
        public override string ZoneId
        {
            get; set;
        }
        [NotMapped]
        public override string CreateBy
        {
            get; set;
        }
        [NotMapped]
        public override string CreatebyName
        {
            get; set;
        }
        [NotMapped]
        public override DateTime? CreateDate
        {
            get; set;
        }
        [NotMapped]
        public override string Description
        {
            get; set;
        }
        [NotMapped]
        public override string LastUpdateBy
        {
            get; set;
        }
        [NotMapped]
        public override string LastUpdateByName
        {
            get; set;
        }
        [NotMapped]
        public override DateTime? LastUpdateDate
        {
            get; set;
        }
        [NotMapped]
        public override int? Status
        {
            get; set;
        }
        [NotMapped]
        public override string Title
        {
            get; set;
        }
        [NotMapped]
        public override string ExtendData
        {
            get; set;
        }
    }

    public class SimpleWidgetBase : BasicWidget
    {
        [Key, JsonIgnore]
        public override string ID
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string AssemblyName
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string FormView
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override bool IsSystem
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override bool IsTemplate
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string LayoutId
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string PageId
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string PartialView
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override int? Position
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string ServiceTypeName
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string StyleClass
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string Thumbnail
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string ViewModelTypeName
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string WidgetName
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string ZoneId
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string CreateBy
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string CreatebyName
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override DateTime? CreateDate
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string Description
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string LastUpdateBy
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string LastUpdateByName
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override DateTime? LastUpdateDate
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override int? Status
        {
            get; set;
        }
        [NotMapped, JsonIgnore]
        public override string Title
        {
            get; set;
        }

        [NotMapped, JsonIgnore]
        public override string ExtendData
        {
            get; set;
        }

        [NotMapped, JsonIgnore]
        public override ActionType? ActionType
        {
            get; set;
        }

        [NotMapped, JsonIgnore]
        public override int? RuleID
        {
            get; set;
        }
    }

}
