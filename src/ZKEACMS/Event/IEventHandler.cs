/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS.Event
{
    public interface IEventHandler
    {
        void Handle(object entity, EventArg e);
    }
}
