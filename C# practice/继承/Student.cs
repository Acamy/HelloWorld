using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public class Student : Person//Person的子类
    {
        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            this.Id = id;
        }
        
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public override void Tech()
        {
            Console.WriteLine("学生会学习！");
        }
    }
}
