using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            
            // async await syntax first introduced with C# 5 but it was not for the Main method
            // then in C# 7.1 they provided this feature so we should replace void with async Task
            // to make it work on the Main method
            
            
            string URI = "https://snapp.ir/";
            
            HttpClient request = new HttpClient();
            
            HttpResponseMessage response = await request.GetAsync(URI);
            
            Console.WriteLine($"Snapp's home page has {response.Content.Headers.ContentLength:N0} bytes.");
        }
    }
}