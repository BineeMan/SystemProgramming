using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForDll
{
    public partial class FormProgressBar : Form
    {
        public FormProgressBar()
        {
            InitializeComponent();
        }

        public void SetProgressBarValue(int value)
        {
            progressBar.Value = value;
        }

    }
}
