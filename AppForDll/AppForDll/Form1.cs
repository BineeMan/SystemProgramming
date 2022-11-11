using System;
using System.Threading;
using System.Windows.Forms;
using static AppForDll.Utils.UnmanagedFunctionsClass;

namespace AppForDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 0;
            FormHwnd = this.Handle;
            MessageBox.Show(FormHwnd.ToString());
        }

        public static IntPtr FormHwnd;

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
            int val1 = Int32.Parse(textBox_CPP1.Text);
            int val2 = Int32.Parse(textBox_CPP2.Text);

            bool isFunctionWorking = false;
            Button button = button_AddCpp;
            new Thread(() =>
            {
                isFunctionWorking = true;

                new Thread(() =>
                {
                    Thread.Sleep(1000);
                    if (isFunctionWorking)
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {
                            button.Enabled = false;
                        }));
                    }
                }).Start();

                ExecuteUnmanagedAddCPP(val1, val2);
                isFunctionWorking = false;
                BeginInvoke((MethodInvoker)(() =>
                {
                    button.Enabled = true;
                }));

            }).Start();

        } //button handler which calls add function from unmanaged dll C++
      
        private void button_Lazarus_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox_CPP1.Text);
            int b = Int32.Parse(textBox_CPP2.Text);
            bool isFunctionWorking = false;
            Button button = button_AddCpp;
            new Thread(() =>
            {
                isFunctionWorking = true;
                new Thread(() =>
                {
                    Thread.Sleep(1000);
                    if (isFunctionWorking)
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {
                            button.Enabled = false;
                        }));
                    }
                }).Start();

                ExecuteUnmanagedAddDelphi(a, b);
                isFunctionWorking = false;
                BeginInvoke((MethodInvoker)(() =>
                {
                    button.Enabled = true;
                }));

            }).Start();
            

        }  //button handler which calls add function from unmanaged dll Delphi

        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            textBox_FilePath.Text = GetFileDir();
        } // button handler that calls GetFileDir()

        private void button_FileCpp_Click(object sender, EventArgs e)
        {
            string Text= "";
            int Count = 0;
            ExecuteUnmanagedReadTextFileCpp(GetFileName(), Text, Count);    
        } //button handler which calls ReadTextFile function from unmanaged dll C++

        private void button_fileDelphi_Click(object sender, EventArgs e)
        {
            string Text = "";
            int Count = 0;
            ExecuteUnmanagedReadTextFileDelphi(GetFileName(), Text, Count);
        } //button handler which calls ReadTextFile function from unmanaged dll Delphi

        private void button_GetGraphicCPP_Click(object sender, EventArgs e)
        {
            int Width = Int32.Parse(textBox_Width.Text);
            int Height = Int32.Parse(textBox_Height.Text);
            ExecuteUnmanagedGetGraphicCpp(GetFileName(), Width, Height);
        }  

        private void button_GenerateExcelDelphi_Click(object sender, EventArgs e)
        {
            ExecuteUnmanagedGenerateExcelDelphi(GetFileName());
        }

        private void testFun()
        {
            //ThreadWatcher threadWatcher = new ThreadWatcher(test, )
            MessageBox.Show("test fun");
        }

        private void button_Xml_Click(object sender, EventArgs e)
        {
            string Xml = "";
            ExecuteUnmanagedPointsFromTsvToXml(GetFileName(), Xml);
        }

        private void GetHwnd_Click(object sender, EventArgs e)
        {
           MessageBox.Show(FormHwnd.ToString());
        }

        private void SetHwnd_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = this.Handle;
            //ExecuteUnmanagedSetHwnd(hWnd,);
            MessageBox.Show(hWnd.ToString());
            
        }
    }

}
