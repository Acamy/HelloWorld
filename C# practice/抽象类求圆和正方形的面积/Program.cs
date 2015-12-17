using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类求圆和正方形的面积
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Square(2,3);
            Console.WriteLine("面积是：{0}",s.GetArea());
            Console.WriteLine("周长是:{0}", s.GetPerimeter());
        }
    }
}
