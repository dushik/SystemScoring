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
using MySql.Data.MySqlClient;

namespace SYStem
{
    public partial class @class : CCSkinMain
    {
        private void showTable()
        {
            string sql = "select * from class";
            MySqlParameter[] pms = new MySqlParameter[] { };
            this.dataGridViewClass.DataSource = DAL.SQLHelper.ExecuteDataTable(sql, pms);
        }
        public @class()
        {
            InitializeComponent();
            this.ControlBox = false;
            showTable();
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            string name = tBoxClassName.Text;
            int number = Convert.ToInt32(tBoxClassNumber.Text.Trim());
            string sql = "insert into class (name,number,updateDate) values (@name,@number,@updateDate)";
            MySqlParameter[] pms = new MySqlParameter[]
            {
                new MySqlParameter("@name",MySqlDbType.VarChar,40) {Value=name },
                new MySqlParameter("@number",MySqlDbType.Int32) {Value=number },
                new MySqlParameter("@updateDate",MySqlDbType.Date) {Value=DateTime.Now }
            };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                //MessageBox.Show("增加成功:)");
                //myAlarmSystem.myClass.myHelper.ShowMessageBoxInfo("修改学生信息成功！");
                myForm.myHelper.ShowMessageBoxInfo("添加班级信息成功！");
            }
            else
            {
                myForm.myHelper.ShowMessageBoxError("添加班级信息失败！");
            }
            showTable();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //sqlId = "update Student set StudenTnAME='" + textBox1.Text + "',HomeAddress='" + textBox2.Text + "',Content='" + textBox3.Text + "' where ID=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "update class set name=@name,number=@number,updateDate=@updateDate where ID=@where";
            //string sql = "update class set name='" + classTextBox.Text + "',number='" + numberTextBox.Text + "' where ID=" + dataGridViewClass.CurrentRow.Cells[0].Value.ToString();
            MySqlParameter[] pms = new MySqlParameter[] {
                new MySqlParameter("@name",MySqlDbType.VarChar,40) {Value=classTextBox.Text },
                new MySqlParameter("@number",MySqlDbType.Int32) { Value=numberTextBox.Text},
                new MySqlParameter("@updateDate",MySqlDbType.Date) { Value=DateTime.Now},
                new MySqlParameter("@where",MySqlDbType.Int32) {Value=dataGridViewClass.CurrentRow.Cells[0].Value.ToString() }
            };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                myForm.myHelper.ShowMessageBoxInfo("修改班级信息成功！");
                classTextBox.Text = "";
                showTable();
            }
            else
            {
                myForm.myHelper.ShowMessageBoxError("修改班级信息失败！");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sql = " delete from class where ID=" + dataGridViewClass.CurrentRow.Cells[0].Value.ToString();
            MySqlParameter[] pms = new MySqlParameter[] { };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                MessageBox.Show("删除了" + r + "行");
                classTextBox.Text = "";
                showTable();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void dataGridViewClass_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow currentRow = this.dataGridViewClass.Rows[e.RowIndex];
            //@class model = currentRow.DataBoundItem as @class;
            //if(model!=null)
            //{
            //    classTextBox.Text = model.id.ToString();
            //}
            classTextBox.Text = dataGridViewClass.Rows[e.RowIndex].Cells["name"].Value.ToString();
            numberTextBox.Text = dataGridViewClass.Rows[e.RowIndex].Cells["number"].Value.ToString();
        }
    }
}
