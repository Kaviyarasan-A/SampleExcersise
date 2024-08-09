using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace SampleExcersise 

{ 
    class Program
    {


        static void Main(string[] args)
        {

            // Console.WriteLine("Hi bro your project is executing!");

            //Smtp obj = new Smtp();
            //obj.Send();

            //ReadAndWrite obt = new ReadAndWrite();
            //obt.File();

            var serviceCollection = new ServiceCollection();

            IConfiguration configuration;
            configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
              .AddJsonFile("AppSettings.json")
              .Build();

            serviceCollection.AddSingleton<IConfiguration>(configuration);
            serviceCollection.AddSingleton<Test>();

            Smtpmail obj = new Smtpmail(configuration);
            obj.Send();
            obj.FileLog();




        }
    }
}
