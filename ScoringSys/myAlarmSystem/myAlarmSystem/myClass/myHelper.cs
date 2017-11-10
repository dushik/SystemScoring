using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myAlarmSystem.myClass
{
    public class myHelper
    {
        /// <summary>
        /// 提示对话框
        /// </summary>
        /// <param name="msg">消息内容</param>
        public static void ShowMessageBoxInfo(string msg)
        {
            new myForm.frmMessageBox(myForm.MessageBoxStyle.info, msg).ShowDialog();
        }

        /// <summary>
        /// 错误对话框
        /// </summary>
        /// <param name="msg">消息内容</param>
        public static void ShowMessageBoxError(string msg)
        {
            new myForm.frmMessageBox(myForm.MessageBoxStyle.error, msg).ShowDialog();
        }

        /// <summary>
        /// 询问对话框
        /// </summary>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        public static System.Windows.Forms.DialogResult ShowMessageBoxQuestion(string msg)
        {
            return new myForm.frmMessageBox(myForm.MessageBoxStyle.question, msg).ShowDialog();
        }
    }
}
