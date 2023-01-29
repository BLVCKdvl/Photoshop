using System;

namespace MyPhotoshop
{
    public class GrayscaleFilter : PixelFilter
    {
        public override ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }

        public override Pixel ProcessPixel(Pixel original, double[] parameters)
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
