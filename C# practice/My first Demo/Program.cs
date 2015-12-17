using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace My_first_Demo
{
    public enum Gender
    {
        男,
        女
    }
    public enum seasons
    {
        春,
        夏,
        秋,
        冬
    }
    public enum QQState
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    public struct Person
    {
       public string _name;
       public int _age;
       public Gender _gender;
       public int _grade;
    }
    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }


    class HelloWorld
    {
        static void Main(string[] args)
        {
            #region C# 基础知识
            #region free
            //将枚举类型强转成Int类型
            //QQState state = QQState.OnLine;
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            //int n = 91;
            //QQState state=(QQState)n;
            //Console.WriteLine(state);

            //所有的类型都能转换成string类型
            //int n1 = 10;
            //string s= n1.ToString();
            //Console.WriteLine(s);
            //QQState state = QQState.OnLine;
            //string s =state.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();
            //string s = "hj";
            ////将s转换成枚举类型
            ////QQState state=)=s;
            ////Convert.ToInt32() int.parse() int.TryParse()
            //QQState state=(QQState)Enum.Parse(typeof(QQState),s);
            //Console.WriteLine(state);
            //枚举类型默认是跟Int类型相互兼容的，所以可以通过强制类型转换的语法互相转换
            //当转换一个枚举中没有的值的时候，不会抛异常，而是直接将数字显示出来
            //枚举同样 也可以跟string类型互相转换
            //枚举练习
            //while (true)
            //{


            //Console.WriteLine("请选择您的在线状态 1--OnLine 2--OffLine 3--Leave 4--Busy 5--QMe");
            //string input = Console.ReadLine();
            //switch(input)
            //{
            //    case "1": QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("你选择的在线状态是{0}",s1);
            //        break;
            //    case "2": QQState s2 = (QQState)Enum.Parse(typeof(QQState),input);
            //        Console.WriteLine("你选择的在线状态是{0}",s2);
            //        break;
            //    case "3": QQState s3 = (QQState)Enum.Parse(typeof(QQState),input);
            //        Console.WriteLine("你选择的在线状态是{0}",s3);
            //        break;
            //    case "4": QQState s4 = (QQState)Enum.Parse(typeof(QQState),input) ;
            //        Console.WriteLine("你选择的在线状态是{0}",s4);
            //        break;
            //    case "5": QQState s5 = (QQState)Enum.Parse(typeof(QQState),input);
            //        Console.WriteLine("你输入的在线状态是{0}",s5);
            //        break;
            //}
            //}
            //XX大学管理系统
            //string zsName="张三";
            //int zsAge = 21;
            //char zsGender='男';
            //int zsGrade = 3;
            //Person zsPerson;
            //zsPerson._name = "张三";
            //zsPerson._age = 21;
            //zsPerson._gender=Gender.男;

            //Person lsPerson;
            //lsPerson._name = "李四";
            //lsPerson._age = 19;
            //lsPerson._gender=Gender.女;

            //Console.WriteLine(zsPerson._gender);
            //Console.WriteLine(lsPerson._name);
            //MyColor mc;
            //mc._red = 255;
            //mc._blue = 0;
            //mc._green = 0;
            //三元表达式;表达示1?表达式2：表达式3
            //Console.WriteLine("请输入第一个数字");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int max = a > b ? a : b;            
            //Console.WriteLine(max);
            //string name = Console.ReadLine();
            //string result = name == "he" ? "淫才呀" : "流氓啊";
            //Console.WriteLine(result);

            //产生随机数
            //1.创建能够产生随机数的对象
            //2.让产生随机数的这个对象调用方法来产生随机数



            //{
            //    Random r = new Random();
            //    int rNumber=r.Next(1, 11);
            //    Console.WriteLine(rNumber);

            //}

            //输入名字随机显示这个人上辈子是什么样的人
            //Console.WriteLine("请输入你的姓名");
            //string name = Console.ReadLine();
            //Random r=new Random();
            //int rNumber=r.Next(1,7);
            //switch (rNumber)
            //{
            //    case 1: Console.WriteLine("{0}上辈子是吃翔的",name);
            //        break;
            //    case 2: Console.WriteLine("{0}上辈子是拉翔的",name);
            //        break;
            //    case 3: Console.WriteLine("{0}上辈子就是一坨翔",name);
            //        break;
            //    case 4: Console.WriteLine("{0}上辈子是大汉奸",name);
            //        break;
            //    case 5: Console.WriteLine("{0}上辈子是拉皮条了",name);
            //        break;
            //    case 6: Console.WriteLine("{0}上辈子是救苦救难的活菩萨",name);
            //        break;
            //}
            //int n = 10;
            //Gender gender = Gender.男;
            //Console.WriteLine("请输入一个数字");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <=number; i++)
            //{
            //    int j=number-i;
            //    Console.Write("{0}+{1}={2}\n",i,j,i+j);
            //}
            //Console.ReadKey(); 
            //int numberOnne = Convert.ToInt32("123");
            //double.Parse decimal.Parse
            //int number = int.Parse("123");
            //Console.WriteLine(number);
            //Console.ReadKey();
            //int.TryParse:尝试着将一个字符串转换成int类型,它是一个方法或者函数
            //int number = 56;
            //Console.WriteLine("请输入需要转换的数字");
            //string str = Console.ReadLine();
            //bool b = int.TryParse(str,out number);
            //Console.WriteLine(b);
            //Console.WriteLine(number);
            //Console.ReadKey();
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的年龄",i+1);
            //    try
            //    {
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        if (age >= 0 && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的年龄超出正常范围，程序退出");
            //            b = false;
            //            break;
            //        }

            //    }
            //    catch 
            //    {
            //        Console.WriteLine("你输入的有误，程序退出");
            //        b = false;
            //        break;
            //    }

            //}
            //if (b)
            //{
            //    Console.WriteLine("5个人平均年龄是{0}", sum / 5);
            //}

            //Console.ReadKey();
            //string name = "";
            //string pwd="";
            //while (true)
            //{
            //    Console.WriteLine("请输入你的姓名：");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入你的密码");
            //    pwd = Console.ReadLine();
            //    if (name == "admin" && pwd == "888888")
            //    {
            //        Console.WriteLine("登录成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("你输入的姓名或密码有误，请重新输入");
            //    }
            //}
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //    if (sum > 20)
            //    {
            //        Console.WriteLine("前面{0}个数的和已经超过了20",i);
            //        break;
            //    }

            //}
            //while (true)
            //{
            //    Console.WriteLine("Hello,World!");
            //    continue;
            //    Console.WriteLine("Hi");
            //   // break;
            //}
            //int sum = 0;
            //for (int i = 1; i <= 100;  i++)
            //{
            //    if (i%7!=0)
            //    {

            //        sum += i;
            //    }
            //    else
            //    {

            //        continue;
            //    }


            //}
            //Console.WriteLine("一到一百除的七的整数倍数字外的和为{0}",sum);
            //Console.ReadKey();
            //找出100内所有的素数
            //int number=1;
            //int number1;
            //for (int i = 2; i <= 100; i++)
            //{
            //    number = 1;
            //    for (int j = 2; j < i; j++)
            //    {

            //        number1 = i % j;
            //        number *= number1;
            //    }
            //    if (number!=0)
            //    {
            //        Console.Write("{0}\t",i);
            //    }
            //}
            //语法上没有错误，在程序运行的过程当中，由于某些原因程序出现了错误，不能再正常的运行。
            //try-catch语句用的处理异常
            //变量的作用域，只有在所作用的范围内才有效
            //int number = 0;
            //bool b = true;
            //    Console.WriteLine("请输入一个数字");
            //    try
            //    {
            //    number = Convert.ToInt32(Console.ReadLine());//赋值       
            //    }
            //    catch
            //    {
            //        Console.WriteLine("你输入的有异常");
            //        b = false;

            //    }
            //    //我们如果要执行下面这行代码，需要满足某些条件
            ////请代码满足某些条件去执行的话，使用bool类型
            //    if (b ==true)
            //    {
            //        Console.WriteLine(number * 2);
            //    }
            //    Console.ReadKey();
            //int? count = null;//为了声明可以存储null的变量，要使用可空修饰符?
            //do
            //{
            //    Console.Write("Hello,C++!Hello,C#!Hello,World!");
            //}
            //while (count ==null);
            //{
            //    int n = int.MaxValue;
            //    n = n + 1;
            //    Console.WriteLine(n);
            //}
            //checked
            //{
            //    int n = int.MaxValue;
            //    n = n + 1;
            //    Console.WriteLine(n);//未经处理的异常
            //}
            //int number = 10;
            //number++;
            //Console.WriteLine(number);
            //Console.ReadKey();
            ////int age = 18;
            ////age = 81;
            ////Console.WriteLine("原来你都"+age+"岁了");
            ////int days = 46;
            ////int week = days / 7;
            ////int day = days % 7;
            ////Console.WriteLine("{0}天是{1}周零{2}天",days,week,day);
            ////int seconds = 107653;
            ////int days = seconds / 86400;
            ////int secs = seconds % 86400;
            ////int hours = secs / 3600;
            ////secs=secs%3600;
            ////int mins = secs / 60;
            ////secs=secs % 60;
            ////Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒",seconds,days,hours,mins,secs);
            ////显示类型转换，隐式类型转换
            ////类型如果相兼容的两个变量，可以使用自动类型转换或者强制类型转换
            ////但是，如果两个类型的变量不兼容，
            ////string s = "123";
            ////int d=Convert.ToInt32(s);
            ////Console.WriteLine(d);
            ////Console.ReadKey();
            ////Console.WriteLine("请输入您的姓名");
            ////string name = Console.ReadLine();
            ////Console.WriteLine("请输入您的语文成绩");
            ////string strChinese = Console.ReadLine();
            ////Console.WriteLine("请输入您的数学成绩");
            ////string strMath = Console.ReadLine();
            ////Console.WriteLine("请输入您的英语成绩");
            ////string strEnglish = Console.ReadLine();

            ////int chinese=Convert.ToInt32(strChinese);
            ////int math = Convert.ToInt32(strMath);
            ////int english = Convert.ToInt32(strEnglish);
            ////Console.WriteLine("{0}你的总成绩是{1},平均成绩是{2}",name,chinese+math+english,(chinese+math+english)/3);

            ////double chinese = Convert.ToDouble(strChinese);
            ////double math = Convert.ToDouble(strMath);
            ////double english = Convert.ToDouble(strEnglish);
            ////double sumScore = chinese + math + english;
            ////double avg = (int)sumScore*1.0 / 3;
            ////Console.WriteLine("{0}你的总成绩是{1},平均成绩是{2:0.00}",name,sumScore,avg);
            ////Console.WriteLine("请输入一个数字");
            ////string strNumber=Console.ReadLine();
            ////将用户输入的数字符串转换成int或者double类型
            ////double number = Convert.ToDouble(Console.ReadLine());
            ////Console.WriteLine(number*2);

            ////int number = 10;
            ////int result = 10 + ++number;
            ////int result = 10 + number;
            ////number++;
            ////int result = 10 + number++;
            ////number++;
            ////int result = 10 + number;

            ////int result = 10 + number--;
            ////int result = 10 + number;
            ////number--;

            ////int result = 10 + --number;
            ////number--;
            ////int result = 10 + number;

            ////int a = 5;
            ////int b = a++ + ++a * 2 + --a + a++;
            ////Console.WriteLine(a);
            ////Console.WriteLine(b);
            ////bool b = 1500 > 1;
            ////bool b = 3 > 1000;
            ////bool b = 20 == 21;
            ////Console.WriteLine(b);

            ////Console.WriteLine("小苏，输入你的语文成绩");
            ////string strChinese=Console.ReadLine();
            ////int chinese = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("小苏，输入你的数学成绩");
            ////int math=Convert.ToInt32(Console.ReadLine());
            ////bool b=chinese>90&&math>90;
            ////Console.WriteLine(b);
            ////Console.ReadKey();
            ////Console.WriteLine("请输入要凑数的年份");
            ////int year = Convert.ToInt32(Console.ReadLine());
            ////bool b=(year%400==0)|| (year % 4==0 && year % 100!=0);
            ////Console.WriteLine(b);
            ////Console.ReadKey();
            ////bool b = 5 < 3 &&5 > 3;
            ////Console.WriteLine(b);
            ////变量类型：int double string char decimal bool
            ////运算符，赋值运算符：=，复合赋值运算符：+=，-=，*=，/=,%=，算数运算符:+-*/%++--
            ////关系运算符:><
            ////Console.WriteLine("请输入你跪键盘的时间");
            ////int mins = Convert.ToInt32(Console.ReadLine());
            ////bool b=mins>60;
            ////if (b==true)
            ////{
            ////    Console.WriteLine("好老公，不用跪键盘了，去吃屎吧！");

            ////}
            ////Console.ReadKey();
            ////Console.WriteLine("请输入你的年龄");
            ////int age = Convert.ToInt32(Console.ReadLine());
            ////if (age >= 23)
            ////{
            ////    Console.WriteLine("你可以结婚了");
            ////}
            ////Console.ReadKey();
            ////Console.WriteLine("请输入老苏的语文成绩");
            ////int chinese = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("请输入老苏的音乐成绩");
            ////int music = Convert.ToInt32(Console.ReadLine());
            ////bool b=(chinese>90&&music>80)||(chinese==100&&music>70);
            ////if (b==true)
            ////    Console.WriteLine("奖励100元");

            ////else
            ////    Console.WriteLine("不奖励100元");
            ////Console.ReadKey();
            ////Console.WriteLine("请输入你的用户名");
            ////string name = Console.ReadLine();
            ////Console.WriteLine();
            ////string pwd = Console.ReadLine();
            #endregion
            #region if语句
            //       //在try和catch之间不能有其它的代码
            //       int salary = 5000;
            //       bool b = true;
            //       Console.WriteLine("请输入公司对李四的评级");
            //       string level = Console.ReadLine();
            //       if (level == "A")
            //       {
            //           salary += 500;
            //       }
            //else if(level == "B")
            //       {
            //           salary += 200;
            //       }
            //   else if(level == "C")
            //       {

            //       }
            //  else if(level == "D")
            //       {
            //           salary -= 200;
            //       }
            // else if (level == "E") 
            //       {
            //           salary -= 500;
            //       }

            //       else
            //       {
            //           Console.WriteLine("您输入的有误，请重新输入");
            //           b = false;
            //       }
            //       if (b)
            //       {
            //           Console.WriteLine("李四的实际工资为{0}", salary);
            //       }
            //           Console.ReadKey();
            #endregion
            #region switch1
            //double salary = 5000;
            //bool b = true;
            //Console.WriteLine("请输入公司对李四的评级");
            //string level = Console.ReadLine();
            //switch (level)
            //{
            //    case "A": salary += 500;
            //        break;
            //    case "B": salary += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "D": salary -= 200;
            //        break;
            //    case "E": salary -= 500;
            //        break;
            //    default: Console.WriteLine("你的输入有误，请再来一次");
            //             b = false;
            //        break;
            //}
            //if (b)
            //{
            //    Console.WriteLine("李四的实际工资是｛0｝", salary);

            //}
            //    Console.ReadKey();
            #endregion
            #region switch2
            //Console.WriteLine("请输入一个人的姓名，我们将显示出他上辈子的职业");
            //string name = Console.ReadLine();
            //switch (name)
            //{
            //    case "老杨": Console.WriteLine("上辈子是抽大烟的");
            //        break;
            //    case "老苏": Console.WriteLine("上辈子是个老鸨子");
            //        break;
            //    case "老马": Console.WriteLine("上辈子是老办手下的头牌");
            //        break;
            //    case "老蒋": Console.WriteLine("上辈子是拉皮条的");
            //        break;
            //    case "老牛": Console.WriteLine("上辈子是一坨翔");
            //        break;
            //    case "老虎": Console.WriteLine("上辈子是个大病猫");
            //        break;
            //    case "老赵": Console.WriteLine("上辈子是光芒万丈救苦救难的菩萨呀");
            //        break;
            //    default: Console.WriteLine("不认识，估计是一坨翔");
            //        break;
            //}
            //Console.ReadKey();
            #endregion
            #region switch3
            //Console.WriteLine("请输入一个考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());//0～100
            //switch (score / 10)
            //{
            //    case 10: 
            //        break;
            //    case 9: Console.WriteLine("A");
            //        break;
            //    case 8: Console.WriteLine("B");
            //        break;
            //    case 7: Console.WriteLine("C");
            //        break;
            //    case 6: Console.WriteLine("D");
            //        break;
            //    case 5: Console.WriteLine("E");
            //        break;
            //    default: Console.WriteLine("你的输入有误，请你重新输入");
            //        break;



            //}
            //Console.ReadKey();
            #endregion
            #region 用switch语句判断某年某月有多少天
            //Console.WriteLine("请输入年份");
            //try
            //{
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入月份");
            //    try
            //    {
            //        int month = Convert.ToInt32(Console.ReadLine());
            //        if (month >= 1 && month <= 12)
            //        {
            //            int day = 0;
            //            switch (month)
            //            {
            //                case 1:
            //                case 3:
            //                case 5:
            //                case 7:
            //                case 8:
            //                case 10:
            //                case 12: day = 31;
            //                    break;
            //                case 2:
            //                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            //                    {
            //                        day = 29;
            //                    }
            //                    else
            //                    {
            //                        day = 28;
            //                    }
            //                    break;
            //                default: day = 30;
            //                    break;

            //            }
            //            Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的月份不符合要求，程序退出");
            //        }
            //    }
            //     catch
            //    {
            //        Console.WriteLine("你输入的月份有误，程序退出");
            //    }


            //}
            //catch
            //{
            //    Console.WriteLine("你输入的年份有误，程序退出");
            //}
            //Console.ReadKey();
            #endregion
            #region while1
            //int i=0;
            //while (i<100)
            //{
            //    i++;
            //    Console.WriteLine("\t下次考试我一定要细心");
            //}
            //Console.ReadKey();
            #endregion
            #region while2
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;

            //}
            //Console.WriteLine("1到100的和为{0}",sum);
            //Console.ReadKey();
            //break一般不单独的使用，而是跟着if语句来使用，也可以跳出switch-case语句
            #endregion
            #region while3
            //int i=1;
            //Console.WriteLine("请输入你的用户名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入你的密码");
            //string password = Console.ReadLine();
            //while ((name!="admin"||password!="888888")&&(i<3))
            //{
            //    Console.WriteLine("请再次输入你的用户名");
            //   name = Console.ReadLine();
            //    Console.WriteLine("请再次输入你的密码");
            //    password = Console.ReadLine();
            //    i++;

            //}
            //if (i < 3)
            //{
            //    Console.WriteLine("恭喜你，登录成功！");
            //}
            //else
            //{
            //    Console.WriteLine("对不起，你的输入次数已经达到上限，请明天再试！");
            //}
            //Console.ReadKey();
            #endregion
            #region if语句
            //string input="";           
            //Console.WriteLine("请输入一个数字,我们将输出它的两倍");
            //input = Console.ReadLine();
            //if (input != "q")
            //{
            //    try
            //    {
            //        int number = Convert.ToInt32(input);
            //        Console.WriteLine("你输入的数字的两倍为{0}", number * 2);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("你输入的数字有误，程序退出");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("你输入的是q,程序退出");
            //}
            //Console.ReadKey();
            #endregion
            #region 错误程序
            //string input = "";
            //Console.WriteLine("请输入几个正整数，我们将找出它的最大值，输入end结束数字的输入");
            //input = Console.ReadLine();


            //    int number = Convert.ToInt32(input);


            //    Console.WriteLine("你的输入有误，程序退出");


            //int newnumber;

            //while(input!="end")
            //{
            //    Console.WriteLine("请继续几个正整数，输入end结束数字的输入");
            //    input = Console.ReadLine();
            //    try
            //    {
            //        newnumber = Convert.ToInt32(input);
            //        if (newnumber > number)
            //        {
            //            number = newnumber;
            //        }
            //        else
            //        {

            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("你输入的是“end”,程序退出");
            //    }


            //}
            //Console.WriteLine("你输入的数字中的最大值为{0}",number);
            //Console.ReadKey();
            #endregion
            #region 循环嵌套
            //string input = "";
            //int max = 0;
            //while (input != "end")
            //{

            //    Console.WriteLine("请输入几个数字，以end结束");
            //    input = Console.ReadLine();
            //    if (input != "end")
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(input);
            //            if (max < number)
            //            {
            //                max = number;
            //            }
            //        }
            //        catch 
            //        {
            //            Console.WriteLine("输入的字条不能转换为数字，请重新输入");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("你刚才输入的数字的最大值为{0}", max);
            //    }
            //}
            //Console.ReadKey();
            #endregion
            #region for
            //for (int i = 0; i < 10; i++)//已知循环次数时用for循环
            //{
            //    Console.WriteLine("欢迎来到传智播客学习！{0}",i);
            //}
            //Console.ReadKey();
            //for (int i = 10; i>=1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
            //int sum=0;
            //for (int i = 2; i <=100; i+=2)
            //{
            //    sum += i;                
            //}
            //Console.WriteLine("{0}",sum);
            #endregion
            #region 找出100到999间的水仙花数
            //水仙花数指的就是这个百位数：百位的立方+十位的立方+个位的立方==当前这个百位数字



            //for (int i = 100; i <= 999; i++)
            //{
            //    int bai = i / 100;
            //    int shi = i%100 / 10;
            //    int ge = i % 10;
            //    if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
            //    {
            //        Console.WriteLine("水仙花数有:{0}", i);
            //    }
            //}
            //Console.ReadKey();
            #endregion
            #region 用for循环编乘法口决表
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t",i,j,i*j);       
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion
            #region 找出100以内的质数
            //for (int i = 2; i <= 100; i++)
            //{
            //    bool b = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        //除尽了说明不是质数，也就没有必要再往下继续余的必要了
            //        if (i%j==0)
            //        {
            //            b = false;
            //            break;
            //        }
            //    }
            //    if (b)
            //    {
            //        Console.Write("{0}\t",i);
            //    }

            //}

            //Console.ReadKey();
            #endregion
            #endregion
            //double number;
            //string input;
            //Console.WriteLine("Enter a number");
            //input = Console.ReadLine();
            //if (double.TryParse(input,out number))
            //{
            //    //converted correctly
            //}
            //else
            //{
            //    Console.WriteLine("The text entered was not a valid number");
            //}
            //char[] groceryList;
            //Console.WriteLine("How many items in the list");
            //int size = int.Parse(Console.ReadLine());
            //groceryList = new char[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(groceryList[i]);
            //}
            ////二维数组的赋值
            //int[,] cells ={
            //             {1,0,2},
            //             {1,2,0},
            //             {1,2,1}
            //             };
            ////三维数组的赋值
            //bool[,,] cells1;
            //cells1 = new bool[2, 3, 3]
            //{
            //    {   {true,false,false},
            //        {true,false,false}, 
            //        {false,false,false} 
            //    },
            //    {   {false,false,true},
            //        {false,false,false},
            //        {false,true,true}
            //    }
            //};
            ////代码清单2-42 初始化一个交错数组
            //int[][] cells2 =
            //{
            //    new int[]{1,0,2,0},
            //    new int[]{1,2,0},
            //    new int[]{1,2},
            //    new int[]{1}
            //};

            //代码清单2-51 获取一个特定的维的大小
            //bool[,,] cells3;
            //cells3= new bool[2, 3, 3];
            //Console.WriteLine(cells3.Rank);

            //代码清单2-54 反转一个字符串
            //string reverse, palindrome;
            //char[] temp;
            //Console.WriteLine("Enter a palindrome");
            //palindrome = Console.ReadLine();
            //reverse = palindrome.Replace(" ","");
            //reverse = reverse.ToLower();
            //temp = reverse.ToCharArray();
            //Array.Reverse(temp);
            //if (reverse==new string(temp))//根据反转好的字符组创建了一个新的字符串
            //{
            //    Console.WriteLine("\"{0}\" is a palindrome",palindrome);
            //}
            //else
            //{
            //    Console.WriteLine("\"{0}\" is not a palindrome",palindrome);
            //}
            //int n='3'+'4';
            //char c=(char)n;
            //Console.WriteLine(c);
            //int distance=' '-'c';
            //Console.WriteLine(distance);
            
            //float n = 0f;
            //Console.WriteLine(n/0);

            //Console.WriteLine(Math.Sqrt(-1));

            //Console.WriteLine(-1f/0);
            //Console.WriteLine(3.402823E+38f*2f);

            //char current;
            //int asciiValue;
            //current='z';
            //do
            //{
            //    asciiValue = current;
            //    Console.Write("{0}={1}\t",current,asciiValue);
            //    current--;
            //} while (current>='a');

            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.E);


            //int x = -7;
            //x=(x>>2);
            //Console.WriteLine(x);

            //byte and, or, xor;
            //and = 12 & 7;
            //or = 12 | 7;
            //xor = 12 ^ 7;
            //Console.WriteLine("and={0}\nor={1}\nxor={2}",and,or,xor);

            //代码清单3-39 获取二进制形式的字符串表示
            //const int size = 64;
            //ulong value;
            //char bit;
            //Console.WriteLine("Enter an integer:");
            //value = (ulong)long.Parse(Console.ReadLine());
            //ulong mask = 1ul << size - 1;
            //for (int count = 0; count < size; count++)
            //{
            //    bit=((mask&value)>0)?'1':'0';
            //    Console.Write(bit);
            //    mask >>= 1;
            //}

            //代码清单3-44 使用多个表达式的for循环
            //for (int x = 0,y=5; (x<=5&&y>=0); x++,y--)
            //{
            //    Console.WriteLine("{0}{1}{2}",x,(x>y?'>':'<'),y);
            //}

            //用foreach判断剩余走棋
            //char[] cells = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //foreach (char cell in cells)
            //{
            //    if (cell!='0'&&cell!='x')
            //    {
            //        Console.WriteLine(cell);
            //    }
            //}

            //判断电子邮件地址的域名部分
            string email;
            bool insideDomain=false;
            Console.WriteLine("Please Enter your email address:");
            email = Console.ReadLine();
            Console.Write("The mail domain is:");
            foreach (char letter in email)
            {
                if (insideDomain)
                {
                    Console.Write(letter);
                }
                else
                {
                    if (letter=='@')
                    {
                        insideDomain = true;
                    }
                }
            }




            


        }
    }
}
