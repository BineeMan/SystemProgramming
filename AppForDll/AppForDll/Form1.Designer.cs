
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
            this.button_FileDelphi = new System.Windows.Forms.Button();
            this.button_FileCpp = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_ByteWith = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ширина = new System.Windows.Forms.Label();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_GetGraphicCPP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_CPP1
            // 
            this.textBox_CPP1.Location = new System.Drawing.Point(254, 71);
            this.textBox_CPP1.Name = "textBox_CPP1";
            this.textBox_CPP1.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPP1.TabIndex = 0;
            this.textBox_CPP1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сложение двух чисел через DLL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "C++";
            // 
            // button_AddCpp
            // 
            this.button_AddCpp.Location = new System.Drawing.Point(179, 198);
            this.button_AddCpp.Name = "button_AddCpp";
            this.button_AddCpp.Size = new System.Drawing.Size(75, 23);
            this.button_AddCpp.TabIndex = 3;
            this.button_AddCpp.Text = "Запуск";
            this.button_AddCpp.UseVisualStyleBackColor = true;
            this.button_AddCpp.Click += new System.EventHandler(this.buttonCPP_Click);
            // 
            // textBox_CPP2
            // 
            this.textBox_CPP2.Location = new System.Drawing.Point(254, 112);
            this.textBox_CPP2.Name = "textBox_CPP2";
            this.textBox_CPP2.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPP2.TabIndex = 4;
            this.textBox_CPP2.Text = "0";
            // 
            // button_AddDelphi
            // 
            this.button_AddDelphi.Location = new System.Drawing.Point(348, 198);
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
            this.label3.Location = new System.Drawing.Point(368, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delphi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 337);
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
            this.tabControl1.Size = new System.Drawing.Size(676, 355);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(668, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Лаб1 Сложение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "A";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.button_GetGraphicCPP);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Ширина);
            this.tabPage2.Controls.Add(this.textBox_Height);
            this.tabPage2.Controls.Add(this.textBox_Width);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button_FileDelphi);
            this.tabPage2.Controls.Add(this.button_FileCpp);
            this.tabPage2.Controls.Add(this.textBox_FilePath);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button_ChooseFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лаб2-3 ФайлГрафик";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_FileDelphi
            // 
            this.button_FileDelphi.Location = new System.Drawing.Point(118, 227);
            this.button_FileDelphi.Name = "button_FileDelphi";
            this.button_FileDelphi.Size = new System.Drawing.Size(89, 38);
            this.button_FileDelphi.TabIndex = 4;
            this.button_FileDelphi.Text = "Запуск Delphi";
            this.button_FileDelphi.UseVisualStyleBackColor = true;
            this.button_FileDelphi.Click += new System.EventHandler(this.button_fileDelphi_Click);
            // 
            // button_FileCpp
            // 
            this.button_FileCpp.Location = new System.Drawing.Point(26, 227);
            this.button_FileCpp.Name = "button_FileCpp";
            this.button_FileCpp.Size = new System.Drawing.Size(75, 38);
            this.button_FileCpp.TabIndex = 3;
            this.button_FileCpp.Text = "Запуск C++";
            this.button_FileCpp.UseVisualStyleBackColor = true;
            this.button_FileCpp.Click += new System.EventHandler(this.button_FileCpp_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(210, 49);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(293, 20);
            this.textBox_FilePath.TabIndex = 2;
            this.textBox_FilePath.Text = "E:\\SystemProgramming\\Files\\test.tsv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Чтение данных из файла";
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.Location = new System.Drawing.Point(285, 85);
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.Size = new System.Drawing.Size(118, 23);
            this.button_ChooseFile.TabIndex = 0;
            this.button_ChooseFile.Text = "Выбрать Файл";
            this.button_ChooseFile.UseVisualStyleBackColor = true;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_ByteWith);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Лаб3 Hbitmap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_ByteWith
            // 
            this.textBox_ByteWith.Location = new System.Drawing.Point(446, 95);
            this.textBox_ByteWith.Name = "textBox_ByteWith";
            this.textBox_ByteWith.Size = new System.Drawing.Size(46, 20);
            this.textBox_ByteWith.TabIndex = 16;
            this.textBox_ByteWith.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Генерирование графика";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Генерирование графика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Высота";
            // 
            // Ширина
            // 
            this.Ширина.AutoSize = true;
            this.Ширина.Location = new System.Drawing.Point(438, 191);
            this.Ширина.Name = "Ширина";
            this.Ширина.Size = new System.Drawing.Size(46, 13);
            this.Ширина.TabIndex = 23;
            this.Ширина.Text = "Ширина";
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(523, 168);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(46, 20);
            this.textBox_Height.TabIndex = 22;
            this.textBox_Height.Text = "9";
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(441, 168);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(46, 20);
            this.textBox_Width.TabIndex = 21;
            this.textBox_Width.Text = "64";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Работа с .tsv файлами и постройка графика\r\n";
            // 
            // button_GetGraphicCPP
            // 
            this.button_GetGraphicCPP.Location = new System.Drawing.Point(406, 227);
            this.button_GetGraphicCPP.Name = "button_GetGraphicCPP";
            this.button_GetGraphicCPP.Size = new System.Drawing.Size(106, 38);
            this.button_GetGraphicCPP.TabIndex = 26;
            this.button_GetGraphicCPP.Text = "Создать график\r\nC++\r\n";
            this.button_GetGraphicCPP.UseVisualStyleBackColor = true;
            this.button_GetGraphicCPP.Click += new System.EventHandler(this.button_GetGraphicCPP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 26);
            this.label10.TabIndex = 27;
            this.label10.Text = "Выводит содержимое\r\nуказанного файла";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 379);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_ChooseFile;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_FileCpp;
        private System.Windows.Forms.Button button_FileDelphi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ByteWith;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ширина;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_GetGraphicCPP;
        private System.Windows.Forms.Label label10;
    }
}

