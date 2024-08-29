/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Constant;
using Easy.Extend;
using Easy.RepositoryPattern;
using Microsoft.EntityFrameworkCore;
using ZKEACMS.Common.Models;

namespace ZKEACMS.Common.Service
{
    public class CarouselItemService : ServiceBase<CarouselItemEntity, CMSDbContext>, ICarouselItemService
    {
        public CarouselItemService(IApplicationContext applicationContext, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
        }
        public override DbSet<CarouselItemEntity> CurrentDbSet => DbContext.CarouselItem;

        public override ServiceResult<CarouselItemEntity> Add(CarouselItemEntity item)
        {
            if (!item.ActionType.HasFlag(ActionType.UnAttach))
            {
                return base.Add(item);
            }
            return new ServiceResult<CarouselItemEntity>();
        }
        public override ServiceResult<CarouselItemEntity> Update(CarouselItemEntity item)
        {
            if (item.ActionType.HasFlag(ActionType.Update))
            {
                return base.Update(item);
            }
            else if (item.ActionType.HasFlag(ActionType.Create))
            {
                return base.Add(item);
            }
            else if (item.ActionType.HasFlag(ActionType.Delete))
            {
                if (item.ID > 0)
                {
                    Remove(item);
                }
            }
            return new ServiceResult<CarouselItemEntity>();
        }

        public override ServiceResult<CarouselItemEntity> UpdateRange(params CarouselItemEntity[] items)
        {
            items.Each(m => Update(m));
            return new ServiceResult<CarouselItemEntity>();
        }
    }
}