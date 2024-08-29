/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Mvc;
using ZKEACMS.Layout;

namespace ZKEACMS.Widget
{
    public class WidgetDisplayContext
    {
        public LayoutEntity PageLayout { get; set; }
        public WidgetBase Widget { get; set; }
        public ActionContext ActionContext { get; set; }
        public object FormModel { get; set; }
    }
}
