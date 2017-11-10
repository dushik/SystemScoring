using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myAlarmSystem.myForm
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        DateTime selectStartTime=DateTime.Now;
        DateTime selectEndTime=DateTime.Now;

        public DateTime SelectStartTime
        {
            get { return selectStartTime; }
        }

        public DateTime SelectEndTime
        {
            get { return selectEndTime; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value.Date > dtpEnd.Value.Date)
            {
                myClass.myHelper.ShowMessageBoxError("开始日期不能大于结束日期！");                
                return;
            }

            selectStartTime = dtpStart.Value;
            selectEndTime = dtpEnd.Value;
            this.Close(); 
            this.DialogResult = DialogResult.OK;
        }
    }
}
