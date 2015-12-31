using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace 读取XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            //加载要读取的XML文档
            doc.Load("books.xml");

            //获得根节点
            XmlElement books = doc.DocumentElement;

            //获得子节点，返回节点的集合
            XmlNodeList xnl = books.ChildNodes;
            foreach (XmlNode item in xnl)
            {
                Console.WriteLine(item.InnerText);
            }
            XmlNodeList xnl1 = doc.SelectNodes("/Books/Order/Items/OrderItem");
            foreach (XmlNode item in xnl1)
            {
                 Console.WriteLine(item.Attributes["Name"].Value);
                 Console.WriteLine(item.Attributes["Count"].Value);
            }
            Console.WriteLine("modify");

            //删除节点
            //单个
            XmlNode xn = doc.SelectSingleNode("/Books/Book/Price");
            xn.RemoveAll();
            //多个
            XmlNodeList xns = doc.SelectNodes("/Books/Book/Name");
            foreach (XmlNode item in xns)
            {
                item.RemoveAll();
            }
            doc.Save("books.xml");
        }
    }
}
