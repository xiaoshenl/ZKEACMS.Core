/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Net.Mail;

namespace Easy.Notification
{
    public interface ISmtpProvider
    {
        SmtpClient GetSmtpClient();
        SmtpSetting GetSmtpSetting();
        SmtpClient GetSmtpClient(SmtpSetting smtpSetting);
    }
}
