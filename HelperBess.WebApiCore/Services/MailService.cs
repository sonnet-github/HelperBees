//using MimeKit;
using System.IO;
using System.Threading.Tasks;
//using MailKit.Net.Smtp;
//using MailKit.Security;
using Microsoft.Extensions.Options;
using HelperBess.WebApiCore.Models;
using System;
using System.Net.Mail;

namespace HelperBess.WebApiCore.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        //public async Task SendEmailAsync(MailRequest mailRequest)
        //{
        //    var email = new MimeMessage();
        //    //email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
        //    email.Sender = MailboxAddress.Parse("raymondm@sonnet.digital");
        //    email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
        //    email.Subject = mailRequest.Subject;
        //    var builder = new BodyBuilder();
        //    if (mailRequest.Attachments != null)
        //    {
        //        byte[] fileBytes;
        //        foreach (var file in mailRequest.Attachments)
        //        {
        //            if (file.Length > 0)
        //            {
        //                using (var ms = new MemoryStream())
        //                {
        //                    file.CopyTo(ms);
        //                    fileBytes = ms.ToArray();
        //                }
        //                builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
        //            }
        //        }
        //    }
        //    builder.HtmlBody = mailRequest.Body;
        //    email.Body = builder.ToMessageBody();
        //    using var smtp = new SmtpClient();
        //    smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
        //    smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
        //    await smtp.SendAsync(email);
        //    smtp.Disconnect(true);
        //}

        public async Task SendEmailAsync(MailRequest mailRequest)
        {           
            try
            {
                MailMessage mailMsg = new MailMessage();

                // From
                mailMsg.From = new MailAddress(_mailSettings.Sender, _mailSettings.Sender);

                // To
                mailMsg.To.Add(new MailAddress(mailRequest.ToEmail, mailRequest.ToEmail));             

                // Multiple Attachment
                if (mailRequest.Attachments != null)
                {
                    byte[] fileBytes;
                    foreach (var file in mailRequest.Attachments)
                    {
                        if (file.Length > 0)
                        {
                            using (var ms = new MemoryStream())
                            {
                                file.CopyTo(ms);
                                fileBytes = ms.ToArray();
                            }
                            Attachment att = new Attachment(new MemoryStream(fileBytes), file.FileName);

                            mailMsg.Attachments.Add(att);
                        }
                    }
                }

                //Subject
                mailMsg.Subject = mailRequest.Subject;

                mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(mailRequest.Body, null, System.Net.Mime.MediaTypeNames.Text.Html));

                SmtpClient smtpClient = new SmtpClient(_mailSettings.Host, Convert.ToInt32(_mailSettings.Port));

                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(_mailSettings.Mail, _mailSettings.Password);
                smtpClient.Credentials = credentials;
               
                await smtpClient.SendMailAsync(mailMsg);                               
            }
            catch (Exception e)
            {
            }            
        }
    }
}
