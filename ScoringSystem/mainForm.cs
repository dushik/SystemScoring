using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //MessageBox.Show(DAL.SQLHelper.connString);
        }

        private void menuSaomiao_Click(object sender, EventArgs e)
        {
            //saomiaoForm s = new saomiaoForm();
            //s.Show();
            saomiaoForm saoMain = new saomiaoForm();
            saoMain.FormBorderStyle = FormBorderStyle.None;//边框属性
            saoMain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            saoMain.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(saoMain);
            saoMain.Show();
        }

        private void 试卷标记位录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temForm temmain = new temForm();
            temmain.FormBorderStyle = FormBorderStyle.None;//边框属性
            temmain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            temmain.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(temmain);
            temmain.Show();
        }

        private void testMenuItem_Click(object sender, EventArgs e)
        {
            //test t = new test();
            //t.Show();
            testForm testMain = new testForm();
            testMain.FormBorderStyle = FormBorderStyle.None;//边框属性
            testMain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            testMain.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(testMain);
            testMain.Show();
        }

        private void menuSys_Click(object sender, EventArgs e)
        {

        }

        private void groupMenuItem_Click(object sender, EventArgs e)
        {
            @class classMain = new @class();
            classMain.FormBorderStyle = FormBorderStyle.None;//边框属性
            classMain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            classMain.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(classMain);
            classMain.Show();
        }

        private void menuScoring_Click(object sender, EventArgs e)
        {
            yueForm yueMain = new yueForm();
            yueMain.FormBorderStyle = FormBorderStyle.None;//边框属性
            yueMain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            yueMain.TopLevel = false;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(yueMain);
            yueMain.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Environment.Exit(0);
        }

        private void userMenuItem_Click(object sender, EventArgs e)
        {
            userForm uf = new userForm();
            //uf.FormBorderStyle = FormBorderStyle.None;//边框属性
            //uf.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            //uf.TopLevel = false;
            //this.mainPanel.Controls.Clear();
            //this.mainPanel.Controls.Add(uf);
            //uf.Show();
            uf.MdiParent = this;
            uf.Text = "子窗口";
            uf.WindowState = FormWindowState.Maximized;
            uf.Show();
        }
        /// <summary>
        /// 检查打开的MDI窗口，是否打开，如有打开，激活即可，不做重复打开
        /// </summary>
        /// <param name="cform"></param>
        /// <returns></returns>
        private bool checkForm(Form cform)
        {
            foreach(Form sonform in this.MdiChildren)
            {
                if (sonform.Name == cform.Name)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
