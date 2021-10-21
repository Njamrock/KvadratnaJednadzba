using System;

namespace KvadratnaJednadzba
{
    class QuadraticEquation
    {
        public QuadraticEquation()
        {

        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A
        {
            get { return a; }
            set { this.a = value; }
        }

        public double B
        {
            get { return b; }
            set { this.b = value; }

        }

        public double C
        {
            get { return c; }
            set { this.c = value; }

        }

        public double Y(double x)
        {
            return this.a * x * x + this.b * x + this.c;
        }

        public double Discriminant
        {
            get { return this.b * this.b - 4 * this.a * this.c; }
        }

        public double[] Roots
        {
            get
            {
                double sqrtDisc = Math.Sqrt(this.Discriminant);
                return new double[] { (-this.b + sqrtDisc) / (2 * this.a), (-this.b - sqrtDisc) / (2 * this.a) };
            }
        }

        private double a;
        private double b;
        private double c;
    }
}
