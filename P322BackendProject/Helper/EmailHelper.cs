using System.Net.Mail;

namespace PustokP322.Helper
{
    public class EmailHelper
    {

        private readonly string _privateEmail;
        private readonly string _privatePassword;

        public EmailHelper(string privateEmail, string privatePassword)
        {
            _privateEmail = privateEmail;
            _privatePassword = privatePassword;
        }




        public bool SendEmail(string UserEmail , string ConfirmationLink)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_privateEmail);
            mailMessage.To.Add(new MailAddress(UserEmail));

            mailMessage.Subject = "Confirm email";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = ConfirmationLink;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(_privateEmail, _privatePassword);
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Port = 587;

            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (System.Exception)
            {

                
            }

            return false;
        }

    }
}
