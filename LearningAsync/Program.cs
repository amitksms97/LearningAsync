using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File");
            Download();
            Console.ReadLine(); //To type 
        }

        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://rouxacademy.com");
            Console.WriteLine("Download Comple" + data);
        }
    }
}
    //class Network // imaginary external network download
    //    {
    //        static public Task Download()
    //        {
    //            return Task.Run(() => Thread.Sleep(3000));
    //        }
    //    }
    //}
