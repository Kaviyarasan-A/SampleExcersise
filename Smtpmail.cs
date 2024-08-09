using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SampleExcersise
{
    class Smtpmail

    {
        private readonly IConfiguration configuration;

        public Smtpmail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void FileLog()
        {
            string file = $"File_{DateTime.Now.ToString("yyyy-mm-dd")}.txt";
            try
            {
                Send();
                StreamWriter sw = new StreamWriter($"D:{file}.txt", false);

                sw.WriteLine($"Sucessfully sent Mail in {DateTime.Now.ToString("yyyy-mm-dd")}");
                sw.Close();
            }
            catch (Exception e)
            {
                StreamWriter sw1 = new StreamWriter($"D:{file}.txt", false);
                sw1.WriteLine(e.StackTrace);
                sw1.Close();
            }
        }

        public void Send()
        {
            SendEmail(GetUserName(), GetPassword());
            Console.ReadLine();
        }


        public  void SendEmail(string fromAddress, string password)
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
            string body = "$ obj.File(); @{DateTime.UtcNow:F}";


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
        public  string GetUserName()
        {
            var dataFromJsonFile = configuration.GetSection("FromAddress").Value;
            return dataFromJsonFile;
        }
        public static string GetPassword()
        {
            return "Kavi0636@";
        }

        public  string ToAddress()
        {
            var dataFromJsonFile1 = configuration.GetSection("ToAddress").Value;

            return dataFromJsonFile1;

        }
    }
}
