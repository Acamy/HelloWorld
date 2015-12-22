using System;
using System.Collections.Generic;
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
            
        }
    }
}
