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
    public partial class yueForm : CCSkinMain
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
        public yueForm()
        {
            InitializeComponent();
            showTestComBox();
        }

        private void yuejuan_Load(object sender, EventArgs e)
        {

        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
