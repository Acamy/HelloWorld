using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            ////创建一个集合对象
            //ArrayList list = new ArrayList();
            ////集合：很多数据的一个集合
            ////数组：长度不可变、类型单一
            ////集合的好处：长度可以任意改变，类型随便
            //list.Add(1);
            //list.Add(3.14);
            //list.Add("张三");
            //list.Add('男');
            //list.Add(5000m);
            //list.Add(new int[] {1,2,3,4,5,6,7,8,9});
            //Person p = new Person();
            //list.Add(p);
            //list.Add(list);
            //list.AddRange(new int[] {1,2,3,4,5,6,7,8,9});
            //list.AddRange(list);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] is Person)
            //    {
            //        ((Person)list[i]).SayHello();
            //    }
            //    Console.WriteLine(list[i]);
            //}
            //list.Clear();//清空所有元素
            //list.Remove(true)//删除单个元素，写谁就删谁
            //list.RemoveAt(0)//根据下标去删除元素
            //list.RemoveRange(0,3)//根据下标去移除一定范围的元素
            //list.Sort();//升序排列
            //list.Reverse();//反转
            //list.Insert(1,"插入的");//插入
            //list.InsertRange(0,new string[] {"张三","李四","王五"});
            //bool b=list.Contains(1);//返回布尔类型

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] {1,2,3,4,5,6,7,8,9});
            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    sum += (int)list[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(sum/list.Count);

            //ArrayList list = new ArrayList();
            //Random r = new Random();
            //for (int i = 0; i < 10; )
            //{
            //    int rNumber = r.Next(0,10);
            //    if (!list.Contains(rNumber))
            //    {
            //        list.Add(rNumber);
            //        i++;
            //    }
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //string n2 = "张三";
            //double n3 = 3.14;
            //var n4 = 6.14;
            //Console.WriteLine(n2.GetType());
            //Console.WriteLine(n3.GetType());
            //Console.WriteLine(n4.GetType());

            //Hashtable ht = new Hashtable();
            //ht.Add(1,"张三");
            //ht.Add(2,true);
            //ht.Add(3,'男');
            //ht.Add(false,"错误的");
            ////在键值对集合中，是根据键去找值的
            //Console.WriteLine(ht[0]);
            //var:根据值能推断出类型，隐式类型必须初始化
            //c#是一门强类型语言：在代码中，必须对第一个变量的类型有一个明确的定义
            //js是一门弱类型语言，不需要对变量的类型有一个明确的定义，可以根据它的值来推出它所属的类型
            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine("键是{0},值是{1}", item, ht[item]);
            //}
            //for (int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine("键是{0},值是{1}",item,ht[item]);
            //}

            ////foreach的用法,foreach比for的循环效率高
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);

            //}
            //Console.WriteLine("=====================");
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);

            //}
            
            //比较for和foreach的效率
            //int[] nums=new int[10000];
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < nums.Length; i++)
            //{
                
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            //Stopwatch sw1 = new Stopwatch();
            //sw1.Start();
            //foreach (var item in nums)
            //{
                
            //}
            //sw1.Stop();
            //Console.WriteLine(sw.Elapsed);

            String Jian="1fda";
            const String Fan="2saf";

            Hashtable ht = new Hashtable();
            for (int i = 0; i < Jian.Length; i++)
			{
                ht.Add(Jian[i],Fan[i]);
			}
            Console.WriteLine("请随便输入：");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (ht.ContainsKey(input[i]))
                {
                    Console.WriteLine(ht[input[i]]);
                }
                else
                {
                    Console.WriteLine(input[i]);
                }
            }

        }
    }
}
