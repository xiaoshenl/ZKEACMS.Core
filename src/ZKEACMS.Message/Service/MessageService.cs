/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Constant;
using Easy.RepositoryPattern;
using ZKEACMS.Event;
using ZKEACMS.Message.Models;

namespace ZKEACMS.Message.Service
{
    public class MessageService : ServiceBase<MessageEntity, CMSDbContext>, IMessageService
    {
        private readonly IEventManager _eventManager;
        public MessageService(IApplicationContext applicationContext, CMSDbContext dbContext, IEventManager eventManager)
            : base(applicationContext, dbContext)
        {
            _eventManager = eventManager;
        }
        public override ServiceResult<MessageEntity> Add(MessageEntity item)
        {
            ServiceResult<MessageEntity> result = base.Add(item);
            if (!result.HasViolation && item.ActionType == ActionType.Continue)
            {
                _eventManager.Trigger(Events.OnMessageSubmitted, item);
            }
            return result;
        }
    }
}