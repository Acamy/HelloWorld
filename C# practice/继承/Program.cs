using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 继承
            //Person p = new Student("学生", 18, '男', 302);//子类可以自动转换为父类
            ////Student s = (Student)p;//如果父类装的是子类的对象，则可以强制转制为相应的子类
            //是否能转换我们可以用is和as来检验，is可以则返回true，不行则返回false
            //as可以则返回相应转换的对象，不行则返回null

            //is的用法
            //if (p is Student)
            //{
            //    Student s1=(Student)p;
            //    s1.Study();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败！");
            //}

            //Person p1 = new Student("学生", 19, '女', 302);
            //if (p is Teacher)
            //{
            //    Teacher s1 = (Teacher)p;
            //    s1.Teach();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败！");
            //}

            ////as的用法
            //Person p2 = new Student("学生", 19, '女', 302);
            //Student s2 = p2 as Student;
            //s2.Study();

            //Person p3 = new Student("学生", 19, '女', 302);
            //Teacher t = p3 as Teacher;
            //Console.WriteLine(p3);

            ////里氏转换的练习
            //Person[] pers=new Person[10];
            //Random r = new Random();
            //for (int i = 0; i < pers.Length; i++)
            //{
            //    int rNumber = r.Next(1,4);
            //    switch (rNumber)
            //    {
            //        case 3: pers[i] = new Student("学生", 19, '女', 302);
            //                ((Student)pers[i]).Tech();
            //            break;
            //        case 2: pers[i] = new Teacher("学生", 19, '女', 302);
            //            ((Teacher)pers[i]).Tech();
            //            break;
            //        case 1: pers[i] = new Driver("学生", 19, '女', 302);
            //            ((Driver)pers[i]).Tech();
            //            break;
            //    }

            //}
            #endregion
            
            Student s1 = new Student("张三",18,'男',20110413);
            Student s2 = new Student("李四", 18, '男', 20110523);
            Teacher t1 = new Teacher("王老师", 18, '男', 5000);
            Teacher t2 = new Teacher("何老师", 18, '男', 8000);
            Driver d1 = new Driver("郭师傅", 45, '男', 5);
            Driver d2 = new Driver("苏师傅", 36, '男', 3);
            Person p = new Person("鲁滨逊",34,'男');
            Person[] pers ={s1,s2,t1,t2,d1,d2,p};
            for (int i = 0; i < pers.Length; i++)
            {
                //if (pers[i] is Student)
                //{ 
                //    ((Student)pers[i]).Tech();
                //}
                //else if (pers[i] is Teacher)
                //{
                //    ((Teacher)pers[i]).Tech();
                //}
                //else
                //{
                //    ((Driver)pers[i]).Tech();
                //}
                pers[i].Tech();

            }
        }
    }
    
}
