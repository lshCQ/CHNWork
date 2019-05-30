using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace LoginAndRegiste.Controllers
{
    public class UserInfosController : Controller
    {
        // GET: UserInfos
        public ActionResult Index()
        {
            return View("UserInfosLogin");
        }

        public ActionResult UserLogin()
        {
            //获取用户输入的数据
            UserInfos user = new UserInfos()
            {
                UserName = Request.Params["UserName"],
                UserPassWord = Request.Params["UserPassWord"]
            };
            user = new UserInfosManger().UserLogin(user);
            if (user != null)
            {
                ViewData[""] = "欢迎您：" + user.UserName;
            }
            else
            {
                ViewData[""] = "Sorry,用户名或密码错误！";
            }
            return View();
        }
    }
}