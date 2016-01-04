using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0104.泛型委托
{
    public delegate int DelCompare<T>(T t1,T t2);
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 6, 6, 2, 3, 89, 1 };
            //int max = GetMax<int>(nums, Compare1);
            string[] names = { "dsafsa", "dsa", "fasdsagas", "ds", "jjhk" };
            string max = GetMax<string>(names, Compare2);
            Console.WriteLine(max);
        }
        public static T GetMax<T>(T[] nums,DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max,nums[i])<0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        public static int Compare1(int n1,int n2)
        {
            return n1 - n2;
        }
        public static int Compare2(string s1,string s2)
        {
            return s1.Length - s2.Length;
        }
    }
}
