/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS.Event
{
    public interface IEventManager
    {
        void Trigger(string eventName, object entity);
        void Trigger(EventArg e, object entity);
    }
}
