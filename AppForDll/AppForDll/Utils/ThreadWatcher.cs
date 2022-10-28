using AppForDll.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Image = System.Drawing.Image;
using static AppForDll.Utils.UnmanagedFunctionsClass;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AppForDll.Utils
{
    class ThreadWatcher
    {
        int time;
        Button button;
        Thread thread;
        public ThreadWatcher(Button myButton, int myTime)
        {
            time = myTime;
            button = myButton;
        }

        public void BeginTimer()
        {
            button.Enabled = true;
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(time);
                button.Enabled = false;
            });
        }

        public void StopTimer()
        {

        }
    }
}
