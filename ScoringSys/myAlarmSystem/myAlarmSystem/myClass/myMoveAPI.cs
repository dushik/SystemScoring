using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace myAlarmSystem.myClass
{
    /// <summary>
    /// 容器移动类
    /// </summary>
    public class myMoveAPI
    {

        #region  构造函数

        public myMoveAPI(Control MoveControl, Control ParentControl)
        {
            this.MoveControl = MoveControl;
            this.ParentControl = ParentControl;
            MoveControl.MouseDown += new MouseEventHandler(MouseDown);
            MoveControl.MouseMove += new MouseEventHandler(MouseMove);
            MoveControl.MouseUp += new MouseEventHandler(MouseUp);
        }

        #endregion

        #region 私有成员

        bool IsMoving = false;
        Point MoveControlLocation = new Point(0, 0);//相对坐标
        Point CursorOffset = new Point(0, 0);
        Point MoveControlCursor = new Point(0, 0);//绝对坐标
        Control MoveControl = null;
        Control ParentControl = null;

        #endregion

        #region 私有方法

        /// <summary>
        /// 在鼠标左键按下的状态记录鼠标当前的位置,以及被移动组件的当前位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (!myApp.IsMove) { return; }

            if (ParentControl == null) { return; }

            if (e.Button == MouseButtons.Left)
            {
                IsMoving = true;
                MoveControlLocation.X = MoveControl.Left;
                MoveControlLocation.Y = MoveControl.Top;
                MoveControlCursor.X = Cursor.Position.X;
                MoveControlCursor.Y = Cursor.Position.Y;
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (!myApp.IsMove) { return; }

            if (ParentControl == null) { return; }

            if (e.Button == MouseButtons.Left)
            {
                if (this.IsMoving)
                {
                    Point pCursor = new Point(Cursor.Position.X, Cursor.Position.Y);
                    CursorOffset.X = pCursor.X - MoveControlCursor.X;
                    CursorOffset.Y = pCursor.Y - MoveControlCursor.Y;
                    MoveControl.Left = MoveControlLocation.X + CursorOffset.X;
                    MoveControl.Top = MoveControlLocation.Y + CursorOffset.Y;
                }
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (!myApp.IsMove) { return; }

            if (ParentControl == null) { return; }

            if (this.IsMoving)
            {
                if (CursorOffset.X == 0 && CursorOffset.Y == 0)
                {
                    return;
                }
                if ((MoveControlLocation.X + CursorOffset.X + MoveControl.Width) > 0)
                {
                    MoveControl.Left = MoveControlLocation.X + CursorOffset.X;
                }
                else
                {
                    MoveControl.Left = 0;
                }
                if ((MoveControlLocation.Y + CursorOffset.Y + MoveControl.Height) > 0)
                {
                    MoveControl.Top = MoveControlLocation.Y + CursorOffset.Y;
                }
                else
                {
                    MoveControl.Top = 0;
                }
                CursorOffset.X = 0;
                CursorOffset.Y = 0;
            }
        }

        #endregion

    }
}
