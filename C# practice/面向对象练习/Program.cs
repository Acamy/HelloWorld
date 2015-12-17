using System;//命名空间
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            
            //创建Person类的对象
            //Person suQuan = new Person();
            //suQuan.Name = "孙全";
            //suQuan.Age = -23;
            //suQuan.Gender = '中';
            //suQuan.CHLLS();
            //suQuan.M1();
            //Person.M2();
            Student zsStudent = new Student("张三",18,'男',97,84,92);
            //zsStudent.Name = "张三";
            //zsStudent.Age = 18;
            //zsStudent.Gender = '男';
            //zsStudent.Chinese = 97;
            //zsStudent.Math = 84;
            //zsStudent.English = 92;
            zsStudent.SayHello();
            zsStudent.ShowScore();

            Student xlStudent=new Student("小兰",15,'女',99,76,86);
            //xlStudent.Name="小兰";
            //xlStudent.Age=16;
            //xlStudent.Gender='女';
            //xlStudent.Chinese=99;
            //xlStudent.Math=76;
            //xlStudent.English=86;
            xlStudent.SayHello();
            xlStudent.ShowScore();

            Student lsStudent = new Student("李四",19,'男');
            lsStudent.SayHello();
            lsStudent.ShowScore();
            //Console.ReadKey();

            Ticket t = new Ticket(400);
            t.ShowTicket();

        }
    }
}
