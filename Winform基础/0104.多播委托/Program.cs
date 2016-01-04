using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0104.多播委托
{
    public delegate void DelTest();
    class Program
    {
        static void Main(string[] args)
        {
            DelTest del = T1;
            del += T2;
            del += T3;
            del -= T2;
            del();
        }
        public static void T1()
        {
            Console.WriteLine("我是T1");
        }
        public static void T2()
        {
            Console.WriteLine("我是T2");
        }
        public static void T3()
        {
            Console.WriteLine("我是T3");
        }
    }
}
