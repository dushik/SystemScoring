using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace ScoringSys
{
    public partial class mainWindow : CCSkinMain
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void menuSys_Click(object sender, EventArgs e)
        {

        }

        private void menuSaomiao_Click(object sender, EventArgs e)
        {
            saomiaoForm sao = new saomiaoForm();
            sao.Show();
        }

        private void menuYuejuan_Click(object sender, EventArgs e)
        {

        }

        private void menuScore_Click(object sender, EventArgs e)
        {

        }

        private void menuHelp_Click(object sender, EventArgs e)
        {

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void skinGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void skinTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
