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

        //Position management 职位管理
        public PartialViewResult PosMgtModule()
        {
            return PartialView();
        }

        //Staff management 员工管理
        public PartialViewResult StaffMgtModule()
        {
            return PartialView();
        }

        //My schedule 我的日程
        public PartialViewResult MySchModule()
        {
            return PartialView();
        }

        //Department schedule 部门日程
        public PartialViewResult DepSchModule()
        {
            return PartialView();
        }

        //MyNote 我的便签
        public PartialViewResult MyNoteModule()
        {
            return PartialView();
        }

        //Mail 信箱
        public PartialViewResult MailModule()
        {
            return PartialView();
        }

        //Message management 信息管理
        public PartialViewResult MsgMgtModule()
        {
            return PartialView();
        }
    }
}