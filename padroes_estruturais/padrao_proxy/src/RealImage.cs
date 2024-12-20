public class RealImage : IImage
{
    private string _fileName;

    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadImage();
    }

    private void LoadImage()
    {
        System.Console.WriteLine($"Loading image: {_fileName}");
    }

    public void Display()
    {
        System.Console.WriteLine($"Displaying image: {_fileName}");
    }
}