using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0104.委托
{
    //声明一个委托
    public delegate void DelSayHi(string name);
    public delegate string DelProStr(string name);
    public delegate void DelSayHello(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //DelSayHi del = new DelSayHi(SayHiChinese);
            //DelSayHi del = SayHiEnglish;//new DelSayHi(SayHiEnglish);
            //Test("张三", del);
            Test("张三",SayHiEnglish);
            string[] names = { "abcDE", "fgHjLMN", "XYZ" };
            //匿名函数
            ProStr(names, delegate(string name)
            {
                return "\"" + name + "\"";
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //DelSayHello del = delegate(string name)
            //{
            //    Console.WriteLine("你好"+name);
            //};
            //del("张三");

            //lamda表达式 =>
            DelSayHello del = (string name) => { Console.WriteLine("你好1" + name); };
            del("张三");
        }
        public static void ProStr(string[] name,DelProStr del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }
        public static void Test(string name,DelSayHi del)
        {
            //调用
            del(name);
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("你吃了吗" + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you"+ name);
        }
        
        
        
    }
}
