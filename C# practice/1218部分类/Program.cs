using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1218部分类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Person
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
        }
        public partial class Person
        {
            public Person(string name)
            {
                this._name = name;
            }
        }
    }
}
