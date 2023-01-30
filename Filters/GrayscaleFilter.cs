using System;

namespace MyPhotoshop
{
    public class GrayscaleFilter : PixelFilter
    {
        public GrayscaleFilter() : base(new EmptyParameters()) { }

        public override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            var lightness = original.R * 0.2126 + original.G * 0.7152 + original.B * 0.0722;
            return new Pixel(lightness, lightness, lightness);
        }

        public override string ToString()
        {
            return "черно/белый формат";
        }
    }
}
