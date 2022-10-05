using AppForDll.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace AppForDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[DllImport("..\\..\\..\\..\\..\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll", CallingConvention = CallingConvention.StdCall)] //импорт C++ dll библиотеки
        //public static extern int AddCPP(int val1, int val2);

        //[DllImport("..\\..\\..\\..\\..\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll", CallingConvention = CallingConvention.StdCall)] //импорт C++ dll библиотеки
        //public static extern void ReadTextFileCPP([MarshalAs(UnmanagedType.LPWStr)] string filePath, [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);
#if false //lazarus
        [DllImport("..\\..\\..\\..\\..\\lazarus\\DLL_Delphi\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        public static extern string GetFileContent_Delphi([MarshalAs(UnmanagedType.LPWStr)] string filePath);

        [DllImport("..\\..\\..\\..\\..\\lazarus\\DLL_Delphi\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        public static extern int Add2(int val1, int val2);
#else //RAD
        //[DllImport("..\\..\\..\\..\\..\\RAD_DelphiDLL\\Win64\\Debug\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        //public static extern void ReadTextFile_Delphi([MarshalAs(UnmanagedType.LPWStr)] string filePath, [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);

        //[DllImport("..\\..\\..\\..\\..\\RAD_DelphiDLL\\Win64\\Debug\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        //public static extern int Add2(int val1, int val2);
#endif

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int AddCPP(int val1, int val2);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int AddDelphi(int val1, int val2);

        private delegate void ReadTextFileCPP([MarshalAs(UnmanagedType.LPWStr)] string filePath, 
            [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void ReadTextFileDelphi([MarshalAs(UnmanagedType.LPWStr)] string filePath,
            [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);

        private const string DllDelphiPath = 
            "..\\..\\..\\..\\..\\RAD_DelphiDLL\\Win64\\Debug\\DLL_Delphi.dll"; //RAD
        //private const string DllDelphiPath =
        //  "..\\..\\..\\..\\..\\lazarus\\DLL_Delphi\\DLL_Delphi.dll"; //Lazarus
        private const string DllCppPath = 
            "..\\..\\..\\..\\..\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll";


        private string GetFileName()
        {
            return textBox_FilePath.Text;
        } 
        
        private string GetFileDir()
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "tsv files (*.tsv)|*.tsv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                }
            }
            return filePath;
        }

        private void buttonCPP_Click(object sender, EventArgs e) //функция сложение двух чисел с помощью dll C++ библиотеки
        {
            IntPtr pDll = NativeMethods.LoadLibrary(DllCppPath);
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "AddCPP");
            if (pAddressOfFunctionToCall == IntPtr.Zero) { return; }
            AddCPP addCPP = (AddCPP)Marshal.GetDelegateForFunctionPointer(
                pAddressOfFunctionToCall, 
                typeof(AddCPP));

            int a = Int32.Parse(textBox_CPP1.Text);
            int b = Int32.Parse(textBox_CPP2.Text);
            MessageBox.Show(addCPP(a, b).ToString(), "Результат C++");

            NativeMethods.FreeLibrary(pDll);
        }

        private void button_Lazarus_Click(object sender, EventArgs e) //функция сложение двух чисел с помощью lazarus dll библиотеки
        {
            IntPtr pDll = NativeMethods.LoadLibrary(DllDelphiPath);
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "AddDelphi");
           // if (pAddressOfFunctionToCall == IntPtr.Zero) { return; }
            AddDelphi addDelphi = (AddDelphi)Marshal.GetDelegateForFunctionPointer(
                pAddressOfFunctionToCall,
                typeof(AddDelphi));

            int a = Int32.Parse(textBox_CPP1.Text);
            int b = Int32.Parse(textBox_CPP2.Text);
            MessageBox.Show(addDelphi(a, b).ToString(), "Результат Delphi");

            NativeMethods.FreeLibrary(pDll);
        }

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            textBox_FilePath.Text = GetFileDir();
        }

        private void button_FileCpp_Click(object sender, EventArgs e)
        {
            IntPtr pDll = NativeMethods.LoadLibrary(DllCppPath);
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "ReadTextFileCPP");
            if (pAddressOfFunctionToCall == IntPtr.Zero) { return; }
            ReadTextFileCPP readTextFileCPP = (ReadTextFileCPP)Marshal.GetDelegateForFunctionPointer(
                pAddressOfFunctionToCall,
                typeof(ReadTextFileCPP));

            string Text = "";
            int Count = 0;
            readTextFileCPP(GetFileName(), out Text, out Count);
            MessageBox.Show("Кол-во искомых строк = " + Count.ToString() 
                + Environment.NewLine +
                "Содержимое:" 
                + Environment.NewLine +
                Text, "Результат C++");

           NativeMethods.FreeLibrary(pDll);
        }

        private void button_fileDelphi_Click(object sender, EventArgs e)
        {
            IntPtr pDll = NativeMethods.LoadLibrary(DllDelphiPath);
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "ReadTextFileDelphi");
            if (pAddressOfFunctionToCall == IntPtr.Zero) { return; }
            ReadTextFileDelphi readTextFileDelphi = (ReadTextFileDelphi)Marshal.GetDelegateForFunctionPointer(
                pAddressOfFunctionToCall,
                typeof(ReadTextFileDelphi));

            string Text = "";
            int Count = 0;
            readTextFileDelphi(GetFileName(), out Text, out Count);
            MessageBox.Show("Кол-во искомых строк = " + Count.ToString()
                + Environment.NewLine +
                "Содержимое:"
                + Environment.NewLine +
                Text, "Результат Delphi");

            NativeMethods.FreeLibrary(pDll);
        }
    }
}
