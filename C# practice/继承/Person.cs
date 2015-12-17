using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public class Person//父类
    {
        public Person(string name,int age,char gender)
        {
            this._name = name;
            this._age = age;
            this._gender = gender;

        }
        //public Person()
        //{

        //}
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age; 

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public virtual void Tech()
        {
            Console.WriteLine("每个人都有技能");
        }
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡！");
        }
    }
}
