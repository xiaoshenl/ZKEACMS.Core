/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using ZKEACMS.Dashboard;

namespace ZKEACMS.Common.Service
{
    public class DashboardEventLogPartService : IDashboardPartDriveService
    {
        private readonly IEventViewerService _eventViewerService;
        public DashboardEventLogPartService(IEventViewerService eventViewerService)
        {
            _eventViewerService = eventViewerService;
        }
        public DashboardPart Create()
        {
            return new DashboardPart
            {
                Order = 0,
                ViewModel = _eventViewerService.Get(),
                ViewName = "Dashboard.ErrorLog"
            };
        }
    }
}
