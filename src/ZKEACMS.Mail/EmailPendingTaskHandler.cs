using Easy.Notification;
using Easy.RepositoryPattern;
using System.Threading.Tasks;
using ZKEACMS.PendingTask;

namespace ZKEACMS.Mail
{
    public class EmailPendingTaskHandler : PendingTaskHandler<EmailContext>
    {
        public const string Name = "EmailPendingTaskHandler";
        private readonly IEmailNotification _emailNotification;

        public EmailPendingTaskHandler(IEmailNotification emailNotification)
        {
            _emailNotification = emailNotification;
        }

        public override async Task<ServiceResult<string>> ExecuteAsync(object context)
        {
            await _emailNotification.SendEmailAsync(context as EmailContext);
            return new ServiceResult<string>();
        }
    }
}
