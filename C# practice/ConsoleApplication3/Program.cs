using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"E:\IPV6下载\马頔 - 南山南.mp4";
            string target = @"C:\Users\Acamy\Desktop\new.mp4";
            CopyFile(source,target);
            Console.WriteLine("复制成功！");
            
        }
        public static void CopyFile(string source, string target)//将一个文件复制到指定目录下
        {
            //创建一个负责读取的流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.ReadWrite))
            {
                //创建一个负责写入的流
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //因为文件可能比较大，所以我们在读取的时候，应该通过一个循环去读取
                    while (true)
                    {
                        //返回本次读取实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);

                    }
                }
            }
        }
    }

}
