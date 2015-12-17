using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 面向对象练习;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();
            //p1.Age = 13;
            //p1.CHLLS;
            //string s1 = "张三";
            //string s2 = "张三";
            //string s = "abcdefg";
            //string可以看做是char类型的一个只读数组，所以我们可以通过下标去访问字符串中的某一个元素
            //s[0] = 'b';不能这样做，因为是只读的
            //首先将字符串转换为char类型的数组ToCharArray
            //char[] chs = s.ToCharArray();
            //chs[0] = 'b';
            //将字符数组转换为我们的字符串new string(char[] chs)
            //s=new string(chs);
            //Console.WriteLine(s[0]);
            //StringBuilder sb = new StringBuilder();
            //string str = null;
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    sb.Append(i);
            //    //str+= i;
            //}
            //sw.Stop();
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine("Welcome back!");
            //Console.ReadKey();
            //Console.WriteLine("请输入你心中想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中所想的那个人的名字的长度为{0}",name.Length);
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////lessonOne = lessonOne.ToUpper();

            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////lessonTwo = lessonTwo.ToUpper();
            //if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们俩喜欢的课程不相同");
            //}

            ////字符串的分割
            //string s = "a b  dfd _  + = ,,, fdf ";
            //char[] chs = { ' ', '_', '+', '=', ',' };
            //string[] str=s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(str[2]);

            //string s = "2008-08-08";
            //char[] chs = { '-' };
            //string[] date=s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",date[0],date[1],date[2]);
            //Console.ReadKey();

            ////屏蔽关键字
            //string str = "国家关键人物老赵";
            //if (str.Contains("老赵"))
            //{
            //    str = str.Replace("老赵","**");
            //}
            //Console.WriteLine(str);

            //截取字符串
            //string str = "今天天气好晴朗，天天处处好风光";
            //str = str.Substring(1,3);
            //Console.WriteLine(str);
            //string str = "今天天气好晴朗，处处好风光";
            //if (str.StartsWith("今天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}
            //int index = str.IndexOf('天',2);
            //int index1 = str.LastIndexOf('天');
            //Console.WriteLine(index1);
            //string path = @"c:\a\b\c苍\f\g\\fd\fd\fdf\d\v\vfd\苍老师苍.wav";
            // int index = path.LastIndexOf("\\");
            //path = path.Substring(index+1);
            //Console.WriteLine(path);

            //string str = "    agdsdafs    ";
            //str = str.Trim();
            //str = str.TrimStart();
            //str = str.TrimEnd();
            //Console.Write(str);

            //string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            ////张三｜李四｜王五｜赵六｜田七
            //string strNew = string.Join("|","张三","李四","王五","赵六","田七");
            //Console.WriteLine(strNew);
            //Console.ReadKey();

           


            //string str = "hello c sharp";
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length/2; i++)
            //{
            //    string temp = strNew[i];
            //    strNew[i] = strNew[strNew.Length - 1 - i];
            //    strNew[strNew.Length - 1 - i] = temp;
            //}
            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    Console.WriteLine(strNew[i]);
            //}
            //str=string.Join(" ",strNew);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string email = "1341251232@qq.com";
            //int index = email.IndexOf('@');
            //string userName = email.Substring(0,index);
            //string yuMing = email.Substring(index+1);
            //Console.WriteLine(userName);
            //Console.WriteLine(yuMing);

            ////dfasdfsafdsa     s
            ////adfsa            df
            ////dfas             sas
            ////assdfasfa        ad
            //string path = @"C:\Users\Acamy\Desktop\1.txt";
            //string[] contents = File.ReadAllLines(path);
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    string[] strNew=contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    Console.WriteLine((strNew[0].Length > 8 ? (strNew[0].Substring(0, 8) + "…") : strNew[0]) + '|' + strNew[1]);
            //}
            //Console.ReadKey();

            ////找出字符串中e出现的所有位置
            //string str = "dfseweqrasdgeasgeweewrq";
            //int index = str.IndexOf('e');
            //Console.WriteLine("第1次出现e的位置是{0}",index);
            //int count = 1;
            //while (index!=-1)
            //{
            //    count++;
            //    index = str.IndexOf('e',index+1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次出现e的位置是{1}",count,index);
                
            //}

            //string str = "老牛很邪恶";
            //if (str.Contains("邪恶"))
            //{
            //    str = str.Replace("邪恶","**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();

            string[] names = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            string str = string.Join("|",names);
            string[] strNew = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strNew.Length; i++)
            {
                Console.WriteLine(strNew[i]);
            }
            

        }
    }
}
