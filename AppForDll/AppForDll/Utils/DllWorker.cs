using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForDll.Utils
{
    internal class DllWorker
    {
        public DllWorker(string DllPath)
        {
            this.DllPath = DllPath;
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)] //Add function delegate from unmanaged Dll Cpp
        private delegate int AddCPP(int val1, int val2);

        private string DllPath;
        //private string unmanagedFunctionName;

        string[] unmanagedFunctionNames = { "AddCPP" };
        //AddCPP addCPP;

        public enum UnmanagedFunction
        {
            AddCPP,
            AddDelphi
        }

        void ExecuteAddCpp(int val1, int val2)
        {
            IntPtr pDll = NativeMethods.LoadLibrary(DllPath);
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "AddCPP");
            if (pAddressOfFunctionToCall == IntPtr.Zero)
            { 
                MessageBox.Show("error");
                return; 
            }
            AddCPP addCPP = (AddCPP)Marshal.GetDelegateForFunctionPointer(
                        pAddressOfFunctionToCall,
                        typeof(AddCPP));
            MessageBox.Show(addCPP(val1, val2).ToString(), "Результат C++");
            NativeMethods.FreeLibrary(pDll);
        }

        void OnThreadExecuting()
        {
            MessageBox.Show("New thread!");
        }

        public void ExecuteUnmanagedFunction(UnmanagedFunction idFunction)
        {
            new Thread(() =>
            {
                Action action = () =>
                {
                    int val1 = 1, val2 = 2;
                    ExecuteAddCpp(val1, val2);
                };
                action();

            }).Start();
        }
    }
}
