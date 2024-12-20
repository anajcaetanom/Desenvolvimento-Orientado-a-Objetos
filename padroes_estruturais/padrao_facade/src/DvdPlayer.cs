public class DvdPlayer
{
    private string movie;

    public void On()
    {
        Console.WriteLine("DVD Player is on.");
    }

    public void Off()
    {
        Console.WriteLine("DVD Player is off.");
    }

    public void SetMovie(string movie)
    {
        this.movie = movie;
        Console.WriteLine($"Movie set to: {movie}");
    }

    public void Play()
    {
        Console.WriteLine($"Playing movie: {movie}");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping movie.");
    }
}