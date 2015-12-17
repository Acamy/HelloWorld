using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1217简单工厂设计模式
{
    public class Acer:NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是宏基笔记本！");
        }
    }
}
