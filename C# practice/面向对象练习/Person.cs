using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象练习
{
    //class=field+property+method
    public class Person
    {
        //field
        private string _name;
        //property
        public string Name
        {
            //当你输出属性的值的时候，会执行get方法
            get{return _name;}
            //当你给属性赋值的时候，首先会执行set方法
            set{_name=value;}
        }
        private int _age;
        public int Age
        {
            get{return _age;}
            set { 
                if(value<0||value>100)
                { 
                    value = 0; 
                }
                _age = value; }

        }
        private char _gender;
        public char Gender
        {
            get { 
                if(_gender!='男'&&_gender!='女')
                {
                    return _gender = '男';
                }
                
                return _gender; }
            set { _gender = value; }
        }

        int _score;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }
        

        //method
        public void CHLLS()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了，我是{2}生，我可以吃喝拉撒睡哦！",this.Name,this.Age,this.Gender);
        }
        public void M1()
        {
            Console.WriteLine("我是非静态方法");
        }
        public static void M2()
        {
            Console.WriteLine("我是静态方法");
        }

    }
}
