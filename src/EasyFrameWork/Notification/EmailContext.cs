/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace Easy.Notification
{
    public class EmailContext
    {
        public EmailContext(EmailMessage emailMessage, SmtpSetting smtpSetting)
        {
            EmailMessage = emailMessage;
            SmtpSetting = smtpSetting;
        }
        public EmailMessage EmailMessage { get; set; }
        public SmtpSetting SmtpSetting { get; set; }
    }
}
