using System;

namespace MyPhotoshop
{
    public class GrayscaleFilter : IFilter
    {
        public ParameterInfo[] GetParameters()
        {
            return new[]
            {
                new ParameterInfo { Name="Коэффициент", MaxValue=0, MinValue=0, Increment=0.1, DefaultValue=1 }
            };
        }

        public override string ToString()
        {
            return "черно/белый формат";
        }

        public Photo Process(Photo original, double[] parameters)
        {
            var result = new Photo(original.width, original.height);

            for (int x = 0; x < result.width; x++)
            {
                for (int y = 0; y < result.height; y++)
                {
                    result[x, y] = new Pixel
                    {
                        R = original[x, y].R,
                        G = original[x, y].R,
                        B = original[x, y].R
                    };
                }
            }

            return result;
        }
    }
}
