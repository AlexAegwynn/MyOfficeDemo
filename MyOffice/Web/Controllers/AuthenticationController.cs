using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Web.ViewModels;

namespace Web.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 校验用户信息
        /// </summary>
        public JsonResult CheckUser(Vm_UserInfo vModel)
        {
            JsonResult json = new JsonResult();

            if (string.IsNullOrEmpty(vModel.UserName) || string.IsNullOrEmpty(vModel.Password))
            {
                json.Data = new { state = false, message = "用户名密码不能为空！" }; return json;
            }
            if (vModel.UserName != "admin" || vModel.Password != "000000")
            {
                json.Data = new { state = false, message = "用户名或密码错误！" }; return json;
            }

            vModel.UserKey = new Guid("00000000-0000-0000-0000-000000000000");
            vModel.RoleID = 0;
            vModel.UserID = "00000";

            Session["UserInfo"] = vModel;

            json.Data = new { state = true, message = "" };

            return json;
        }
    }
}