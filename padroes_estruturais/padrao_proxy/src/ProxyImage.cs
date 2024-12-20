using System;

public class ProxyImage : IImage
{
    private RealImage _realImage;
    private string _imageFileName;

    public ProxyImage(string imageFileName)
    {
        _imageFileName = imageFileName;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_imageFileName);
        }
        _realImage.Display();
    }
}