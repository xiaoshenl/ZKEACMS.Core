/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using ZKEACMS.SiteSearch.Models;
using ZKEACMS.Widget;

namespace ZKEACMS.SiteSearch.Service
{
    public class SiteSearchWidgetService : SimpleWidgetService<SiteSearchWidget>
    {
        public SiteSearchWidgetService(IWidgetBasePartService widgetBasePartService, IApplicationContext applicationContext, CMSDbContext dbContext)
            : base(widgetBasePartService, applicationContext, dbContext)
        {
        }
    }
}
