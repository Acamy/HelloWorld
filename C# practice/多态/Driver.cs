using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public class Driver:Person//Person的子类
    {
        public Driver(string name,int age,char gender,int drivetime)
            :base(name,age,gender)
        {
            this.DriveTime = drivetime;
        }
        private int _driveTime;

        public int DriveTime
        {
            get { return _driveTime; }
            set { _driveTime = value; }
        }

        
        public void Tech()
        {
            Console.WriteLine("司机会开车！");
        }
    }
}
