using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myAlarmSystem.myControl
{
    public enum Number
    {
        number0 = 0,
        number1 = 1,
        number2 = 2,
        number3 = 3,
        number4 = 4,
        number5 = 5,
        number6 = 6,
        number7 = 7,
        number8 = 8,
        number9 = 9
    };

    public partial class myButtonNumber : UserControl
    {
        public myButtonNumber()
        {
            InitializeComponent();

            //设置Style支持透明背景色并且双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
            this.Size = new Size(39, 68);
        }

        Number number = Number.number0;

        public Number NumberX
        {
            set { number = value; this.Invalidate(); }
            get { return number; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {           
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0, 0, this.Size.Width, this.Size.Height);

            switch (number)
            {
                case Number.number0: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_0, rec); break;
                case Number.number1: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_1, rec); break;
                case Number.number2: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_2, rec); break;
                case Number.number3: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_3, rec); break;
                case Number.number4: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_4, rec); break;
                case Number.number5: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_5, rec); break;
                case Number.number6: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_6, rec); break;
                case Number.number7: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_7, rec); break;
                case Number.number8: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_8, rec); break;
                case Number.number9: g.DrawImage(global::myAlarmSystem.Properties.Resources.number_9, rec); break;
            }
        }
    }
}
