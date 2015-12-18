using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密封类
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Person
        {

        }
        public sealed class Student:Person
        {
            //密封类可以继承其它类，但不能被继承
        }
    }
}
