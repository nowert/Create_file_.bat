using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"E:\1. work\ฝีกงาน\test file KIOSK.bat";

                File.Create(path).Dispose();

                using (TextWriter create = new StreamWriter(path))
                {
                create.WriteLine("@echo off");
                create.WriteLine("set path=%1 %2 %3");
                create.WriteLine(":วนลูปตัดค่าเป็น 2 ค่า");
                create.WriteLine("for /f "+"\"tokens=1* delims=-\""+" %%a in ("+"\"%path%\""+ ") do (");
                create.WriteLine("set partF=%%a");
                create.WriteLine("set partD=%%b");
                create.WriteLine(")");
                create.WriteLine(":ตัดค่าช่องว่างด้านหลัง"+" drive");
                create.WriteLine("set partD=%partD%##");
                create.WriteLine("set partD=%partD:                ##=##%");
                create.WriteLine("set partD=%partD:        ##=##%");
                create.WriteLine("set partD=%partD:    ##=##%");
                create.WriteLine("set partD=%partD:  ##=##%");
                create.WriteLine("set partD=%partD: ##=##%");
                create.WriteLine("set partD=%partD:##=%");
                create.WriteLine("");
                create.WriteLine("RMDIR /s /q "+ "\""+"%partF%\\PEA_Kiosk\\"+ "\"");
                create.WriteLine("");
                create.WriteLine("cd /d %partF%\\PEA_Kiosk");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+"\""+"%partD%PEASmartQ\\PEASmartQ\\Program\\PEA_Kiosk_USB "+"\"" +"\""+"%partF%\\PEA_Kiosk\\"+"\""+" /e /y");
                create.WriteLine("");
                create.WriteLine("del "+"\"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\*Kiosk_Project *.lnk\"");
                create.WriteLine("del "+"\"C:\\Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\*Kiosk_Project *.lnk\"");
                create.WriteLine("del "+"\" % USERPROFILE %\\Desktop\\*Kiosk_Project *.lnk\"");
                create.WriteLine("del "+"\" % USERPROFILE %\\Start Menu\\Programs\\Startup\\*Kiosk_Project *.lnk\"");
                create.WriteLine("");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+"\" %partD%PEASmartQ\\PEASmartQ\\Program\\Shortcut\\CutPEA_Kiosk_Project.lnk\""+"\" C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\\""+" /s /y ");
                create.WriteLine("");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+"\" %partD%PEASmartQ\\PEASmartQ\\Program\\Shortcut\\CutPEA_Kiosk_Project.lnk\""+"\" C:\\Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\\""+" /s /y");
                create.WriteLine("");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+"\" %partD%PEASmartQ\\PEASmartQ\\Program\\Shortcut\\CutPEA_Kiosk_Project.lnk\""+"\" %USERPROFILE%\\Desktop\\\""+" /s /y");
                create.WriteLine("");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+"\" %partD%PEASmartQ\\PEASmartQ\\Program\\Shortcut\\CutPEA_Kiosk_Project.lnk\""+"\" %USERPROFILE%\\Start Menu\\Programs\\Startup\""+" /s /y");
                create.WriteLine("");
                create.WriteLine("start "+"\"\""+"\"%USERPROFILE%\\Start Menu\\Programs\\Startup\\CutPEA_Kiosk_Project.exe\""+" /s /y");         
                create.Close();
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"E:\1. work\ฝีกงาน\test file PEAQClient.bat";

            File.Create(path).Dispose();

            using (TextWriter create = new StreamWriter(path))
            {
                create.WriteLine("@echo off");
                create.WriteLine("set path=%1 %2 %3");
                create.WriteLine(":วนลูปตัดค่าเป็น 2 ค่า");
                create.WriteLine("for /f " + "\"tokens=1* delims=-\"" + " %%a in (" + "\"%path%\"" + ") do (");
                create.WriteLine("set partF=%%a");
                create.WriteLine("set partD=%%b");
                create.WriteLine(")");
                create.WriteLine(":ตัดค่าช่องว่างด้านหลัง" + " drive");
                create.WriteLine("set partD=%partD%##");
                create.WriteLine("set partD=%partD:                ##=##%");
                create.WriteLine("set partD=%partD:        ##=##%");
                create.WriteLine("set partD=%partD:    ##=##%");
                create.WriteLine("set partD=%partD:  ##=##%");
                create.WriteLine("set partD=%partD: ##=##%");
                create.WriteLine("set partD=%partD:##=%");
                create.WriteLine("");
                create.WriteLine("RMDIR /s /q " + "\"" + "%partF%\\PEA_Kiosk\\" + "\"");
                create.WriteLine("");
                create.WriteLine("cd /d %partF%\\PEAQClient");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+"\" %partD%PEASmartQ\\PEASmartQ\\Program\\PEAQClient\""+ "\"%partF%\\PEAQClient\\\""+ " /e /y");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+"\" %partD%PEASmartQ\\PEASmartQ\\Program\\PEA_Server\\QPatchClient\""+ "\"%partF%\\QPatchClient\\\""+" /e /y");
                create.WriteLine("");
                create.WriteLine("cd /d C:\\Program Files\\");
                create.WriteLine("md Avanade\\BPMClient\\Queuedata");
                create.WriteLine("");
                create.WriteLine("del "+"\"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\*STK - M01 *.lnk\"");
                create.WriteLine("del "+"\"C:\\Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\*STK - M01 *.lnk\"");
                create.WriteLine("del "+"\" %USERPROFILE%\\*STK - M01 *.lnk\"");
                create.WriteLine("del "+"\" %USERPROFILE%\\Start Menu\\Programs\\Startup\\*STK - M01 *.lnk\"");
                create.WriteLine("Start "+"\" %USERPROFILE%\\destop\\PEAQClient.exe\"");
                create.WriteLine("");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+ "\" %partD%PEASmartQ\\PEASmartQ\\Program\\Shortcut\\PEAQClient.lnk\""+ "\"%USERPROFILE%\\Desktop\\\""+" /s /y");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+ "\" %partD%PEASmartQ\\PEASmartQ\\Program\\Shortcut\\QPatchClient.lnk\""+ "\"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\\""+" /s /y ");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+ "\" %partD%PEASmartQ\\PEASmartQ\\Program\\Shortcut\\QPatchClient.lnk\""+ "\"C:\\Documents and Settings\\All Users\\Start Menu\\Programs\\Startup\\\""+" /s /y");
                create.WriteLine("%systemroot%\\System32\\XCOPY "+ "\" %partD%PEASmartQ\\PEASmartQ\\Program\\Shortcut\\QPatchClient.lnk\""+ "\"%USERPROFILE%\\Start Menu\\Programs\\Startup\""+" /s /y");
                create.WriteLine("");
                create.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"E:\1. work\ฝีกงาน\test file Server.bat";

            File.Create(path).Dispose();

            using (TextWriter create = new StreamWriter(path))
            {
                create.WriteLine("@echo off");
                create.WriteLine("set path=%1 %2 %3");
                create.WriteLine(":วนลูปตัดค่าเป็น 2 ค่า");
                create.WriteLine("for /f " + "\"tokens=1* delims=-\"" + " %%a in (" + "\"%path%\"" + ") do (");
                create.WriteLine("set partF=%%a");
                create.WriteLine("set partD=%%b");
                create.WriteLine(")");
                create.WriteLine(":ตัดค่าช่องว่างด้านหลัง" + " drive");
                create.WriteLine("set partD=%partD%##");
                create.WriteLine("set partD=%partD:                ##=##%");
                create.WriteLine("set partD=%partD:        ##=##%");
                create.WriteLine("set partD=%partD:    ##=##%");
                create.WriteLine("set partD=%partD:  ##=##%");
                create.WriteLine("set partD=%partD: ##=##%");
                create.WriteLine("set partD=%partD:##=%");
                create.WriteLine("");
            }
        }

        private void btnmove_Click(object sender, EventArgs e)
        {
            Process.Start("E:\\1. work\\ฝีกงาน\\ตัวอย่าง - Copy\\PEASmartQ\\PEASmartQ\\Copytest.bat");
        }
    }
}