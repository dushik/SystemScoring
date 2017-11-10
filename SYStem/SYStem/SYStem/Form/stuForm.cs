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
    public partial class stuForm : CCSkinMain
    {
        private void showTestComBox()
        {
            DataTable db = new DataTable();
            string sql = "select * from class";
            db = DAL.SQLHelper.ExecuteDataTable(sql, new MySqlParameter[] { });
            classComboBox.DataSource = db;
            classComboBox.DisplayMember = db.Columns[1].ColumnName;
            classComboBox.ValueMember = db.Columns[0].ColumnName;
        }
        private void showTable()
        {
            string sql = "select * from student";
            MySqlParameter[] pms = new MySqlParameter[] { };
            this.dataGridViewClass.DataSource = DAL.SQLHelper.ExecuteDataTable(sql, pms);
        }
        public stuForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            showTable();
            showTestComBox();
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            string sql = "insert into student (name,number,gender,classId) values (@name,@number,@gender,@classId)";
            MySqlParameter[] pms = new MySqlParameter[]
            {
                new MySqlParameter("@name",MySqlDbType.VarChar,40) {Value=tBoxName.Text },
                new MySqlParameter("@number",MySqlDbType.Int32) {Value=Convert.ToInt32(tBoxNumber.Text.Trim()) },
                new MySqlParameter("@gender",MySqlDbType.VarChar,4) {Value=TBoxGneder.Text },
                 new MySqlParameter("@classId",MySqlDbType.Int32) {Value=Convert.ToInt32( classComboBox.SelectedValue.ToString()) }
            };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                //myAlarmSystem.myClass.myHelper.ShowMessageBoxInfo("修改学生信息成功！");

            }
            else
            {
                MessageBox.Show("增加失败:(");
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

        private void dataGridViewClass_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            classTextBox.Text = dataGridViewClass.Rows[e.RowIndex].Cells["name"].Value.ToString();
            numberTextBox.Text = dataGridViewClass.Rows[e.RowIndex].Cells["number"].Value.ToString();
        }
    }
}
