namespace integration;

using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    
    private static readonly HttpClient Client = new();

    static async Task Main(string[] args)
    {
        try
        {
            Client.BaseAddress = new Uri("http://localhost:3000/alunos");
            
            HttpResponseMessage response = await Client.GetAsync(Client.BaseAddress);
            
            response.EnsureSuccessStatusCode();
            
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);

        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("erro");
        }
    }
    
}