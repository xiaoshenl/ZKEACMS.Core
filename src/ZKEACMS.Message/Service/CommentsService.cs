/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;
using ZKEACMS.Event;
using ZKEACMS.Message.Models;

namespace ZKEACMS.Message.Service
{
    public class CommentsService : ServiceBase<Comments, CMSDbContext>, ICommentsService
    {
        private readonly IEventManager _eventManager;
        public CommentsService(IApplicationContext applicationContext, CMSDbContext dbContext, IEventManager eventManager = null)
            : base(applicationContext, dbContext)
        {
            _eventManager = eventManager;
        }
        public override ServiceResult<Comments> Add(Comments item)
        {
            ServiceResult<Comments> result = base.Add(item);
            if (!result.HasViolation)
            {
                _eventManager.Trigger(Events.OnCommentsSubmitted, item);
            }
            return result;
        }
    }
}
