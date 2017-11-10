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
    public partial class Login : CCSkinMain
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            loginFunction();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void loginFunction()
        {
            string username = usernameTBox.Text.Trim();
            string password = passwordTBox.Text;
            if (string.IsNullOrEmpty(username))
            {
                //ef.lblTitle.Text = "登录错误：";
                //ef.lblMsg.Text = "必须填写用户名";
                //ef.ShowDialog();
            }
            else
            {
                if (string.IsNullOrEmpty(password))
                {
                    //ef.lblTitle.Text = "登录错误：";
                    //ef.lblMsg.Text = "必须填写密码";
                    //ef.ShowDialog();
                }
                else
                {
                    int r = DAL.SQLHelper.loginCheck(username, password);
                    if (r == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    if (r == 0)
                    {
                        MessageBox.Show("密码错误");
                    }
                    if (r == -1)
                    {
                        MessageBox.Show("用户不存在");
                    }
                }
            }
        }

        private void passwordTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginFunction();
            }
        }
    }
}
