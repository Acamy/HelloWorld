using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象练习
{
    public class Student
    {
        ~Student()
        {
            Console.WriteLine("Destructor is called!");
        }
        public Student(string name,int age,char gender,int chinese,int math,int english)//构造函数，创建对象的时候调用构造函数。
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
            Console.WriteLine("Constructor is called!");
        }
        public Student(string name, int age, char gender):this(name,age,gender,0,0,0)//构造函数重载，this关键字能够调用三类的构造函数。
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
           
            Console.WriteLine("Constructor' is called!");
        }
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
                    _gender = '男';
                }
                return _gender; }
            set { _gender = value; }
        }
        private int _chinese;

        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        private int _math;

        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        private int _english;

        public int English
        {
            get { return _english; }
            set { _english = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生。",this.Name,this.Age,this.Gender);
        }
        public void ShowScore()
        {
            Console.WriteLine("我叫{0}，我的总成绩是{1}，我的平均成绩是{2}", this.Name, this.Chinese + this.Math + this.English, (Chinese + this.Math + this.English)/3);
        }
    }
}
