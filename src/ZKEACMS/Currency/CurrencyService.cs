/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ZKEACMS.Currency
{
    public class CurrencyService : ServiceBase<CurrencyEntry>, ICurrencyService
    {
        public CurrencyService(IApplicationContext applicationContext, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
        }

        public override IQueryable<CurrencyEntry> Get()
        {
            return CurrentDbSet.AsNoTracking();
        }
    }
}
