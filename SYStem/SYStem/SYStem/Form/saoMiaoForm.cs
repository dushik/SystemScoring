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
    public partial class saoMiaoForm : CCSkinMain
    {
        private void showTestComBox()
        {
            DataTable db = new DataTable();
            string sql = "select * from test";
            db = DAL.SQLHelper.ExecuteDataTable(sql, new MySqlParameter[] { });
            testComBox.DataSource = db;
            testComBox.DisplayMember = db.Columns[1].ColumnName;
            testComBox.ValueMember = db.Columns[0].ColumnName;
        }
        public saoMiaoForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            showTestComBox();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog tem = new OpenFileDialog();
            tem.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";
            tem.ValidateNames = true;
            tem.CheckFileExists = true;
            tem.CheckPathExists = true;
            if (tem.ShowDialog() == DialogResult.OK)
            {
                string filpath = tem.FileName; //文件路径
                pathTBox.Text = filpath;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //此处调用dll函数处理
            MessageBox.Show("扫描成功");
        }
    }
}
