using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1219超市收银系统
{
    /// <summary>
    /// 打折的父类
    /// </summary>
    abstract class CalFather
    {
        public abstract double GetTotalMoney(double realMoney);
       
    }
}
