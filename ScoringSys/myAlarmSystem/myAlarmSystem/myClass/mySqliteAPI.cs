using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Data.Common;

namespace myAlarmSystem.myClass
{
    /// <summary>
    /// Sqlite数据库操作类
    /// </summary>
    public class mySqliteAPI
    {

        #region  构造函数

        private string strConn = "";

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbPath">SQLITE数据库文件路径</param>
        public mySqliteAPI(string dbPath)
        {
            this.strConn = "Data Source=" + dbPath;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbPath">数据库路径</param>
        /// <param name="dbPwd">数据库密码</param>
        public mySqliteAPI(string dbPath, string dbPwd)
        {
            this.strConn = "Data Source=" + dbPath + ";Password=" + dbPwd;
        }

        #endregion

        #region  创建数据库及初始化数据库表

        /// <summary>
        /// 创建SQLITE数据库
        /// </summary>
        /// <param name="dbPath">要创建的SQLITE数据库文件路径</param>
        public void CreateDB(string dbPath)
        {
            using (SQLiteConnection Conn = new SQLiteConnection("Data Source=" + dbPath))
            {
                Conn.Open();
                using (SQLiteCommand Comm = new SQLiteCommand(Conn))
                {
                    Comm.CommandText = "CREATE TABLE Demo(id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE)";
                    Comm.ExecuteNonQuery();
                    Comm.CommandText = "DROP TABLE Demo";
                    Comm.ExecuteNonQuery();
                }
                Conn.ChangePassword("19880210");//创建加密的数据库
            }
        }

        /// <summary>
        /// 压缩清理SQLITE数据库
        /// </summary>
        public void PressDB()
        {
            using (SQLiteConnection Conn = new SQLiteConnection(strConn))
            {
                Conn.Open();
                using (SQLiteCommand Comm = Conn.CreateCommand())
                {
                    Comm.CommandText = "VACUUM";
                    Comm.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行SQL语句，来自TXT文本
        /// </summary>
        /// <param name="txtPath"></param>
        public void ExecuteTxtSQL(string dbPath, string sqlPath)
        {
            string sql = this.ReadSqlFromTxt(sqlPath);
            if (sql.Length > 0)
            {
                using (SQLiteConnection Conn = new SQLiteConnection("Data Source=" + dbPath))
                {
                    Conn.Open();
                    using (SQLiteCommand Comm = new SQLiteCommand(Conn))
                    {
                        Comm.CommandText = sql;
                        Comm.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// 读取文本
        /// </summary>
        /// <param name="file">文件</param>
        /// <returns></returns>
        private string ReadSqlFromTxt(string file)
        {
            string data = "";
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        data += line;
                    }
                }
            }
            catch { return ""; }
            return data;
        }

        #endregion

        #region  增删改操作

        /// <summary>
        /// 增删改操作，返回受影响的行数
        /// </summary>
        /// <param name="sql">要执行增删改的SQL语句</param>
        /// <param name="parameters">执行增删改语句所需要的参数，参数必须以他们在SQL语句中的顺序为准</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, SQLiteParameter[] parameters)
        {
            int affectedRows = 0;
            using (SQLiteConnection Conn = new SQLiteConnection(strConn))
            {
                Conn.Open();
                using (DbTransaction transaction = Conn.BeginTransaction())
                {
                    using (SQLiteCommand Comm = new SQLiteCommand(Conn))
                    {
                        Comm.CommandText = sql;
                        if (parameters != null)
                        {
                            Comm.Parameters.AddRange(parameters);
                        }
                        affectedRows = Comm.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
            return affectedRows;
        }

        /// <summary>
        /// 增删改操作，返回执行成功与否
        /// </summary>
        /// <param name="sql">要执行增删改的SQL语句</param>
        /// <returns></returns>
        public bool ExecuteNonQuery(string sql)
        {
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(strConn))
                {
                    Conn.Open();
                    using (DbTransaction transaction = Conn.BeginTransaction())
                    {
                        using (SQLiteCommand Comm = new SQLiteCommand(Conn))
                        {
                            Comm.CommandText = sql;
                            Comm.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
            }
            catch { return false; }
            return true;
        }

        #endregion

        #region  查询操作

        /// <summary>
        /// 执行一个查询语句，返回一个包含查询结果的datatable
        /// </summary>
        /// <param name="sql">要执行的查询语句</param>
        /// <param name="parameters">要执行的SQL语句所需要的参数，参数必须是以他们在SQL语句中的顺序为准</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql, SQLiteParameter[] parameters)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(strConn))
            {
                using (SQLiteCommand Comm = new SQLiteCommand(sql, Conn))
                {
                    if (parameters != null)
                    {
                        Comm.Parameters.AddRange(parameters);
                    }
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(Comm);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }
            }
        }

        /// <summary>
        /// 执行一个查询语句，返回一个包含查询结果的datatable
        /// </summary>
        /// <param name="sql">要执行的查询语句</param>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql, string tableName)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(strConn))
            {
                using (SQLiteCommand Comm = new SQLiteCommand(sql, Conn))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(Comm);
                    DataSet data = new DataSet();
                    adapter.Fill(data, tableName);
                    return data.Tables[tableName];
                }
            }
        }

        public DataSet ExecuteDataSet(string sql)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(strConn))
            {
                using (SQLiteCommand Comm = new SQLiteCommand(sql, Conn))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(Comm);
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    return data;
                }
            }
        }

        /// <summary>
        /// 执行一个查询语句，返回一个包含查询结果的datatable，分页显示
        /// </summary>
        /// <param name="sql">要执行的查询语句</param>
        /// <param name="startIndex">开始索引</param>
        /// <param name="count">行数</param>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql, int startIndex, int count, string tableName)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(strConn))
            {
                using (SQLiteCommand Comm = new SQLiteCommand(sql, Conn))
                {
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(Comm);
                    DataSet data = new DataSet();
                    adapter.Fill(data, startIndex, count, tableName);
                    return data.Tables[tableName];
                }
            }
        }

        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public object ExecuteScalar(string sql)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(strConn))
            {
                Conn.Open();
                using (SQLiteCommand Comm = new SQLiteCommand(sql, Conn))
                {
                    return Comm.ExecuteScalar();
                }
            }
        }

        #endregion

    }
}
