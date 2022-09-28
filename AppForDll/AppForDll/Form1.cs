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

        [DllImport("E:\\SystemProgramming\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll", CallingConvention = CallingConvention.StdCall)] //импорт C++ dll библиотеки
        public static extern int Add1(int val1, int val2);

        [DllImport("E:\\SystemProgramming\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll", CallingConvention = CallingConvention.StdCall)] //импорт C++ dll библиотеки
        public static extern int ReadTextFile( [MarshalAs(UnmanagedType.LPWStr)] string filePath );

        [DllImport("E:\\SystemProgramming\\DLL_Cpp\\x64\\Debug\\DLL_Cpp.dll", CallingConvention = CallingConvention.StdCall)] //импорт C++ dll библиотеки
        public static extern IntPtr GetFileContent([MarshalAs(UnmanagedType.LPWStr)] string filePath);

        [DllImport("E:\\SystemProgramming\\lazarus\\DLL_Delphi\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        public static extern int Add2(int val1, int val2);

        [DllImport("E:\\SystemProgramming\\lazarus\\DLL_Delphi\\DLL_Delphi.dll", CallingConvention = CallingConvention.StdCall)] //импорт lazarus dll библиотеки
        public static extern string GetFileContent_Delphi([MarshalAs(UnmanagedType.LPWStr)] string filePath);

        string filePath;

        private string GetFilePath()
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
            MessageBox.Show(Add1(a, b).ToString(), "Результат C++");

        }

        private void button_Lazarus_Click(object sender, EventArgs e) //функция сложение двух чисел с помощью lazarus dll библиотеки
        {

            int a = Int32.Parse(textBox_CPP1.Text);
            int b = Int32.Parse(textBox_CPP2.Text);
            MessageBox.Show(Add2(a, b).ToString(), "Результат Delphi");

        }

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            filePath = GetFilePath();
        }

        private void button_FileCpp_Click(object sender, EventArgs e)
        {
            try
            {
                filePath = textBox_FilePath.Text;
                IntPtr ptr = GetFileContent(filePath);
                string str = Marshal.PtrToStringBSTR(ptr);
                MessageBox.Show("Кол-во искомых строк: " + ReadTextFile(textBox_FilePath.Text).ToString()
                    + Environment.NewLine
                    + "Содержимое: "
                    + Environment.NewLine +
                    str, "Результат c++");
            }
            catch 
            {
                MessageBox.Show("Ошибка загрузки библиотеки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_fileDelphi_Click(object sender, EventArgs e)
        {
            filePath = textBox_FilePath.Text;
            GetFileContent_Delphi("E:\\SystemProgramming\\Files\\test.tsv");
            //MessageBox.Show(GetFileContent_Delphi(filePath).ToString());

            //IntPtr ptr = GetFileContent_Delphi(filePath);
            //string str = Marshal.PtrToStringBSTR(ptr);
            //MessageBox.Show( "Содержимое: "
            //    + Environment.NewLine +
            //    str, "Результат c++");
        }
    }
}
