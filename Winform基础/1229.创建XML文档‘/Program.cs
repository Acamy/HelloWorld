using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace _1229.创建XML文档_
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过代码来创建XML文档
            //1.引用命名空间
            //2.创建XML文档对象
            XmlDocument doc = new XmlDocument();
            //创建第一个描述信息，并且添加到doc文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0","utf-8",null);
            doc.AppendChild(dec);
            //4.创建根节点,并且添加到文档中
            XmlElement books = doc.CreateElement("Books");
            doc.AppendChild(books);
            
            //5.给根节点创建子节点
            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);

            //给Book1添加子节点
            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "金瓶梅";
            book1.AppendChild(name1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "10";
            book1.AppendChild(price1);

            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "好看";
            book1.AppendChild(des1);

            //给Book1添加另一个子节点
            XmlElement book2 = doc.CreateElement("Book");
            books.AppendChild(book2);

            XmlElement name2 = doc.CreateElement("Name");
            name2.InnerText = "金瓶梅";
            book2.AppendChild(name2);

            XmlElement price2 = doc.CreateElement("Price");
            price2.InnerText = "10";
            book2.AppendChild(price2);

            XmlElement des2 = doc.CreateElement("Des");
            des2.InnerText = "好看";
            book2.AppendChild(des2);

            //给Book1添加另一个子节点
            XmlElement order = doc.CreateElement("Order");
            books.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "何宝华";
            order.AppendChild(customerName);

            XmlElement customerNumber = doc.CreateElement("CustomerNumber");
            customerNumber.InnerText = "3";
            order.AppendChild(customerNumber);;

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem1.SetAttribute("Name", "码表");
            orderItem1.SetAttribute("Count", "10");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem2.SetAttribute("Name", "U盘");
            orderItem2.SetAttribute("Count", "2");
            items.AppendChild(orderItem2);           
           

            doc.Save("books.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
            
        }
    }
}
