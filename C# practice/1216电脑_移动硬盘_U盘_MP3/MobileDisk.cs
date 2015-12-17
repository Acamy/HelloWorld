using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1216电脑_移动硬盘_U盘_MP3
{
    public class MobileDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘在写数据");
        }
    }
}
