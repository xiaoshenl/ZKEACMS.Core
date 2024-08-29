/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;

namespace ZKEACMS.ExtendField
{
    public class ExtendFieldService : ServiceBase<ExtendFieldEntity, CMSDbContext>, IExtendFieldService
    {
        public ExtendFieldService(IApplicationContext applicationContext, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
        }
    }
}