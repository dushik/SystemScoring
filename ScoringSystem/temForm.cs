using CCWin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem
{
    public partial class temForm : CCSkinMain
    {
        public temForm()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog tem = new OpenFileDialog();
            tem.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";
            tem.ValidateNames = true;
            tem.CheckFileExists = true;
            tem.CheckPathExists = true;
            if (tem.ShowDialog() == DialogResult.OK)
            {
                string filpath = tem.FileName; //文件路径
                FileStream fs = new FileStream(filpath, FileMode.Open);
                byte[] imgbyte = new byte[fs.Length];
                BinaryReader br = new BinaryReader(fs);
                imgbyte = br.ReadBytes(Convert.ToInt32(fs.Length));
                //存入数据库
                string sql = "insert into template (pic,uptime)value (@pic,@uptime)";
                MySqlParameter[] pms = new MySqlParameter[]
                {
                    new MySqlParameter("@pic",MySqlDbType.Blob) {Value=imgbyte },
                    new MySqlParameter("@uptime",MySqlDbType.Date) {Value=DateTime.Now }
                };
                if (DAL.SQLHelper.Update(sql, pms) > 0)
                {
                    MessageBox.Show("添加成功！");
                    //this.pictureBox2.Image = Image.FromFile("D:\\001.jpg");
                    //读取图片并显示在pictureBox中
                    string sq = "select * from template where id=0";
                    DataTable tb = new DataTable();
                    tb = DAL.SQLHelper.ExecuteDataTable(sq,new MySqlParameter[] { });
                    //byte[] imgbyte=(byte[])tb.Rows[0][1].;
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
        }
    }
}
