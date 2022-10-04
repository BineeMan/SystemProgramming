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

        [DllImport("..\\..\\..\\..\\..\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll", CallingConvention = CallingConvention.StdCall)] //импорт C++ dll библиотеки
        public static extern int AddCPP(int val1, int val2);

        [DllImport("..\\..\\..\\..\\..\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll", CallingConvention = CallingConvention.StdCall)] //импорт C++ dll библиотеки
        public static extern void ReadTextFileCPP([MarshalAs(UnmanagedType.LPWStr)] string filePath, [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);
#if false //lazarus
        [DllImport("..\\..\\..\\..\\..\\lazarus\\DLL_Delphi\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        public static extern string GetFileContent_Delphi([MarshalAs(UnmanagedType.LPWStr)] string filePath);

        [DllImport("..\\..\\..\\..\\..\\lazarus\\DLL_Delphi\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        public static extern int Add2(int val1, int val2);
#else //RAD
        [DllImport("..\\..\\..\\..\\..\\RAD_DelphiDLL\\Win64\\Debug\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        public static extern void ReadTextFile_Delphi([MarshalAs(UnmanagedType.LPWStr)] string filePath, [MarshalAs(UnmanagedType.BStr)] out string Text, out int Count);

        [DllImport("..\\..\\..\\..\\..\\RAD_DelphiDLL\\Win64\\Debug\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        public static extern int Add2(int val1, int val2);

        //static class NativeMethods
        //{
        //    [DllImport("kernel32.dll")]
        //    public static extern IntPtr LoadLibrary(string dllToLoad);
        //    [DllImport("kernel32.dll")]
        //    public static extern IntPtr GetProcAddress(IntPtr hModule, string
        //    procedureName);
        //    [DllImport("kernel32.dll")]
        //    public static extern bool FreeLibrary(IntPtr hModule);
        //
        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //private delegate int MultiplyByTen(int numberToMultiply);
#endif
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

            int a = Int32.Parse(textBox_CPP1.Text);
            int b = Int32.Parse(textBox_CPP2.Text);
            MessageBox.Show(AddCPP(a, b).ToString(), "Результат C++");

        }

        private void button_Lazarus_Click(object sender, EventArgs e) //функция сложение двух чисел с помощью lazarus dll библиотеки
        {
            int a = Int32.Parse(textBox_CPP1.Text);
            int b = Int32.Parse(textBox_CPP2.Text);
            MessageBox.Show(Add2(a, b).ToString(), "Результат Delphi");
        }

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            textBox_FilePath.Text = GetFileDir();
        }

        private void button_FileCpp_Click(object sender, EventArgs e)
        {
            string Text = "";
            int Count = 0;
            ReadTextFileCPP(GetFileName(), out Text, out Count);
            MessageBox.Show("Кол-во искомых строк = " + Count.ToString() 
                + Environment.NewLine +
                "Содержимое:" 
                + Environment.NewLine +
                Text, "Результат C++");
        }

        private void button_fileDelphi_Click(object sender, EventArgs e)
        {
            string Text = "";
            int Count = 0;
            ReadTextFile_Delphi(GetFileName(), out Text, out Count);
            MessageBox.Show("Кол-во искомых строк = " + Count.ToString()
                + Environment.NewLine +
                "Содержимое:"
                + Environment.NewLine +
                Text, "Результат Delphi");
        }
    }
}
