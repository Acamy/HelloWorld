using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1216电脑_移动硬盘_U盘_MP3
{
    public class MP3:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3在播放音乐");
        }
    }
}
