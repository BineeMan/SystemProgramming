﻿
namespace AppForDll
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_CPP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AddCpp = new System.Windows.Forms.Button();
            this.textBox_CPP2 = new System.Windows.Forms.TextBox();
            this.button_AddDelphi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Xml = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_GenerateExcelDelphi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_GetGraphicCPP = new System.Windows.Forms.Button();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.Ширина = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_FileDelphi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_FileCpp = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SetHwnd = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GetHwnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_CPP1
            // 
            this.textBox_CPP1.Location = new System.Drawing.Point(351, 118);
            this.textBox_CPP1.Name = "textBox_CPP1";
            this.textBox_CPP1.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPP1.TabIndex = 0;
            this.textBox_CPP1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сложение двух чисел через DLL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "C++";
            // 
            // button_AddCpp
            // 
            this.button_AddCpp.Location = new System.Drawing.Point(276, 245);
            this.button_AddCpp.Name = "button_AddCpp";
            this.button_AddCpp.Size = new System.Drawing.Size(75, 23);
            this.button_AddCpp.TabIndex = 3;
            this.button_AddCpp.Text = "Запуск";
            this.button_AddCpp.UseVisualStyleBackColor = true;
            this.button_AddCpp.Click += new System.EventHandler(this.buttonCPP_Click);
            // 
            // textBox_CPP2
            // 
            this.textBox_CPP2.Location = new System.Drawing.Point(351, 159);
            this.textBox_CPP2.Name = "textBox_CPP2";
            this.textBox_CPP2.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPP2.TabIndex = 4;
            this.textBox_CPP2.Text = "0";
            // 
            // button_AddDelphi
            // 
            this.button_AddDelphi.Location = new System.Drawing.Point(445, 245);
            this.button_AddDelphi.Name = "button_AddDelphi";
            this.button_AddDelphi.Size = new System.Drawing.Size(75, 23);
            this.button_AddDelphi.TabIndex = 5;
            this.button_AddDelphi.Text = "Запуск";
            this.button_AddDelphi.UseVisualStyleBackColor = true;
            this.button_AddDelphi.Click += new System.EventHandler(this.button_Lazarus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delphi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Плахотин Егор 903а1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(31, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 487);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox_CPP1);
            this.tabPage1.Controls.Add(this.textBox_CPP2);
            this.tabPage1.Controls.Add(this.button_AddCpp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button_AddDelphi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Лаб1 Сложение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "A";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox_FilePath);
            this.tabPage2.Controls.Add(this.button_ChooseFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лаб2,3,4 ФайлГрафик";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_Xml);
            this.groupBox4.Location = new System.Drawing.Point(292, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 127);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Генерирование XML файла";
            // 
            // button_Xml
            // 
            this.button_Xml.Location = new System.Drawing.Point(68, 50);
            this.button_Xml.Name = "button_Xml";
            this.button_Xml.Size = new System.Drawing.Size(113, 49);
            this.button_Xml.TabIndex = 0;
            this.button_Xml.Text = "Сгенерировать XML файл";
            this.button_Xml.UseVisualStyleBackColor = true;
            this.button_Xml.Click += new System.EventHandler(this.button_Xml_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_GenerateExcelDelphi);
            this.groupBox3.Location = new System.Drawing.Point(608, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 138);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Генерирование Excel таблицы";
            // 
            // button_GenerateExcelDelphi
            // 
            this.button_GenerateExcelDelphi.Location = new System.Drawing.Point(58, 50);
            this.button_GenerateExcelDelphi.Name = "button_GenerateExcelDelphi";
            this.button_GenerateExcelDelphi.Size = new System.Drawing.Size(114, 46);
            this.button_GenerateExcelDelphi.TabIndex = 0;
            this.button_GenerateExcelDelphi.Text = "Сгенерировать Excel Таблицу";
            this.button_GenerateExcelDelphi.UseVisualStyleBackColor = true;
            this.button_GenerateExcelDelphi.Click += new System.EventHandler(this.button_GenerateExcelDelphi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_GetGraphicCPP);
            this.groupBox2.Controls.Add(this.textBox_Width);
            this.groupBox2.Controls.Add(this.textBox_Height);
            this.groupBox2.Controls.Add(this.Ширина);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(290, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 138);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Генерирование графика";
            // 
            // button_GetGraphicCPP
            // 
            this.button_GetGraphicCPP.Location = new System.Drawing.Point(77, 77);
            this.button_GetGraphicCPP.Name = "button_GetGraphicCPP";
            this.button_GetGraphicCPP.Size = new System.Drawing.Size(106, 38);
            this.button_GetGraphicCPP.TabIndex = 26;
            this.button_GetGraphicCPP.Text = "Создать график\r\nC++\r\n";
            this.button_GetGraphicCPP.UseVisualStyleBackColor = true;
            this.button_GetGraphicCPP.Click += new System.EventHandler(this.button_GetGraphicCPP_Click);
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(72, 27);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(46, 20);
            this.textBox_Width.TabIndex = 21;
            this.textBox_Width.Text = "500";
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(154, 27);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(46, 20);
            this.textBox_Height.TabIndex = 22;
            this.textBox_Height.Text = "500";
            // 
            // Ширина
            // 
            this.Ширина.AutoSize = true;
            this.Ширина.Location = new System.Drawing.Point(67, 50);
            this.Ширина.Name = "Ширина";
            this.Ширина.Size = new System.Drawing.Size(46, 13);
            this.Ширина.TabIndex = 23;
            this.Ширина.Text = "Ширина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Высота";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_FileDelphi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button_FileCpp);
            this.groupBox1.Location = new System.Drawing.Point(20, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 138);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Чтение данных из файла";
            // 
            // button_FileDelphi
            // 
            this.button_FileDelphi.Location = new System.Drawing.Point(118, 77);
            this.button_FileDelphi.Name = "button_FileDelphi";
            this.button_FileDelphi.Size = new System.Drawing.Size(89, 38);
            this.button_FileDelphi.TabIndex = 4;
            this.button_FileDelphi.Text = "Запуск Delphi";
            this.button_FileDelphi.UseVisualStyleBackColor = true;
            this.button_FileDelphi.Click += new System.EventHandler(this.button_fileDelphi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 26);
            this.label10.TabIndex = 27;
            this.label10.Text = "Выводит содержимое\r\nуказанного файла";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_FileCpp
            // 
            this.button_FileCpp.Location = new System.Drawing.Point(26, 77);
            this.button_FileCpp.Name = "button_FileCpp";
            this.button_FileCpp.Size = new System.Drawing.Size(75, 38);
            this.button_FileCpp.TabIndex = 3;
            this.button_FileCpp.Text = "Запуск C++";
            this.button_FileCpp.UseVisualStyleBackColor = true;
            this.button_FileCpp.Click += new System.EventHandler(this.button_FileCpp_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Работа с .tsv файлами и постройка графика\r\n";
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(292, 54);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(293, 20);
            this.textBox_FilePath.TabIndex = 2;
            this.textBox_FilePath.Text = "E:\\SystemProgramming\\Files\\test.tsv";
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.Location = new System.Drawing.Point(367, 90);
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.Size = new System.Drawing.Size(118, 23);
            this.button_ChooseFile.TabIndex = 0;
            this.button_ChooseFile.Text = "Выбрать Файл";
            this.button_ChooseFile.UseVisualStyleBackColor = true;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Лаб3 Hbitmap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SetHwnd
            // 
            this.SetHwnd.Location = new System.Drawing.Point(918, 155);
            this.SetHwnd.Name = "SetHwnd";
            this.SetHwnd.Size = new System.Drawing.Size(75, 23);
            this.SetHwnd.TabIndex = 10;
            this.SetHwnd.Text = "SetHwnd";
            this.SetHwnd.UseVisualStyleBackColor = true;
            this.SetHwnd.Click += new System.EventHandler(this.SetHwnd_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(620, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(134, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // GetHwnd
            // 
            this.GetHwnd.Location = new System.Drawing.Point(918, 195);
            this.GetHwnd.Name = "GetHwnd";
            this.GetHwnd.Size = new System.Drawing.Size(75, 23);
            this.GetHwnd.TabIndex = 11;
            this.GetHwnd.Text = "GetHwnd";
            this.GetHwnd.UseVisualStyleBackColor = true;
            this.GetHwnd.Click += new System.EventHandler(this.GetHwnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 524);
            this.Controls.Add(this.GetHwnd);
            this.Controls.Add(this.SetHwnd);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "DllImporter";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox_CPP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_AddCpp;
        private System.Windows.Forms.TextBox textBox_CPP2;
        private System.Windows.Forms.Button button_AddDelphi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ChooseFile;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_FileCpp;
        private System.Windows.Forms.Button button_FileDelphi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ширина;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_GetGraphicCPP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_GenerateExcelDelphi;
        private System.Windows.Forms.Button SetHwnd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Xml;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button GetHwnd;
    }
}

