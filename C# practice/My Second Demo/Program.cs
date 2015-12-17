using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace My_Second_Demo
{
    class Program
    {
        public static int GetMax(int n1, int n2)
        
        {
            return n1 > n2 ? n1 : n2;
            /// <summary>
            /// 比较两个值的大小，并返回较大值
            /// </summary>
            /// <param name="n1">第一个整数</param>
            /// <param name="n2">第二个整数</param>
            /// <returns>将较大值返回</returns>
        }        
        public static double GetAvg(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg = sum / numbers.Length;
            return avg;
        }
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("您输入的字符不能转换为数字，请重新输入：");
                    strNumber = Console.ReadLine();
                } 
            }
            
            
        }
        public static bool IsPrime(int number)
        {
            
            if (number<2)
            {               
                return false;
            }
            else//number>=2
            {
                //让这个数字从2开始，除到自身的前一位
                for (int i = 2; i < number; i++)
                {
                    if (number%i==0)
                    {
                        return false;//给非质数准备的
                    }

                }
                return true;//给质数准备的
            }
            
        }        
        public static string GetLevel(int score)
        {
            /// <summary>
            /// 根据用户输入的分数来判断该分数的评级
            /// </summary>
            /// <param name="score">用户输入的分数</param>
            /// <returns>方法返回的评级</returns>
            string level;
            switch (score/10)
            {
                case 10:
                case 9:level="优";
                    break;
                case 8: level = "良";
                    break;
                case 7: level = "中";
                    break;
                case 6: level = "及格";
                    break;
                default: level = "不及格";
                    break;

            }
            return level;
        }
        public static string GetLongest(string[] s)
        {
            string max=s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (max.Length<s[i].Length)
                {
                   max=s[i]; 
                }
            }
            return max;
        }       
        //out 参数侧重于在一个方法中可以返回多个不同类型的值
        public static void GetPerimeterArea(double r, out double perimeter, out double area)
        {
            /// <summary>
            /// 计算圆的周长和面积
            /// </summary>
            /// <param name="r">半径</param>
            /// <param name="perimeter">周长</param>
            /// <param name="area">面积</param>
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
        }        
        public static void Test(string[] names)
         {
             /// <summary>
             /// 字符串数组反转
             /// </summary>
             /// <param name="names"></param>
           for (int i = 0; i < names.Length/2; i++)
			{
			 string temp=names[i];
             names[i]=names[names.Length-1-i];
             names[names.Length-1-i]=temp;

			}
         }//输入参数为字符串数组时形参直接能改变实参的值，不需要用关键字ref
        public static int GetSum(params int[] nums)
        {
            /// <summary>
            ///任意数组求和
            /// </summary>
            /// <param name="nums">任意数组</param>
            /// <returns>返回和值</returns>
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum+=nums[i];
            }
            return sum;
        }
        public static int[] Change(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i]>nums[j])
                    {
                        int temp=nums[i];
                        nums[i]=nums[j];
                        nums[j] = temp;
                    }
                }  
            }
            return nums;
        }
        public static string ProcessString(string[] nums)
        {
            string s = "";
            for (int i = 0; i < nums.Length-1; i++)
            {
                s+=nums[i]; 
                s+='|';
            }
            s += nums[nums.Length - 1];
            return s;
        }
        static void Main(string[] args)
        {
            #region practice
            //string[] nums = { "梅西", "卡卡", "郑大世", "何宝华" };
            //string str = ProcessString(nums);
            //Console.WriteLine(str);
            //Console.ReadKey();

            ////用冒泡排序法实现升序排序
            //int[] nums = {2,34,324,21,5,4,75,75,2,7,543,76,43,34,43};
            //nums = Change(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            //int sum = GetSum(1, 2, 3, 4, 5, 6, 7, 8);
            //Console.WriteLine(sum);
            //Console.ReadKey();

            ////将一个字符串数组反转
            //string[] names = {"中国","美国","巴西","澳大利亚","加拿大"};
            //Test(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]); 
            //}
            //Console.ReadKey();
            
            ////用方法实现计算圆的周长和面积
            //double r = 5;
            //double perimeter;
            //double area;
            //GetPerimeterArea(r,out perimeter,out area);
            //Console.WriteLine(perimeter);
            //Console.WriteLine(area);
            //Console.ReadKey();

            ////用方法来实现，找出一个字符串数组中最长的那一个
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string max = GetLongest(names);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //Console.WriteLine("请输入你的考试成绩");
            //int score = GetNumber((Console.ReadLine()));
            //string level = GetLevel(score);
            //Console.WriteLine("你的成绩等级为{0}!", level);
            //Console.ReadKey();

            //Console.WriteLine("请输入一个数字，我们将判断它是否为质数");
            //string strNumber = Console.ReadLine();
            //int number = GetNumber(strNumber);
            //if (IsPrime(number))
            //{
            //    Console.WriteLine("您输入的数是质数");
            //}
            //else
            //{
            //    Console.WriteLine("您输入的数不是质数");
            //}
            //Console.ReadKey();
            //Console.WriteLine("Hello,World!");
            //Console.ReadKey();
            //#warning "Same move allowed multiple times"\
            
            //冒泡排序
            //int[] nums = { 9, 88, 7, 6, 5, 40, 3, 2, 1, 0 };
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
            //    {
            //        if (nums[j]<nums[j+1])
            //        {
            //            int temp=nums[j];
            //            nums[j]=nums[j+1];
            //            nums[j+1]=temp;
            //        }
            //    }
            //}
            //Array.Sort(nums);
            //Array.Reverse(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadLine();
            //Convert.ToInt32("3221");          
            //int a=Program.GetMax(3,7);

        //    string fullName;
        //    string driveLetter="C:";
        //    string folderPath   ="Data";
        //    string fileName = "index.html";
        //    fullName = Combine(driveLetter,folderPath,fileName);
        //    Console.WriteLine(fullName);

        //}
        //static string Combine(string driveLetter, string folderPath, string fileName)
        //{
        //    string Path;
        //    Path = string.Format("{1}{0}{2}{0}{3}",System.IO.Path.DirectorySeparatorChar,driveLetter,folderPath,fileName);
        //    return Path;
            //int[] numbers = {1,2,7,3,32,34};
            //double avg = GetAvg(numbers);
            //string s = avg.ToString("0.00");
            //avg = Convert.ToDouble(s);
            //Console.WriteLine(avg);
            //Console.ReadKey();
            #endregion;
            
        }   
        
    }
}
