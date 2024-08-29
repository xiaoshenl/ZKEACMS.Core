/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using ZKEACMS.MetaData;
using ZKEACMS.Widget;

namespace ZKEACMS.Common.Models
{
    public class BreadcrumbWidget : SimpleWidgetBase
    {
    }

    class BreadcrumbWidgetMetaData : WidgetMetaData<BreadcrumbWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.Title).AsHidden();
        }
    }
}