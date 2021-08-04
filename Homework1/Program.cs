using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await RunRequests("https://jsonplaceholder.typicode.com/posts/", 4, 13);
        }

        static async Task RunRequests(string baseUrl, int fromId, int toId)
        {
            var dir = Directory.CreateDirectory(@"C:\Geekbrains\");
            var path = $"{dir.FullName}requests_{DateTime.Now:yyyy_MM_dd_hh_mm_ss}.txt";
            Console.WriteLine($"Saved path: {path}");
            Console.WriteLine("Requests starting...");

            await using var file = new StreamWriter(path);
            for (int i = fromId; i <= toId; i++)
            {
                try
                {
                    var client = new HttpClient();
                    var response = await client.GetAsync(baseUrl + i);
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    responseBody += '\n';
                    Console.WriteLine(responseBody);
                    await file.WriteLineAsync(responseBody);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }

            Console.WriteLine("Requests completed.");
        }
    }
}
