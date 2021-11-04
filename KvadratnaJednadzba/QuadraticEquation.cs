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

        public Complex.Complex[] Roots
        {
            get
            {
                if (a == 0)
                {
                    //return new[] {new Complex.Complex(-this.c / this.b, 0), -this.c / this.b }
                }

                Complex.Complex[] sqrtDisc = Complex.Complex.Sqrt(this.Discriminant);
                Complex.Complex realPart = (new Complex.Complex(-this.b, 0)) / (new Complex.Complex(2 * this.a, 0));
                sqrtDisc[0] /= (new Complex.Complex(2 * this.a, 0));
                sqrtDisc[1] = sqrtDisc[1] / (new Complex.Complex(2 * this.a, 0));

                return new[] { realPart + sqrtDisc[0], realPart + sqrtDisc[1] };
            }
        }

        private double a;
        private double b;
        private double c;
    }
}
