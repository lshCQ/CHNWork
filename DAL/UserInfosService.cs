using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using DAL;

namespace DAL
{
    public class UserInfosService
    {
        public UserInfos GetLogin(UserInfos user)
        {
            //sql语句
            string sql = "select id from UserInfos where UserName='{0}' and UserPassWord='{1}' ";
            sql = string.Format(sql,user.UserName,user.UserPassWord);

            //开始从数据库中查询
            SqlDataReader sdr = Help.SQLHelper.GetReader(sql);
            if (sdr.Read())
            {
                user.id = Convert.ToInt32(sdr["id"]);
            }
            else
            {
                user = null;//如果不成功，则清空当前对象
            }
            sdr.Close();//关闭读取器
            
            return user;

        }
    }
}
