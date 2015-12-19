using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1219超市收银系统
{
    class CalNormal:CalFather
    {
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
