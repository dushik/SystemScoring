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
using System.IO;
using Models;

namespace SYStem
{
    public partial class yuejuanForm : CCSkinMain
    {
        private List<string> imagePaths = new List<string>(); //试卷路径列表
        private void showTestComBox()
        {
            DataTable db = new DataTable();
            string sql = "select * from test";
            db = DAL.SQLHelper.ExecuteDataTable(sql, new MySqlParameter[] { });
            testComBox.DataSource = db;
            testComBox.DisplayMember = db.Columns[1].ColumnName;
            testComBox.ValueMember = db.Columns[0].ColumnName;
        }
        public yuejuanForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            showTestComBox();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string ss = testComBox.SelectedValue.ToString();//获取本次考试ID
            for(int i = 0; i < imagePaths.Count; i++)
            {
                //Console.WriteLine(imagePaths[i]);
                skinWaterTextBox2.Text = imagePaths[i];
                //skinWaterTextBox2.WaterText = imagePaths[i];
            }

            //首先录入考生信息，客观题得分

            //其次，开始主观题的在线打分
            string sql = "select * from subposition where tid=@tid";
            MySqlParameter[] pms = new MySqlParameter[] {
                new MySqlParameter("@tid",MySqlDbType.Int32,11) {Value=int.Parse(ss) },
            };
            //subposition sub = new subposition();
            MySqlDataReader reader =DAL.SQLHelper.GetReader(sql, pms);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int tid = reader.GetInt32(1);
                    int sub1x = reader.GetInt32(2);
                }
            }
            subForm sub = new subForm();
            sub.Show();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            //OpenFileDialog tem = new OpenFileDialog();
            System.Windows.Forms.FolderBrowserDialog tem = new System.Windows.Forms.FolderBrowserDialog();
            tem.Description = "请选择考生试卷存放路径";
            if (tem.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(tem.SelectedPath))
                {
                    MessageBox.Show("文件不能为空");
                }
                string filpath = tem.SelectedPath; //文件路径
                TBoxPath.Text = filpath;
                foreach(string path in Directory.GetFiles(@filpath))
                {
                    imagePaths.Add(path); 
                }
            }
        }
    }
}
