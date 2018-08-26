using System;
using System.Net.Mail;

namespace MonitoringApp
{
    class sendMail
    {

        public bool sendAlert(string Message, string toWho)
        {
            bool sendSuccess = false;
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("jaitheking4858@gmail.com");
                mail.To.Add(toWho);
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP email from Gmail";
                SmtpServer.Port = 587;
                //Enter the credentials
                SmtpServer.Credentials = new System.Net.NetworkCredential("email", "password");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                sendSuccess = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sendSuccess;
        }
    }
}
