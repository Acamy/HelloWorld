using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //list.AddRange(list);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //泛型集合可以转换成数组
            //int[] nums=list.ToArray();
            //List<int> listtwo=nums.ToList();

            //int n = 10;
            //object o = n;//装箱：值类型转换为引用类型
            //int nn=(int)o;//拆箱：引用类型转换为值类型

            //ArrayList list = new ArrayList();
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);//00:00:01.8118633

            //List<int> list = new List<int>();
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);//00:00:00.1641002

            //Conclusions:因为集合相对于泛型集合要进行大题的装箱拆箱操作，所以效率远不及泛型集合

            //只有两种类型存在继承关系时，才会发生装箱拆箱操作
            
            //这个地方没有发生任意类型的装箱或拆箱
            //string str = "123";
            //int n = Convert.ToInt32(str);

            //int n = 10;
            //IComparable i = n;//装箱

            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1,"张三");
            //dic.Add(2,"李四");
            //dic.Add(3,"王五");
            //dic[1] = "新来的";
            ////foreach (var item in dic.Keys)
            ////{
            ////    Console.WriteLine("{0}-------{1}",item,dic[item]);
            ////}
            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("{0}-------{1}",kv.Key,kv.Value);
            //}

            //将一个数组中的奇数放到一个集合中，再将偶数放到另外一个集合中
            //最终再将两个集合合并为一个集合，并且奇数显示在左边，偶数显示在右边
            //int[] nums = {1,2,3,4,5,6,7,8,9};
            //List<int> listOu = new List<int>();
            //List<int> listJi = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]%2==0)
            //    {
            //        listOu.Add(nums[i]);

            //    }
            //    else
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //}
            //listJi.AddRange(listOu);
            //foreach (var item in listJi)
            //{
            //    Console.Write(item+" ");
            //}

            //Console.WriteLine("请输入一个字符串");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //int i = 0;
            //foreach (var item in input)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}

            //统计Welcome to china中每个字符出现的次数

            //string str = "Welcome to China";
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //foreach (var item in str)
            //{
            //    int i = 0;
            //    foreach (var item1 in str)
            //    {
            //        if (item1 == item)
            //            i++;

            //    }
            //    if (!dic.ContainsKey(item)&&item!=' ')
            //    {
            //        dic.Add(item, i);
            //    }
                
            //}
            //foreach (KeyValuePair<char,int> kv in dic)
            //{
            //    Console.WriteLine("{0}字母出现了{1}次",kv.Key,kv.Value);
            //}

            //FileStream fs=new FileStream(@"C:\Users\Acamy\Desktop\new.txt",FileMode.OpenOrCreate,FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            //int r=fs.Read(buffer,0,buffer.Length);
            ////将字节数组中的每一个元素按照指定的编码格式解码成字符串
            //string s=Encoding.Default.GetString(buffer,0,r);
            //fs.Close();
            //fs.Dispose();
            //Console.WriteLine(s);

            //使用FileStream来写入数据
            //using (FileStream fsWrite=new FileStream(@"C:\Users\Acamy\Desktop\new.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    string str="看我有没有把你覆盖掉！";
            //    byte[] buffer=Encoding.UTF8.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);

            //using (StreamReader sr = new StreamReader(@"C:\Users\Acamy\Desktop\new.txt",Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }                
            //}

            using (StreamWriter sw=new StreamWriter(@"C:\Users\Acamy\Desktop\new1.txt"))
            {
                sw.Write("今天好天气11dfsa11afd",false);
            }
        
            }
        }
    }

