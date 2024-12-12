namespace iterator;

class Program
{
    static void Main(string[] args)
    {
        var playlist = new Playlist();
        
        playlist.Add("Ariana Grande - Break Free");
        playlist.Add("Charlie XCX - 360");
        playlist.Add("Chappel Roan - Midnight");

        Console.WriteLine("Ordem padrão:");
        foreach (var song in playlist)
        {
            Console.WriteLine(song);
        }
        
        playlist.ToggleRandomOrder();
        Console.WriteLine("\nOrdem aleatória:");
        foreach (var song in playlist)
        {
            Console.WriteLine(song);
        }
    }
}