using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration; //引入读取配置文件类所在的命名空间
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    public class SQLHelper
    {
        public static  string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public static int uid;
        /// <summary>
        /// 增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static int Update(string sql,params MySqlParameter[] pms)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;  //返回的是增改删操作成功的记录位置 
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        /// <summary>
        /// 执行单一查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns name="查询结果的第一行第一列内容"></returns>
        public static object GetSingleResult(string sql,params MySqlParameter[] pms)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        /// <summary>
        /// 返回一个结果集的查询,执行查询，返回多行，多列的方法。
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static MySqlDataReader GetReader(string sql,params MySqlParameter[] pms)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader objReader = null;
            try
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                conn.Open();
                objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection); //一旦返回无法释放连接，故使用此参数
                return objReader;
            }
            catch (Exception ex)
            {
                conn.Close();
                conn.Dispose();
                throw ex;
            }
        }
        /// <summary>
        /// 查询数据表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql,params MySqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using(MySqlDataAdapter adapter =new MySqlDataAdapter(sql, connString))
            {
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
            }
            return dt;
        }
        /// <summary>
        /// 用户登录验证，返回1位登录成功，返回0密码错误，返回-1用户不存在
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pword"></param>
        /// <returns></returns>
        public static int loginCheck(string uname,string pword)
        {
            //string pwordtext = Controller.pwordEncry.Encryption(pword);
            //MessageBox.Show(pwordtext);
            MySqlConnection conn = new MySqlConnection(connString);
            string sql = string.Format("select * from user where username='{0}'", uname);
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            conn.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    //查出该用户的词条记录
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connString);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    string dbpword = dt.Rows[0][2].ToString();
                    //string spword = Controller.pwordEncry.Decrypt(dbpword);
                    //MessageBox.Show(spword);
                    if (string.Compare(dbpword, pword) == 0)
                    {
                        int.TryParse(dt.Rows[0][0].ToString(), out uid);
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// 数据库读取图片
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static void ExcuteImage(string sql,MySqlParameter[] pms)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader objReader = null;
            try
            {
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                conn.Open();
                objReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (objReader.Read())
                {
                    byte[] bytes = (byte[])objReader["pic"];
                    MemoryStream mss = new MemoryStream();
                    mss = new MemoryStream(bytes);
                    //Image im = Image.FromStream(mss);
                    //Mat image;
                    //return im;
                }
            }
            catch(Exception ex)
            {
                conn.Close();
                conn.Dispose();
                throw ex;
            }
        }
    }
}
