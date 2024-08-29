/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.Extensions.Logging;
using System;
using ZKEACMS.Event;
using ZKEACMS.EventAction.Service;

namespace ZKEACMS.EventAction.ActionExecutor
{
    public sealed class EventActionEventHandler : IEventHandler
    {
        private readonly IEventActionService _eventActionService;
        private readonly IExecutorManager _executorManager;
        private readonly ILogger<EventActionEventHandler> _logger;

        public EventActionEventHandler(IEventActionService eventActionService,
            IExecutorManager executorManager,
            ILogger<EventActionEventHandler> logger)
        {
            _eventActionService = eventActionService;
            _executorManager = executorManager;
            _logger = logger;
        }

        public void Handle(object entity, EventArg e)
        {
            if (!_eventActionService.GetAllActivedActinosFromCache().TryGetValue(e.Name, out var actions)) return;

            foreach (var actionContent in actions)
            {
                if (actionContent.Actions == null) continue;

                //todo: Action with condition.
                //if (actionContent.Condition.IsNotNullAndWhiteSpace() && !_ruleManager.IsTrue(actionContent.Condition)) continue;

                foreach (var parsedAction in actionContent.Actions)
                {
                    var executor = _executorManager.CreateExecutor(parsedAction.Uses);
                    if (executor == null) continue;

                    try
                    {
                        executor.Execute(new Arguments(parsedAction.GetRendedWith(entity)), entity, e);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, ex.Message);
                    }
                }
            }
        }
    }
}
