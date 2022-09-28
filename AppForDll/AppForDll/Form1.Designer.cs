
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
            this.button_CPP = new System.Windows.Forms.Button();
            this.textBox_CPP2 = new System.Windows.Forms.TextBox();
            this.button_lazarus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_FileCpp = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.button_fileDelphi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // button_CPP
            // 
            this.button_CPP.Location = new System.Drawing.Point(179, 198);
            this.button_CPP.Name = "button_CPP";
            this.button_CPP.Size = new System.Drawing.Size(75, 23);
            this.button_CPP.TabIndex = 3;
            this.button_CPP.Text = "Запуск";
            this.button_CPP.UseVisualStyleBackColor = true;
            this.button_CPP.Click += new System.EventHandler(this.buttonCPP_Click);
            // 
            // textBox_CPP2
            // 
            this.textBox_CPP2.Location = new System.Drawing.Point(254, 112);
            this.textBox_CPP2.Name = "textBox_CPP2";
            this.textBox_CPP2.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPP2.TabIndex = 4;
            this.textBox_CPP2.Text = "0";
            // 
            // button_lazarus
            // 
            this.button_lazarus.Location = new System.Drawing.Point(348, 198);
            this.button_lazarus.Name = "button_lazarus";
            this.button_lazarus.Size = new System.Drawing.Size(75, 23);
            this.button_lazarus.TabIndex = 5;
            this.button_lazarus.Text = "Запуск";
            this.button_lazarus.UseVisualStyleBackColor = true;
            this.button_lazarus.Click += new System.EventHandler(this.button_Lazarus_Click);
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
            this.tabPage1.Controls.Add(this.button_CPP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button_lazarus);
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
            this.tabPage2.Controls.Add(this.button_fileDelphi);
            this.tabPage2.Controls.Add(this.button_FileCpp);
            this.tabPage2.Controls.Add(this.textBox_FilePath);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button_ChooseFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лаб2 Файл";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_FileCpp
            // 
            this.button_FileCpp.Location = new System.Drawing.Point(218, 171);
            this.button_FileCpp.Name = "button_FileCpp";
            this.button_FileCpp.Size = new System.Drawing.Size(75, 23);
            this.button_FileCpp.TabIndex = 3;
            this.button_FileCpp.Text = "Запуск C++";
            this.button_FileCpp.UseVisualStyleBackColor = true;
            this.button_FileCpp.Click += new System.EventHandler(this.button_FileCpp_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(188, 108);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(293, 20);
            this.textBox_FilePath.TabIndex = 2;
            this.textBox_FilePath.Text = "E:\\\\SystemProgramming\\\\Files\\\\test.tsv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Чтение данных из файла";
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.Location = new System.Drawing.Point(268, 69);
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.Size = new System.Drawing.Size(118, 23);
            this.button_ChooseFile.TabIndex = 0;
            this.button_ChooseFile.Text = "Выбрать Файл";
            this.button_ChooseFile.UseVisualStyleBackColor = true;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // button_fileDelphi
            // 
            this.button_fileDelphi.Location = new System.Drawing.Point(352, 171);
            this.button_fileDelphi.Name = "button_fileDelphi";
            this.button_fileDelphi.Size = new System.Drawing.Size(89, 23);
            this.button_fileDelphi.TabIndex = 4;
            this.button_fileDelphi.Text = "Запуск Delphi";
            this.button_fileDelphi.UseVisualStyleBackColor = true;
            this.button_fileDelphi.Click += new System.EventHandler(this.button_fileDelphi_Click);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox_CPP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CPP;
        private System.Windows.Forms.TextBox textBox_CPP2;
        private System.Windows.Forms.Button button_lazarus;
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
        private System.Windows.Forms.Button button_fileDelphi;
    }
}

