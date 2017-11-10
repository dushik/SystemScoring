using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ScoringSys
{
    public partial class saomiaoForm : Form
    {
        private DataSet dsall;
        private static String mysqlcon = "database=automarking;Password=root;User ID=root;server=localhost";//Data Source=MySQL;;charset=utf8";
        private MySqlConnection conn = new MySqlConnection(mysqlcon);
        private MySqlDataAdapter mDataAdapter;
        
        private void bindData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("连接成功:)");
            }
            try
            {

                //conn = new MySqlConnection(mysqlcon);
                mDataAdapter = new MySqlDataAdapter("select * from student", conn);
                dsall = new DataSet();
                mDataAdapter.Fill(dsall, "student");
                dataViewFengzhi.DataSource = dsall.Tables["student"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
            conn.Close();

        }
        public saomiaoForm()
        {
            InitializeComponent();
            //MessageBox.Show(DAL.SQLHelper.connString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string selectPath = folderBrowser.SelectedPath;
                string lastChar = selectPath.Substring(selectPath.Length - 1, 1);
                if (lastChar != @"\")
                {
                    tBoxSrc.Text = folderBrowser.SelectedPath + @"\";
                }
                else
                {
                    tBoxSrc.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bindData();
        }
        private void dataViewFengzhi_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            tBoxDati.Text = dataViewFengzhi.Rows[e.RowIndex].Cells["stu_name"].Value.ToString();
            tBoxXiaoti.Text = dataViewFengzhi.Rows[e.RowIndex].Cells["stu_name"].Value.ToString();
            tBoxTixing.Text = dataViewFengzhi.Rows[e.RowIndex].Cells["stu_name"].Value.ToString();
            tBoxManfen.Text = dataViewFengzhi.Rows[e.RowIndex].Cells["stu_name"].Value.ToString();
            tBoxAnswer.Text = dataViewFengzhi.Rows[e.RowIndex].Cells["stu_name"].Value.ToString();
        }

        private void tboxDati_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                string sqlId = "update Student set StudenTnAME='" + tBoxDati.Text + "',HomeAddress='" + tBoxXiaoti.Text + "',Content='" + tBoxTixing.Text + "' where ID=" + Convert.ToInt32(dataViewFengzhi.CurrentRow.Cells[0].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            */
        }

    }
}
