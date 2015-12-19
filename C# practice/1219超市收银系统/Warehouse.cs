using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1219超市收银系统
{
    class Warehouse
    {
        //List<ProductFather> list2 = new List<ProductFather>();
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有：" + item[0].Name + "," + "\t" + "有" + item.Count + "个，" + "\t" + "每个" + item[0].Price + "元" + "\t");
                
                         
            }
        }
        
        //list[0]存储Acer电脑
        //list[1]存储SamSung手机
        //list[2]存储酱油
        //list[3]存储香蕉
        /// <summary>
        /// 创建仓库对象的时候，向仓库中添加货架
        /// </summary>
        public Warehouse()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="type">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void JinPros(string strType,int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    //case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏基笔记本"));
                    //    break;
                    //case "SamSung": list[1].Add(new SamSung(Guid.NewGuid().ToString(), 2000, "棒子手机"));
                    //    break;
                    //case "JianYou": list[2].Add(new JianYou(Guid.NewGuid().ToString(), 10, "老抽酱油"));
                    //    break;
                    //case "Banana": list[3].Add(new Banana(Guid.NewGuid().ToString(), 50, "大香蕉"));
                    //    break;
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏基笔记本"));
                        break;
                    case "SamSung": list[1].Add(new SamSung(Guid.NewGuid().ToString(), 2000, "棒之手机"));
                        break;
                    case "JiangYou": list[2].Add(new JianYou(Guid.NewGuid().ToString(), 10, "老抽酱油"));
                        break;
                    case "Banana": list[3].Add(new Banana(Guid.NewGuid().ToString(), 50, "大香蕉"));
                        break;
                }
            }
        }
        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public ProductFather[] QuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung": pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JianYou": pros[i] = list[2][0];
                        list[3].RemoveAt(0);
                        break;
                    case "Banana": pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
                
            }
            return pros;
        }
        //存储货物
        //List<SamSung> listSum = new List<SamSung>();
        //List<Acer> listAcer = new List<Acer>();
        //List<Banana> listBanana = new List<Banana>();
        //List<JianYou> listJianYou=new List<JianYou>();
    }
}
