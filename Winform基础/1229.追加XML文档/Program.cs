using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace _1229.追加XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement books;
            //追加XML文档
            if (File.Exists("books.xml"))
            {
                //如果文件存在，加载XML
                doc.Load("books.xml");
                //获得文件的根节点
                books = doc.DocumentElement;
            }
            else
            {
                //如果文件不存在
                //创建第一行
                XmlDeclaration dec1 = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec1);
                //创建根节点
                books = doc.CreateElement("Books");
                doc.AppendChild(books);
            }

            XmlElement book3 = doc.CreateElement("Book");
            books.AppendChild(book3);

            XmlElement name3 = doc.CreateElement("Name");
            name3.InnerText = "C#基础";
            book3.AppendChild(name3);

            XmlElement price3 = doc.CreateElement("Price");
            price3.InnerText = "10";
            book3.AppendChild(price3);

            XmlElement des3 = doc.CreateElement("Des");
            des3.InnerText = "好看";
            book3.AppendChild(des3);


            doc.Save("books.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
}
