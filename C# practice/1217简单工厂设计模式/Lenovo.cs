using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1217简单工厂设计模式
{
    public class Lenovo:NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本！");
        }
    }
}
