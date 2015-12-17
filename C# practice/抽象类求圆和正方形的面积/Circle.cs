using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类求圆和正方形的面积
{
    public class Circle:Shape
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }
        public Circle(double r)
        {
            this.R = r;
        }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }
}
