using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoginSystem.DAL;
using LoginSystem.Model;

namespace LoginSystem.BLL
{
     
    public class UserInfoBLL
    {
        UserInfoDAL dal = new UserInfoDAL();

        /// <summary>
        /// 校验用户名和密码是否正确
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPwd"></param>
        /// <returns></returns>
        public bool UserLogin(string userName,string userPwd,out string msg)
        {
            UserInfo userInfo = dal.GetUserInfoByName(userName);
            if (userInfo!=null)
            {
                if (userInfo.Pwd==userPwd)
                {
                    msg = "登录成功！！";
                    return true;
                }
                else
                {
                    msg = "密码错误!!";
                    return false;
                }
            }
            else
            {
                msg = "用户不存在！！";
                return false;
            }
        }
    }
}
