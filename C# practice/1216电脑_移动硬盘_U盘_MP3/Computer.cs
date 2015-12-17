using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1216电脑_移动硬盘_U盘_MP3
{
    public class Computer
    {
        private MobileStorage _ms;

        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }
        public void CpuRead()
        {
            Ms.Read();
        }
        public void CpuWrite()
        {
            Ms.Write();
        }
    }
}
