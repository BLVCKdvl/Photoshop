﻿using System;

namespace MyPhotoshop
{
    public struct Pixel
    {
        public Pixel(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public double Check(double value)
        {
            if (value < 0 || value > 1)
                throw new ArgumentException();
            return value;
        }

        public static double Trim(double value) => (value < 0) ? 0 : (value > 1) ? 1 : value;

        private double r;
        public double R
        {
            get { return r; }
            set
            {
                r = Check(value);
            }
        }

        private double g;
        public double G
        {
            get { return g; }
            set
            {
                g = Check(value);
            }
        }
        private double b;
        public double B
        {
            get { return b; }
            set
            {
                b = Check(value);
            }
        }
    }
}
