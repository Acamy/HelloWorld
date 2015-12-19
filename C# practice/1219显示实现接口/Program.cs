using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1219显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.Fly();
            Bird bird = new Bird();
            bird.Fly();
        }
    }
    public class Bird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟类会飞");
        }
        /// <summary>
        /// 显示实现接口，前面不能加public访问修饰符，因为它只能使用类中默认的private修饰符
        /// </summary>
        void IFlyable.Fly()
        {
            Console.WriteLine("鸟类真的会飞哦");
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
}
