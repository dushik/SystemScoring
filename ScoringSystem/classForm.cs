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
            showTable();
        }

        private void class_Load(object sender, EventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            string name = tBoxClassName.Text;
            int number = Convert.ToInt32(tBoxClassNumber.Text.Trim());
            string sql = "insert into class (class_name,number) values (@class_name,@number)";
            MySqlParameter[] pms = new MySqlParameter[]
            {
            new MySqlParameter("@class_name",MySqlDbType.VarChar,40) {Value=name },
            new MySqlParameter("@number",MySqlDbType.Int32) {Value=number }
            };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                MessageBox.Show("增加成功:)");

            }
            else
            {
                MessageBox.Show("增加失败:(");
            }
            showTable();
        }

        private void dataGridViewClass_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            classTextBox.Text = dataGridViewClass.Rows[e.RowIndex].Cells["name"].Value.ToString();
            numberTextBox.Text = dataGridViewClass.Rows[e.RowIndex].Cells["number"].Value.ToString();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //sqlId = "update Student set StudenTnAME='" + textBox1.Text + "',HomeAddress='" + textBox2.Text + "',Content='" + textBox3.Text + "' where ID=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            string sql = "update class set class_name='" + classTextBox.Text + "',number='" + numberTextBox.Text + "' where ID=" + dataGridViewClass.CurrentRow.Cells[0].Value.ToString();
            MySqlParameter[] pms = new MySqlParameter[] { };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                MessageBox.Show("修改成功！");
                classTextBox.Text = "";
                showTable();
            }
            else
            {
                MessageBox.Show("修改失败！");
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
    }
}
