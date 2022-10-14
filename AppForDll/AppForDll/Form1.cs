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
            tabControl1.SelectedIndex = 1;
        }

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


        private const string DllDelphiPath = 
            "..\\..\\..\\..\\..\\RAD_DelphiDLL\\Win64\\Debug\\DLL_Delphi.dll"; //RAD
        //private const string DllDelphiPath =
        //  "..\\..\\..\\..\\..\\lazarus\\DLL_Delphi\\DLL_Delphi.dll"; //Lazarus
        private const string DllCppPath = 
            "..\\..\\..\\..\\..\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll";

        private string GetFileName()
        {
            return textBox_FilePath.Text;
        }  //returns file path from textBox_FilePath

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
        } //Calls open file dialog and returns file path 

        private void buttonCPP_Click(object sender, EventArgs e)
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
        } //button handler which calls add function from unmanaged dll C++

        private void button_Lazarus_Click(object sender, EventArgs e)
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
        }  //button handler which calls add function from unmanaged dll Delphi

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            textBox_FilePath.Text = GetFileDir();
        } // button handler that calls GetFileDir()

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
        } //button handler which calls ReadTextFile function from unmanaged dll C++

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
        } //button handler which calls ReadTextFile function from unmanaged dll Delphi

        private void button_GetGraphicCPP_Click(object sender, EventArgs e)
        {
            IntPtr pDll = NativeMethods.LoadLibrary(DllCppPath);
            IntPtr pAddressOfFunctionToCall = NativeMethods.GetProcAddress(pDll, "GetGraphicCPP");
            if (pAddressOfFunctionToCall == IntPtr.Zero) { MessageBox.Show("error"); return; }
            GetGraphicCPP getGraphicCPP = (GetGraphicCPP)Marshal.GetDelegateForFunctionPointer(
                pAddressOfFunctionToCall,
                typeof(GetGraphicCPP));

            IntPtr MyBmp = IntPtr.Zero;
            int Width = Int32.Parse(textBox_Width.Text);
            int Height = Int32.Parse(textBox_Height.Text);
            getGraphicCPP(GetFileName(), Width, Height, out MyBmp);

            Bitmap bm = new Bitmap(Width, Height);
            bm = Image.FromHbitmap(MyBmp);
            bm.Save("E:\\SystemProgramming\\Files\\test.bmp");

            NativeMethods.FreeLibrary(pDll);
        }
    }
}
