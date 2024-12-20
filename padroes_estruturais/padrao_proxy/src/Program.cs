using System;

namespace ImageLoadingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("high_res_image.jpg");

            image.Display();

            image.Display();
        }
    }
}