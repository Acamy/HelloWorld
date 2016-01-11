using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace 增删改
{
    class Program
    {
        static void Main(string[] args)
        {
            string strCon = "Data Source=.;Initial Catalog=MySchool2;User ID=sa;PassWord=hbh66";
            
            
            using (SqlConnection con = new SqlConnection(strCon))
            {
                
                con.Open();

                //增删改语法
                string sql = "insert into Teacher (tName,tSex,tAge,tSalary) values"
                    + "('罗21','男',30,3000)";
                SqlCommand cmd = new SqlCommand(sql,con);                

                //ExecuteNonquery();增删改
                //返回受影响的行数
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    Console.WriteLine("操作成功");
                    Console.WriteLine("受影响的行数为" + r + "条");
                }
                              
                //查语法
                string sql1 = "select count(*) from Teacher";
                SqlCommand cmd1=new SqlCommand(sql1,con);
                int count = Convert.ToInt32(cmd1.ExecuteScalar());
                Console.WriteLine("表中一共有"+count+"个老师");
                
            }

           
            
        
        }
    }
}
