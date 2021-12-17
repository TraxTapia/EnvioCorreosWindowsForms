using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace EnviarCorreosWeb
{
   public class Correo
    {
        public string para;
        public string asunto;
        public string mensaje;

        public void  endMail(String para, String asunto, string mensaje)
        {

            string result = string.Empty;
            //if (String.IsNullOrEmpty(email))
            //    return;
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(para);
                mail.From = new MailAddress("testtapia1227@gmail.com");
                mail.Subject = asunto;

                mail.Body = mensaje;

                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("testtapia1227@gmail.com", "admin@1234"); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ocurrio un error " + ex.Message);
            }
        }


    }
}
