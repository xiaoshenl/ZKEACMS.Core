/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */


using System.Threading;
using System.Threading.Tasks;

namespace Easy.Notification.Queue
{
    public interface IEmailQueue
    {
        Task Send(EmailContext emailMessage);
        Task<EmailContext> Receive(CancellationToken cancellationToken = default);
    }
}
