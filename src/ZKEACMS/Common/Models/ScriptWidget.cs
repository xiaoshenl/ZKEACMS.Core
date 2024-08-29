/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Extend;
using ZKEACMS.MetaData;
using ZKEACMS.Widget;

namespace ZKEACMS.Common.Models
{
    [DataTable("ScriptWidget")]
    public class ScriptWidget : BasicWidget
    {
        public string Script { get; set; }
    }

    class ScriptWidgetMetaData : WidgetMetaData<ScriptWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.PartialView).AsHidden();
            ViewConfig(m => m.Title).AsHidden();
            ViewConfig(m => m.StyleClass).AsHidden();
            ViewConfig(m => m.Script).AsTextArea().AsCodeEditor("javascript").Order(NextOrder()).Required();
        }
    }
}