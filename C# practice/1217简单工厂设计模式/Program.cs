using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1217简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入你想要的电脑品牌:");
            String brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();

        }
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "IBM":
                    nb = new IBM();
                    break;
                case "Lenovo":
                    nb=new Lenovo();
                    break;
                case "Acer":
                    nb=new Acer();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
            }

            return nb;
        }
    }
}
