using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using System.Configuration;
using System.Data;
using LoginSystem.Model;

namespace LoginSystem.DAL
{
    /// <summary>
    /// 根据用户名找人
    /// </summary>
    public class UserInfoDAL
    {
        private static readonly string connStr = "Data source=orcl;User=hebh;Password=tyinteplm";
        public UserInfo GetUserInfoByName(string userName)
        {
            string sql = "select * from userInfo where LoginUserName=@LoginUserName";
            using (OracleConnection conn = new OracleConnection(connStr))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    OracleDataAdapter da=new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    UserInfo userInfo=null;
                    if(dt.Rows.Count>0)
                    {
                        userInfo = new UserInfo();
                        LoadEntity(userInfo,dt.Rows[0]);
                    }
                    return userInfo;

                }
            }
        }
        private void LoadEntity(UserInfo userInfo,DataRow row)
        {
            userInfo.UserId = Convert.ToInt32(row["UserId"]);
            userInfo.LoginUserName = row["LoginUserName"].ToString();
            userInfo.Pwd = row["Pwd"].ToString();
        }
    }
}
