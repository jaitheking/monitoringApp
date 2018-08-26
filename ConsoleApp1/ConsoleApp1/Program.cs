using System;
using System.Threading;

namespace MonitoringApp
{
    public static class Program
    {
        static sendMail sm = new sendMail();
        public static void Main(string[] args)
        {

            Console.WriteLine("Monitoring Service starting...");
            //Create a Timer 
            Timer timer = startMonitor();
            //Wait for the user to hit <Enter>
            Console.ReadLine();
            Console.WriteLine("Please enter a key once");
            timer.Dispose();



        }

        public static Timer startMonitor()
        {
           Timer t= new Timer(TimerCallback, null, 0, 5000);
            return t;
        }

        private static void TimerCallback(Object o)
        {
            Console.WriteLine(DateTime.Now + ": <Monitoring Start>");
            sm.sendAlert("Test Alert","jaitheking4858@gmail.com")
            Console.WriteLine("Email sent");

            //Force a garbage collection to occur 
            GC.Collect();
        }


        


    }
}
