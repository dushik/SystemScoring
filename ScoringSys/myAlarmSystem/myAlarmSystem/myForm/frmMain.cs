using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myAlarmSystem.myForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myClass.myHelper.ShowMessageBoxInfo("修改学生信息成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myClass.myHelper.ShowMessageBoxError("修改学生信息失败！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myClass.myHelper.ShowMessageBoxQuestion("确定要修改学生信息吗？");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myClass.myHelper.ShowMessageBoxInfo("修改学生信息成功！你可以继续进行操作！哈哈哈哈哈！");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myClass.myHelper.ShowMessageBoxError("修改学生信息失败！不知道具体原因！哈哈哈哈哈！");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myClass.myHelper.ShowMessageBoxQuestion("确定要修改学生信息吗？修改后不能还原哦！哈哈哈哈哈！");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改学生信息成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改学生信息失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定要修改学生信息吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改学生信息成功！你可以继续进行操作！哈哈哈哈哈！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改学生信息失败！具体原因不知道！哈哈哈哈哈！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定要修改学生信息吗？修改后不能还原哦！哈哈哈哈哈！", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
