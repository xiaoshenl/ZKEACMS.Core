/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.SectionWidget.Models;

namespace ZKEACMS.SectionWidget.Service
{
    public interface ISectionContentProviderService : IService<SectionContentBasePart>
    {
        void Add(SectionContent content);
        void Update(SectionContent content);
        SectionContent GetContent(string contentId);
        SectionContent FillContent(SectionContent content);
        void SaveSort(SectionContent content);
    }
}