using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace SampleExcersise
{
    public class Smtp
       
    {
        public void Send()
        {
            SendEmail(GetUserName(), GetPassword());
            Console.ReadLine();
        }


        public static void SendEmail(string fromAddress, string password)
        {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(fromAddress, "xyrimgzrvhltvczw")

            };
            string subject = "Hii Sir";
            string body = $"I Am Kaviyarasan @{DateTime.UtcNow:F}";
            try
            {
                Console.WriteLine("sending email ");
                email.Send(fromAddress, ToAddress(), subject, body);
                Console.WriteLine("email sent ");
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e);
            }

        }
        public static string GetUserName()
        {
            return "kaviyarasanaruchamy@gmail.com";
        }
        public static string GetPassword()
        {
            return "Kavi0636@";
        }

        public static string ToAddress()
        {
            return "sureshkumar.duraisamy@anaiyaantechnologies.com";

        }
    }
}
