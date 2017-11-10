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
    public partial class user : CCSkinMain
    {
        public void showTable()
        {
            string sql = "select * from user";
            this.dataGridViewUser.DataSource = DAL.SQLHelper.ExecuteDataTable(sql, new MySqlParameter[] { });
        }
        public user()
        {
            InitializeComponent();
            showTable();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pwd = TBoxPword.Text;
            string pwdA = TBoxPwordagain.Text;
            string sql = "insert into user (username,pword,uptime) value (@username,@pword,@uptime)";
            //DateTime.Now.ToShortDateString().ToString()
            //DateTime date =DateTime.Now;
            //string pw = Controller.pwordEncry.Encryption(pwd);
            MySqlParameter[] pms = new MySqlParameter[]
            {
                new MySqlParameter("@username",MySqlDbType.VarChar,20) {Value=TBoxName.Text.Trim() },
                new MySqlParameter("@pword",MySqlDbType.VarChar,30) {Value=pwd },
                new MySqlParameter("@uptime",MySqlDbType.Date) { Value=DateTime.Now}
            };
            if (DAL.SQLHelper.Update(sql, pms) > 0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            showTable();
        }
    }
}
