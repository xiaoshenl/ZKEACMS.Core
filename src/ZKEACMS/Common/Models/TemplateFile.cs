﻿/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;
using System;
using System.ComponentModel.DataAnnotations;
using ZKEACMS.Extend;

namespace ZKEACMS.Common.Models
{
    public class TemplateFile
    {
        [Key]
        public int Id { get; set; }

        public string ThemeName { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public string RelativePath { get; set; }
        public string Content { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public string ThemeViewsFolder { get; set; }
    }

    public class TemplateFileMetaData : ViewMetaData<TemplateFile>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.Id).AsHidden();
            ViewConfig(m => m.ThemeViewsFolder).AsHidden();
            ViewConfig(m => m.ThemeName).AsTextBox().ReadOnly().ShowInGrid().Order(1).Required();
            ViewConfig(m => m.Name).AsTextBox().ShowInGrid().Order(10).Required();
            ViewConfig(m => m.Path).AsHidden();
            ViewConfig(m => m.RelativePath).AsTextBox().ReadOnly().ShowInGrid().Order(20).Search(Easy.LINQ.Query.Operators.None).Required();
            ViewConfig(m => m.Content).AsTextArea().AsCodeEditor("razor").ShowInGrid(false).Order(30).Required();
            ViewConfig(m => m.LastUpdateTime).AsTextBox().FormatAsDateTime().ShowInGrid().ReadOnly().Order(100).Search(Easy.LINQ.Query.Operators.None);
        }
    }
}
