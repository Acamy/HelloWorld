using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1216__FileStream读取写入数据
{
    class Program
    {
        static void Main(string[] args)
        {
            ////读取数据
            //using (FileStream fsRead=new FileStream(@"C:\Users\Acamy\Desktop\new.txt",FileMode.Open,FileAccess.ReadWrite))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];
            //    int r = fsRead.Read(buffer, 0, buffer.Length);
            //    string str=Encoding.Default.GetString(buffer,0,r);
            //    Console.WriteLine(str);
            //}

            //写入数据
            using (FileStream fsWrite=new FileStream(@"C:\Users\Acamy\Desktop\new1.txt",FileMode.Append,FileAccess.Write))
            {
                string str = "11";
                byte[] buffer = Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer,0,buffer.Length);
            }
            
        }
    }
}
