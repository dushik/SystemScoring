using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem
{
    public partial class saomiaoForm : Form
    {
        private void showTestComBox()
        {
            DataTable db = new DataTable();
            string sql = "select * from test";
            db = DAL.SQLHelper.ExecuteDataTable(sql, new MySqlParameter[] { });
            testComBox.DataSource = db;
            testComBox.DisplayMember = db.Columns[1].ColumnName;//显示的文本
            testComBox.ValueMember = db.Columns[0].ColumnName;//对应的值
        }
        public saomiaoForm()
        {
            InitializeComponent();
            showTestComBox();
        }

        private void btnLiulan_Click(object sender, EventArgs e)
        {
            OpenFileDialog mubanPath = new OpenFileDialog();
            mubanPath.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*";
            mubanPath.ValidateNames = true;
            mubanPath.CheckPathExists = true;
            mubanPath.CheckFileExists = true;
            if (mubanPath.ShowDialog() == DialogResult.OK)
            {
                string strFileName = mubanPath.FileName;
            }
        }

        private void btnDuruOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您选择的是"+testComBox.GetItemText(testComBox.Items[testComBox.SelectedIndex])+"|"+testComBox.SelectedValue);
            //获取其他列值
            //DataRowView dr = (DataRowView)testComBox.Items[testComBox.SelectedIndex];
            //MessageBox.Show(dr[4].ToString());   //根据dr的index，获取datable里面的其他列值
        }
    }
}
