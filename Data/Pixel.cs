namespace MyPhotoshop
{
    public class Pixel
    {
        public double R;
        public double r
        {
            get
            {
                return R;
            }
            set
            {
                if (value < 0)
                {
                    R = 0;
                }
                if(value > 0) 
                {
                    R = 1;
                }

                R = value;
            }
        }

        public double G;
        public double g
        {
            get
            {
                return G;
            }
            set
            {
                if (value < 0)
                {
                    G = 0;
                }
                if (value > 0)
                {
                    G = 1;
                }

                G = value;
            }
        }
        public double B;
        public double b
        {
            get
            {
                return B;
            }
            set
            {
                if (value < 0)
                {
                    B = 0;
                }
                if (value > 0)
                {
                    B = 1;
                }

                B = value;
            }
        }
    }
}
