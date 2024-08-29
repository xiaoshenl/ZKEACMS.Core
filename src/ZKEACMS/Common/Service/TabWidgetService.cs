/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Extend;
using Easy.RepositoryPattern;
using System.Collections.Generic;
using System.Linq;
using ZKEACMS.Common.Models;
using ZKEACMS.Extend;
using ZKEACMS.Widget;

namespace ZKEACMS.Common.Service
{
    public class TabWidgetService : SimpleWidgetService<TabWidget>
    {
        public TabWidgetService(IWidgetBasePartService widgetBasePartService, IApplicationContext applicationContext, CMSDbContext dbContext) :
            base(widgetBasePartService, applicationContext, dbContext)
        {
        }

        public override ServiceResult<TabWidget> Add(TabWidget item)
        {
            item.TabItems = item.TabItems.RemoveDeletedItems().ToList();
            return base.Add(item);
        }
        public override ServiceResult<TabWidget> Update(TabWidget item)
        {
            item.TabItems = item.TabItems.RemoveDeletedItems().ToList();
            return base.Update(item);
        }

        protected override IEnumerable<string> GetFilesInWidget(TabWidget widget)
        {
            return base.GetFilesInWidget(widget);
        }
    }
}