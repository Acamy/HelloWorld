using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public class Teacher : Person//Person的子类
    {
        public Teacher(string name,int age,char gender,double salary)
            :base(name,age,gender)
        {
            this.Salary = salary;
        }
       
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        

        public override void Tech()
        {
            Console.WriteLine("老师会上课！");
        }
    }
}
