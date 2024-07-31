using System;

namespace SampleExcersise 

{ 
    class Program
    {
        

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hi bro your project is executing!");

            Smtp obj = new Smtp();
            obj.Send();
            


        }
    }
}
