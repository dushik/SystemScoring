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
    public partial class testForm : CCSkinMain
    {
        private void showTable()
        {
            string sql = "select * from test";
            MySqlParameter[] pms = new MySqlParameter[] { };
            this.dataGridViewTest.DataSource = DAL.SQLHelper.ExecuteDataTable(sql, pms);
        }
        public testForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            showTable();
        }
        private void addTestBtn_Click(object sender, EventArgs e)
        {
            string sql = "insert into test (name,updateDate) value (@name,@updateDate)";
            MySqlParameter[] pms = new MySqlParameter[]
            {
                new MySqlParameter("@name",MySqlDbType.VarChar,60) { Value=addTestTBox.Text},
                new MySqlParameter("@updateDate",MySqlDbType.Date) {Value=DateTime.Now }
            };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            showTable();
        }
        private void upTestBtn_Click(object sender, EventArgs e)
        {
            //string sql = "update test set name='" + UpTestTBox.Text + "', updateDate='"+DateTime.Now+"'where ID=" + dataGridViewTest.CurrentRow.Cells[0].Value.ToString();
            string sql = "update test set name=@name,updateDate=@updateDate where ID=@where";  
            MySqlParameter[] pms = new MySqlParameter[]
            {
                new MySqlParameter("@name",MySqlDbType.VarChar,60) {Value=UpTestTBox.Text },
                new MySqlParameter("@updateDate",MySqlDbType.Date) {Value=DateTime.Now },
                new MySqlParameter("@where",MySqlDbType.Int32) {Value=dataGridViewTest.CurrentRow.Cells[0].Value.ToString() }
            };
            int r = DAL.SQLHelper.Update(sql, new MySqlParameter[] { });
            if (r > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            showTable();
        }
        private void delTestBtn_Click(object sender, EventArgs e)
        {
            string sql = "delete from test where ID=" + dataGridViewTest.CurrentRow.Cells[0].Value.ToString();
            MySqlParameter[] pms = new MySqlParameter[] { };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                MessageBox.Show("删除成功");
                showTable();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
        private void dataGridViewTest_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            UpTestTBox.Text = dataGridViewTest.Rows[e.RowIndex].Cells["name"].Value.ToString();
        }
    }
}
