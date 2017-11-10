using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem
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
            //MessageBox.Show(DAL.SQLHelper.connString);
            //Application.Run(new mainForm());
            Application.Run(new Login());
            Mutex mutex = new Mutex(false, "程序已经运行！");
            bool Running = !mutex.WaitOne(0, false);
            if (!Running)
            {
                try
                {
                    //Application.EnableVisualStyles();
                    //Application.SetCompatibleTextRenderingDefault(false);
                    //MessageBox.Show(DAL.SQLHelper.connString);
                    //Application.Run(new mainForm());
                    //Application.Run(new LoginForm());
                    LoginForm lf = new LoginForm();
                    lf.ShowDialog();
                    if (lf.DialogResult == DialogResult.OK)
                    {
                        Application.Run(new main());
                    }
                }
                catch (Exception e)
                {
                    ErrorForm ef = new ErrorForm();
                    throw e;
                    //ef.Text = "错误";
                    //ef.lblTitle.Text = "程序提示";
                    //ef.lblMsg.Text = "抱歉，程序突然终止" + e.Message;
                    //ef.ShowDialog();
                }
            }
            else
            {
                //ErrorForm ef = new ErrorForm();
                //ef.Text = "提示";
                //ef.lblTitle.Text = "运行提示";
                //ef.lblMsg.Text = "程序已经运行，请勿重复运行。";
                //ef.ShowDialog();
                Application.Exit();
            }
        }
    }
}
