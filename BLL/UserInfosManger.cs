using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
using System.Web;

namespace BLL
{
    public class UserInfosManger
    {
        private UserInfosService uis = new UserInfosService();

        public UserInfos UserLogin(UserInfos user)
        {
            user = uis.GetLogin(user);
            if (user!=null)
            {
                //将对象保存到session
                HttpContext.Current.Session["UserName"]= user;
            }
            return user;
        }
    }
}
