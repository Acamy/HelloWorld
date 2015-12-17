using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1216电脑_移动硬盘_U盘_MP3
{
    public class UDisk:MobileStorage
    {
        public override void Write()
        {
            Console.WriteLine("U盘在写入数据！");
        }

        public override void Read()
        {
            Console.WriteLine("U盘在读入数据！");
        }
    }
}
