using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ModulesController : Controller
    {
        #region Home 首页
        //Home 首页
        public PartialViewResult HomeModule()
        {
            return PartialView("~/Views/Modules/Home/HomeModule.cshtml");
        }
        #endregion

        #region Personnel 人事管理
        //Department management 部门管理
        public PartialViewResult DepMgtModule()
        {
            return PartialView("~/Views/Modules/Personnel/DepMgtModule.cshtml");
        }

        //部门管理列表
        public PartialViewResult DepMgtList(int index = 0, string search = "")
        {
            return PartialView("~/Views/Modules/Personnel/DepMgtList.cshtml");
        }

        //Position management 职位管理
        public PartialViewResult PosMgtModule()
        {
            return PartialView("~/Views/Modules/Personnel/PosMgtModule.cshtml");
        }

        //职位管理列表
        public PartialViewResult PosMgtList(int index = 0, string search = "")
        {
            return PartialView("~/Views/Modules/Personnel/PosMgtList.cshtml");
        }

        //Staff management 员工管理
        public PartialViewResult StaffMgtModule()
        {
            return PartialView("~/Views/Modules/Personnel/StaffMgtModule.cshtml");
        }

        //员工管理列表
        public PartialViewResult StaffMgtList(int index = 0, string search = "")
        {
            return PartialView("~/Views/Modules/Personnel/StaffMgtList.cshtml");
        }
        #endregion

        #region Schedule 日程管理
        //My schedule 我的日程
        public PartialViewResult MySchModule()
        {
            return PartialView("~/Views/Modules/Schedule/MySchModule.cshtml");
        }

        //我的日程列表
        public PartialViewResult MySchList(int index = 0,string search = "")
        {
            return PartialView("~/Views/Modules/Schedule/MySchList.cshtml");
        }

        //Department schedule 部门日程
        public PartialViewResult DepSchModule()
        {
            return PartialView("~/Views/Modules/Schedule/DepSchModule.cshtml");
        }

        //部门日程列表
        public PartialViewResult DepSchList(int index = 0, string search = "")
        {
            return PartialView("~/Views/Modules/Schedule/DepSchList.cshtml");
        }

        //MyNote 我的便签
        public PartialViewResult MyNoteModule()
        {
            return PartialView("~/Views/Modules/Schedule/MyNoteModule.cshtml");
        }

        public PartialViewResult MyNoteList(int index = 0, string search = "")
        {
            return PartialView("~/Views/Modules/Schedule/MyNoteList.cshtml");
        }
        #endregion

        #region Notice and message 消息管理
        //Notice
        public PartialViewResult NoticeModule()
        {
            return PartialView("~/Views/Modules/NoticeAndMessage/NoticeModule.cshtml");
        }

        //Message management 消息管理
        public PartialViewResult MsgMgtModule()
        {
            return PartialView("~/Views/Modules/NoticeAndMessage/MsgMgtModule.cshtml");
        }
        #endregion

        #region System 系统管理
        //Role management 角色管理
        public PartialViewResult RoleMgtModule()
        {
            return PartialView("~/Views/Modules/System/RoleMgtModule.cshtml");
        }

        //ConLog 登录日志
        public PartialViewResult ConLogModule()
        {
            return PartialView("~/Views/Modules/System/ConLogModule.cshtml");
        }

        //Operation log 操作日志
        public PartialViewResult OpnLogModule()
        {
            return PartialView("~/Views/Modules/System/OpnLogModule.cshtml");
        }

        //Home management 首页管理
        public PartialViewResult HomeMgtModule()
        {
            return PartialView("~/Views/Modules/System/HomeMgtModule.cshtml");
        }
        #endregion

        #region Attendance 考勤管理
        //Sign in sign out 签到签退
        public PartialViewResult SisoModule()
        {
            return PartialView("~/Views/Modules/Attendance/SisoModule.cshtml");
        }

        //Attendance check 考勤查询
        public PartialViewResult AttnCheckModule()
        {
            return PartialView("~/Views/Modules/Attendance/AttnCheckModule.cshtml");
        }

        //Attendance statistics 考勤统计
        public PartialViewResult AttnStatModule()
        {
            return PartialView("~/Views/Modules/Attendance/AttnStatModule.cshtml");
        }
        #endregion
    }
}