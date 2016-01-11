using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个连接对象
            string strCon = "Data Source=.;Initial Catalog=MySchool2;User ID=sa;PassWord=hbh66";
            //SqlConnection con = new SqlConnection(strCon);
            //con.Open();//比较耗时的操作
            //con.Close();
            //con.Dispose();
            //如果一个类继承了IDisposable这个接口，就可以使用using帮助我们自动释放资源
            using (SqlConnection con = new SqlConnection(strCon))
            {
                //con.StateChange += con_StateChange;
                con.Open();
                string sql = "insert into Teacher (tName,tSex,tAge,tSalary) values ('罗永浩221','男',30,3000)";
                //创建sql语句sqlcommand对象
                SqlCommand cmd = new SqlCommand();
                //告诉cmd要执行的sql语句
                cmd.CommandText = sql;
                //告诉cmd对象连接通道
                cmd.Connection = con;

                //ExecuteNonquery();增删改
                //返回受影响的行数
                int r = cmd.ExecuteNonQuery();
                if (r>0)
                {
                    Console.WriteLine("操作成功");
                    Console.WriteLine("受影响的行数为"+r+"条");
                }

                //做一系列的操作
                //Close可以写也可以不写，因为当执行完using中的代码后，会执行对象的Dispose函数
                //con.Close();
            }
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 10000; i++)
            //{
            //    SqlConnection con = new SqlConnection(strCon);
            //    con.Open();
            //    //con.Close();
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);
        }

        private static void con_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            //Console.WriteLine(e.CurrentState);
        }
    }
}
