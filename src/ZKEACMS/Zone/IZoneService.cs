/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using System.Collections.Generic;
using ZKEACMS.Page;

namespace ZKEACMS.Zone
{
    public interface IZoneService : IService<ZoneEntity>
    {
        IEnumerable<ZoneEntity> GetByPage(PageEntity page);
        IEnumerable<ZoneEntity> GetByLayoutId(string layoutId);
        void RemoveCache(string pageId);
        void ClearCache();
    }
}