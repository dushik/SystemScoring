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
    public partial class userForm : CCSkinMain
    {
        private void showTable()
        {
            string sql = "select * from user";
            MySqlParameter[] pms = new MySqlParameter[] { };
            this.useDataGridView.DataSource = DAL.SQLHelper.ExecuteDataTable(sql,pms);
        }
        public userForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            showTable();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            string sql = "insert into user (username,pword,updateDate) value(@name,@pwd,@updateDate)";
            string pword = Controller.pwordEncry.Encryption(addPwdTBox.Text.Trim());//RSA加密算法密码加密
            MessageBox.Show(Controller.pwordEncry.Decrypt(pword));
            MySqlParameter[] pms = new MySqlParameter[]
            {
                new MySqlParameter("@name",MySqlDbType.VarChar,20) {Value=addNameTBox.Text },
                new MySqlParameter("@pwd",MySqlDbType.VarChar,200) { Value=pword},
                new MySqlParameter("@updateDate",MySqlDbType.VarChar,40) {Value=DateTime.Now }
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

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            addNameTBox.Text = "";
            addPwdTBox.Text = "";
            addApwdTBox.Text = "";
        }

        private void useDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            upnameTBox.Text = useDataGridView.Rows[e.RowIndex].Cells["username"].Value.ToString();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            string sql = "update user set username=@username,pword=@pword,updateDate=@updateDate where ID=@where";
            MySqlParameter[] pms = new MySqlParameter[] {
                new MySqlParameter("@username",MySqlDbType.VarChar,20) {Value=upnameTBox.Text },
                new MySqlParameter("@pword",MySqlDbType.VarChar,200) { Value=upPwdTBox.Text},
                new MySqlParameter("@updateDate",MySqlDbType.Date) { Value=DateTime.Now},
                new MySqlParameter("@where",MySqlDbType.Int32) {Value=useDataGridView.CurrentRow.Cells[0].Value.ToString() }
            };
            int r = DAL.SQLHelper.Update(sql, pms);
            if (r > 0)
            {
                MessageBox.Show("修改成功！");
                showTable();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
