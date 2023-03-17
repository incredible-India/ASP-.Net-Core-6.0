// See https://aka.ms/new-console-template for more information

using System;
using System.Threading.Tasks;
using System.Net.Http;
namespace myapp{

class Program
    {
        static void Main(String[] args)
        {
            CallApi();
            Console.ReadLine();

       

        }


        public async  static Task CallApi()
        {
            var client = new HttpClient();
            var resp = await client.GetAsync("https://deeksha.azurewebsites.net/weatherforecast");
            var result = await resp.Content.ReadAsStringAsync();

            await Console.Out.WriteLineAsync(result);
        }
    }

}
