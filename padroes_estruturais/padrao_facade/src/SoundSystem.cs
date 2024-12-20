public class SoundSystem
{
    public void On()
    {
        Console.WriteLine("Sound system is on.");
    }

    public void Off()
    {
        Console.WriteLine("Sound system is off.");
    }

    public void SetVolume(int volume)
    {
        Console.WriteLine($"Sound system volume set to {volume}.");
    }
}