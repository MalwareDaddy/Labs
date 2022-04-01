using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace PWOP
{
    [ComVisible(true)]
    public class PWOP
    {
        public PWOP () {
        PowerShell ps1 = PowerShell.Create();
        ps1.AddScript("Start-Process calc.exe");
        ps1.Invoke();
        }
    }
}


