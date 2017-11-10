using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYStem
{
    public partial class subForm : CCSkinMain
    {
        public subForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
