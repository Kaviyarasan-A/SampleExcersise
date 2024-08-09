using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExcersise
{
    public class Test
    {
        private readonly IConfiguration configuration;

        

        public Test(IConfiguration configuration)
            {
                this.configuration = configuration;
            }
        

            public void TestMethod()
            {
                var dataFromJsonFile = configuration.GetSection("FromAddress").Value;
                Console.WriteLine(dataFromJsonFile);
                var dataFromJsonFile1 = configuration.GetSection("ToAddress").Value;
                Console.WriteLine(dataFromJsonFile1);

                
            }

        

    }
}
