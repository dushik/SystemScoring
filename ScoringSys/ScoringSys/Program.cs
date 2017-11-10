using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ScoringSys
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainWindow());
            //    string connectionStr = "Server=localhost;DataBase=automarking;Uid=root;Pwd=root";
            //    SqlConnection con = new SqlConnection(connectionStr);
            //    try
            //    {
            //        con.Open();
            //        MessageBox.Show("数据库连接成功：）");
            //    }
            //    catch (Exception err)
            //    {
            //        MessageBox.Show(err.Message);
            //    }
            //    finally
            //    {
            //        con.Close();
            //    }
            //    
            //}
        }
    }
}
