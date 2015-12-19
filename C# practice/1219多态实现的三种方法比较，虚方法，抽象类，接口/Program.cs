using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1219多态实现的三种方法比较_虚方法_抽象类_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子会游泳，木头鸭子不会游泳，橡皮甲子会游泳
            ISwimming swim = new MuDuck();//XPDuck,RealDuck
            swim.Swim();

        }
    }
    public class RealDuck:ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("真的鸭子靠翅膀游泳");
        }
        
    }
    public class MuDuck:ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("木鸭子不会游泳");
        }
    }
    public class XPDuck:ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("橡皮鸭子飘着游泳");
        }
    }
    public interface ISwimming
    {
        void Swim();
    }
}

