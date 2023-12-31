﻿using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace PlaygroundDemo.Net.Emailing
{
    public class PlaygroundDemoSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public PlaygroundDemoSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}