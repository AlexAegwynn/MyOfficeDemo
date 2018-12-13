using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.ViewModels
{
    public class Vm_DepMgt
    {
        public string DmKey { get; set; } = string.Empty;

        public string DmID { get; set; } = string.Empty;

        public string DmName { get; set; } = string.Empty;

        public int DmState { get; set; } = 1;
    }
}