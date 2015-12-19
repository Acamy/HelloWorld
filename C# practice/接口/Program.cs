using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口就是一个规范，能力。
            //IFlyable f = new Bird();
            //f.Fly();
        }
    }
    //public interface IFlyable
    //{
    //    void Fly();
    //}
    
    //public class Person:IFlyable
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("人在飞");
    //    }
    //}

    //public class Bird:IFlyable
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("鸟在飞");
    //    }
        
    //}
    //接口只能继承于接口，而类可继承于接口
    public interface M1
    {
        void Test1();
    }
    public interface M2
    {
        void Test2();
    }
    public interface M3
    {
        void Test3();
    }
    public interface SuperInterface:M1,M2,M3
    {

    }
    public class Car : SuperInterface
    {
        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }


    

   
    //public interface IKoulanable
    //{
    //    //接口中只能有方法，属性，索引器，事件，不能有“字段”和构造函数
    //    //接口中的成员不允许添加访问修饰符，默认就是public
    //    //接口中的成员不能有定义
    //    //接口中不能包含字段，字段是用来存数据的，用类来存
    //    //接口不能被实例化
    //    void KouLan();
    //    string Name//能有自动属性
    //    {
    //        get;
    //        set;
    //    }
    //}
    //public class NBAPlayer : Person
    //{
    //    public void KouLan()
    //    {
    //        Console.WriteLine("我可以扣篮");
    //    }
    //}
    //public class Student : Person, IKoulanable
    //{
    //    public void KouLan()
    //    {
    //        Console.WriteLine("我也可以扣篮");
    //    }
    //}
}
