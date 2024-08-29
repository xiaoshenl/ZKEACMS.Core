/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.SectionWidget.Models;

namespace ZKEACMS.SectionWidget.Service
{
    public interface ISectionGroupService : IService<SectionGroup>
    {
        SectionGroup GenerateContentFromConfig(SectionGroup group);
    }
}