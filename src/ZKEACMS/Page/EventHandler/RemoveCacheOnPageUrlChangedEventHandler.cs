/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Cache;
using ZKEACMS.Event;

namespace ZKEACMS.Page
{
    public sealed class RemoveCacheOnPageUrlChangedEventHandler : IEventHandler
    {
        private readonly ISignals _signals;

        public RemoveCacheOnPageUrlChangedEventHandler(ISignals signals)
        {
            _signals = signals;
        }

        public void Handle(object entity, EventArg e)
        {
            PageEntity page = entity as PageEntity;
            if (page != null && e.Data != null)
            {
                _signals.Trigger(CacheSignals.PageUrlChanged);
                _signals.Trigger(CacheSignals.PageWidgetChanged);
                _signals.Trigger(CacheSignals.PageZoneChanged);
            }
        }
    }
}
