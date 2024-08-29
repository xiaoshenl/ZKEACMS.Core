/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;
using ZKEACMS.SectionWidget.Models;

namespace ZKEACMS.SectionWidget.Service
{
    public class SectionTemplateService : ServiceBase<SectionTemplate, CMSDbContext>, ISectionTemplateService
    {
        public SectionTemplateService(IApplicationContext applicationContext, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
        }

    }
}