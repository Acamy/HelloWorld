using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            ////File FileStream Path StreamReader StreamWriter
            //Directory 文件夹 目录
            //Directory.CreateDirectory(@"C:\A");
            //Directory.Delete(@"C:\A",true);
            //Directory.Move(@"C:\new", @"C:\Users\Acamy\Desktop\new1");

            ////获得指定目录下所有文件的全路径
            //string[] path = Directory.GetFiles(@"E:\Pictures","*.jpg");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}

            ////获得指定目录下所有文件夹的全路径
            //string[] path=Directory.GetDirectories(@"E:\Pictures");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}

            ////判断指定的文件夹是否存在，用循环创建100个文件夹并删除
            //if(Directory.Exists(@"E:\Pictures\a"))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Directory.CreateDirectory(@"E:\Pictures\a\"+i);
            //    }
               
            //}
            //Directory.Delete(@"E:\Pictures\a",true);
            
            //Process[] pros=Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    Console.WriteLine(item);
            //}

            //Process.Start("calc");
            //Process.Start("mspaint");
            //Process.Start("notepad");
            //Process.Start("iexplore", "http://www.baidu.com");

            ////通过一个进程打开指定文件
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Acamy\Desktop\3.txt");
            ////首先，创建一个进程
            //Process p = new Process();
            //p.StartInfo = psi;
            //p.Start();



        
            
        }
    }
}

