using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ModulesController : Controller
    {
        //Home 首页
        public PartialViewResult HomeModule()
        {
            return PartialView();
        }

        //Department management 部门管理
        public PartialViewResult DepMgtModule()
        {
            return PartialView();
        }

        //Staff management 员工管理
    }
}