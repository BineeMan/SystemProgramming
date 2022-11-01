using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppForDll.Utils.DllPaths;
using static AppForDll.Utils.ThreadWatcher;
using System.Xml.Linq;

namespace AppForDll.Utils
{
    public class UnmanagedFunctionsClass
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] //Add function delegate from unmanaged Dll Cpp
        private delegate int AddCPP(int val1, int val2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)] //Add function delegate from unmanaged Dll Delphi
        private delegate int AddDelphi(int val1, int val2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)] //read text file delegate from unmanaged Dll Cpp
        private delegate void ReadTextFileCPP([MarshalAs(UnmanagedType.LPWStr)] string filePath,
            [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)] //read text file delegate from unmanaged Dll Delphi
        private delegate void ReadTextFileDelphi([MarshalAs(UnmanagedType.LPWStr)] string filePath,
            [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void GetGraphicCPP([MarshalAs(UnmanagedType.LPWStr)] string filePath,
            int Width, int Height, out IntPtr MyBmb);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void ConvertTableToExcel([MarshalAs(UnmanagedType.LPWStr)] string filePath);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void PointsFromTsvToXml([MarshalAs(UnmanagedType.LPWStr)] string filePath,
            [MarshalAs(UnmanagedType.BStr)] out string Xml);

        public static void ExecuteUnmanagedAddCPP(int val1, int val2)
        {
            IntPtr pDll = NativeMethods.LoadLibrary(DllPath);
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "AddCPP");
            if (pAddressOfFunctionToCall == IntPtr.Zero) { return; }
            AddCPP addCPP = (AddCPP)Marshal.GetDelegateForFunctionPointer(
                pAddressOfFunctionToCall,
                typeof(AddCPP));
            Thread.Sleep(3000);
            int result = addCPP(val1, val2);
            NativeMethods.FreeLibrary(pDll);
            MessageBox.Show(result.ToString(), "Результат C++");
        }

        public static void ExecuteUnmanagedAddDelphi(int val1, int val2)
        {
            new Thread(() =>
            {
                IntPtr pDll = NativeMethods.LoadLibrary(DllDelphiPath);
                IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "AddDelphi");
                // if (pAddressOfFunctionToCall == IntPtr.Zero) { return; }
                AddDelphi addDelphi = (AddDelphi)Marshal.GetDelegateForFunctionPointer(
                    pAddressOfFunctionToCall,
                    typeof(AddDelphi));
                MessageBox.Show(addDelphi(val1, val2).ToString(), "Результат Delphi");
                NativeMethods.FreeLibrary(pDll);

            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Normal,
            }.Start();
        }

        public static void ExecuteUnmanagedReadTextFileCpp(string fileName, string Text, int Count)
        {
            new Thread(() =>
            {
                IntPtr pDll = NativeMethods.LoadLibrary(DllPath);
                IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "ReadTextFileCPP");
                if (pAddressOfFunctionToCall == IntPtr.Zero) { return; }
                ReadTextFileCPP readTextFileCPP = (ReadTextFileCPP)Marshal.GetDelegateForFunctionPointer(
                    pAddressOfFunctionToCall,
                    typeof(ReadTextFileCPP));

                readTextFileCPP(fileName, out Text, out Count);
                MessageBox.Show("Кол-во искомых строк = " + Count.ToString()
                    + Environment.NewLine +
                    "Содержимое:"
                    + Environment.NewLine +
                    Text, "Результат C++");

                NativeMethods.FreeLibrary(pDll);
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Normal,
            }.Start();
        }

        public static void ExecuteUnmanagedGetGraphicCpp(string fileName, int Width, int Height)
        {
            new Thread(() =>
            {
                IntPtr pDll = NativeMethods.LoadLibrary(DllPath);
                IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "GetGraphicCPP");
                if (pAddressOfFunctionToCall == IntPtr.Zero) { MessageBox.Show("error"); return; }
                GetGraphicCPP getGraphicCPP = (GetGraphicCPP)Marshal.GetDelegateForFunctionPointer(
                    pAddressOfFunctionToCall,
                    typeof(GetGraphicCPP));

                IntPtr MyBmp = IntPtr.Zero;

                getGraphicCPP(fileName, Width, Height, out MyBmp);

                Bitmap bm = new Bitmap(Width, Height);
                bm = Image.FromHbitmap(MyBmp);
                bm.Save(fileName + "\\..\\graphic.bmp");

                NativeMethods.FreeLibrary(pDll);
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Normal,
            }.Start();
        }

        public static void ExecuteUnmanagedReadTextFileDelphi(string fileName, string Text, int Count)
        {
            new Thread(() =>
            {
                IntPtr pDll = NativeMethods.LoadLibrary(DllDelphiPath);
                IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "ReadTextFileDelphi");
                if (pAddressOfFunctionToCall == IntPtr.Zero) { return; }
                ReadTextFileDelphi readTextFileDelphi = (ReadTextFileDelphi)Marshal.GetDelegateForFunctionPointer(
                    pAddressOfFunctionToCall,
                    typeof(ReadTextFileDelphi));

                readTextFileDelphi(fileName, out Text, out Count);

                MessageBox.Show("Кол-во искомых строк = " + Count.ToString()
                    + Environment.NewLine +
                    "Содержимое:"
                    + Environment.NewLine +
                    Text, "Результат Delphi");

                NativeMethods.FreeLibrary(pDll);
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Normal,
            }.Start();
        }

        public static void ExecuteUnmanagedGenerateExcelDelphi(string FileName)
        {
            new Thread(() =>
            {
                IntPtr pDll = NativeMethods.LoadLibrary(DllDelphiPath);
                IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "ConvertTableToExcel");
                if (pAddressOfFunctionToCall == IntPtr.Zero)
                {
                    MessageBox.Show("Ошибка Excel");
                    return;
                }
                ConvertTableToExcel convertTableToExcel = (ConvertTableToExcel)Marshal.GetDelegateForFunctionPointer(
                    pAddressOfFunctionToCall,
                typeof(ConvertTableToExcel));

                convertTableToExcel(FileName);
                MessageBox.Show("Успешно");
                NativeMethods.FreeLibrary(pDll);
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Normal,
            }.Start();
        }

        public static void ExecuteUnmanagedPointsFromTsvToXml(string FileName, string Xml)
        {
            new Thread(() =>
            {
                IntPtr pDll = NativeMethods.LoadLibrary(DllPath);
                IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "PointsFromTsvToXml");
                if (pAddressOfFunctionToCall == IntPtr.Zero)
                {
                    MessageBox.Show("Ошибка");
                    return;
                }
                PointsFromTsvToXml pointsFromTsvToXml = (PointsFromTsvToXml)Marshal.GetDelegateForFunctionPointer(
                    pAddressOfFunctionToCall,
                typeof(PointsFromTsvToXml));

                pointsFromTsvToXml(FileName, out Xml);
                XDocument doc = XDocument.Parse(Xml);
                MessageBox.Show(doc.ToString(), "Результат C++");
                NativeMethods.FreeLibrary(pDll);
            })
            {
                IsBackground = true,
                Priority = ThreadPriority.Normal,
            }.Start();
        }
    }
}
