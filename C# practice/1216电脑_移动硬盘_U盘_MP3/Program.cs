using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1216电脑_移动硬盘_U盘_MP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来实现将移动硬盘或者U盘或者MPE插到电脑上进行读写数据

            //MobileDisk md = new MobileDisk();
            //UDisk u = new UDisk();
            //MP3 mp3 = new MP3();
            //Computer cpu = new Computer();
            //cpu.CpuRead(u);
            //cpu.CpuWrite(u);

            MobileStorage ms = new MP3();
            Computer cpu = new Computer();
            cpu.Ms = ms;
            //cpu.CpuRead(ms);
            //cpu.CpuWrite(ms);
            cpu.CpuRead();
            cpu.CpuWrite();
        }
    }
}
