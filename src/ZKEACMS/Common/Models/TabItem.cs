/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;
using Easy.Models;

namespace ZKEACMS.Common.Models
{
    public class TabItem : EditorEntity
    {
    }
    class TabItemMetaData : ViewMetaData<TabItem>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.Description).AsTextArea().AddClass(StringKeys.DynamicHtmlEditorClass);
        }
    }

}
