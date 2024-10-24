namespace integration;

using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    
    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        try
        {
            string url = "http://localhost:3000/alunos";
            
            HttpResponseMessage response = await client.GetAsync(url);
            
            response.EnsureSuccessStatusCode();
            
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);

        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("erro");
        }
    }
    
}