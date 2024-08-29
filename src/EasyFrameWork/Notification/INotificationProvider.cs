/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;

namespace Easy.Notification
{
    public interface INotificationProvider
    {
        Type SupportType { get; }
        void Send(Message notice);
    }
}
