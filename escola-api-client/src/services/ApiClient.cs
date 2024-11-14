namespace escola_api_client.services;

public class ApiClient
{
    private static HttpClient? _clientInstance;
    
    private ApiClient() {}

    public static HttpClient GetInstance()
    {
        if (_clientInstance == null)
        {
            _clientInstance = new HttpClient();
            _clientInstance.BaseAddress = new Uri("http://localhost:3000/");
        }
        
        return _clientInstance;
    }
}