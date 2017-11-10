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
namespace SYStem
{
    public partial class mainForm : CCSkinMain
    {
        public mainForm()
        {
            InitializeComponent();
            //MDIClientSupport.SetBevel(this, false);
            this.ControlBox = false;
        }
        /// <summary>
        /// 检查打开的MDI窗口，是否打开，如有打开，激活即可，不做重复打开
        /// </summary>
        /// <param name="cform"></param>
        /// <returns></returns>
        private bool checkForm(Form cform)
        {
            foreach (Form sonform in this.MdiChildren)
            {
                if (sonform.Name == cform.Name)
                {
                    return false;
                }

            }
            return true;
        }
        private void userMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            userForm uform = new userForm();
            uform.MdiParent = this;
            uform.FormBorderStyle = FormBorderStyle.None;//边框属性
            uform.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            uform.TopLevel = false;
            uform.Show();
        }

        private void stuMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            stuForm cals = new stuForm();
            cals.MdiParent = this;
            cals.FormBorderStyle = FormBorderStyle.None;//边框属性
            cals.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            cals.TopLevel = false;
            cals.Show();
        }
        private void classMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            @class cals = new @class();
            cals.MdiParent = this;
            cals.FormBorderStyle = FormBorderStyle.None;//边框属性
            cals.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            cals.TopLevel = false;
            cals.Show();
        }

        private void testMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            testForm testMain = new testForm();
            testMain.MdiParent = this;
            testMain.FormBorderStyle = FormBorderStyle.None;//边框属性
            testMain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            testMain.TopLevel = false;
            testMain.Show();
        }

        private void temMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            temForm temmain = new temForm();
            temmain.MdiParent = this;
            temmain.FormBorderStyle = FormBorderStyle.None;//边框属性
            temmain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            temmain.TopLevel = false;
            temmain.Show();
        }

        private void menuSaomiao_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            saoMiaoForm saoMain = new saoMiaoForm();
            saoMain.MdiParent = this;
            saoMain.FormBorderStyle = FormBorderStyle.None;//边框属性
            saoMain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            saoMain.TopLevel = false;
            saoMain.Show();
        }

        private void menuScoring_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            yuejuanForm yueMain = new yuejuanForm();
            yueMain.MdiParent = this;
            yueMain.FormBorderStyle = FormBorderStyle.None;//边框属性
            yueMain.Dock = DockStyle.Fill;   //设置那个边框停靠父容器
            yueMain.TopLevel = false;
            yueMain.Show();
        }
        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
