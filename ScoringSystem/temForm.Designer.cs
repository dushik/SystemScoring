namespace ScoringSystem
{
    partial class temForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new CCWin.SkinControl.SkinButton();
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.TBoxPath = new CCWin.SkinControl.SkinTextBox();
            this.PBoxTem = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxTem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpen.DownBack = null;
            this.btnOpen.Location = new System.Drawing.Point(736, 143);
            this.btnOpen.MouseBack = null;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.NormlBack = null;
            this.btnOpen.Size = new System.Drawing.Size(125, 53);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开文件";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOk.DownBack = null;
            this.btnOk.Location = new System.Drawing.Point(889, 146);
            this.btnOk.MouseBack = null;
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = null;
            this.btnOk.Size = new System.Drawing.Size(132, 46);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(46, 159);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(144, 20);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "试卷模板存放路径：";
            // 
            // TBoxPath
            // 
            this.TBoxPath.BackColor = System.Drawing.Color.Transparent;
            this.TBoxPath.DownBack = null;
            this.TBoxPath.Icon = null;
            this.TBoxPath.IconIsButton = false;
            this.TBoxPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TBoxPath.IsPasswordChat = '\0';
            this.TBoxPath.IsSystemPasswordChar = false;
            this.TBoxPath.Lines = new string[0];
            this.TBoxPath.Location = new System.Drawing.Point(208, 159);
            this.TBoxPath.Margin = new System.Windows.Forms.Padding(0);
            this.TBoxPath.MaxLength = 32767;
            this.TBoxPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.TBoxPath.MouseBack = null;
            this.TBoxPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TBoxPath.Multiline = false;
            this.TBoxPath.Name = "TBoxPath";
            this.TBoxPath.NormlBack = null;
            this.TBoxPath.Padding = new System.Windows.Forms.Padding(5);
            this.TBoxPath.ReadOnly = false;
            this.TBoxPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBoxPath.Size = new System.Drawing.Size(438, 28);
            // 
            // 
            // 
            this.TBoxPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBoxPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TBoxPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TBoxPath.SkinTxt.Name = "BaseText";
            this.TBoxPath.SkinTxt.Size = new System.Drawing.Size(428, 22);
            this.TBoxPath.SkinTxt.TabIndex = 0;
            this.TBoxPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TBoxPath.SkinTxt.WaterText = "";
            this.TBoxPath.TabIndex = 4;
            this.TBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TBoxPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TBoxPath.WaterText = "";
            this.TBoxPath.WordWrap = true;
            // 
            // PBoxTem
            // 
            this.PBoxTem.BackColor = System.Drawing.Color.Transparent;
            this.PBoxTem.Location = new System.Drawing.Point(208, 225);
            this.PBoxTem.Name = "PBoxTem";
            this.PBoxTem.Size = new System.Drawing.Size(438, 300);
            this.PBoxTem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxTem.TabIndex = 5;
            this.PBoxTem.TabStop = false;
            // 
            // temForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 672);
            this.Controls.Add(this.PBoxTem);
            this.Controls.Add(this.TBoxPath);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnOpen);
            this.Name = "temForm";
            this.Text = "temForm";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxTem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnOpen;
        private CCWin.SkinControl.SkinButton btnOk;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox TBoxPath;
        private CCWin.SkinControl.SkinPictureBox PBoxTem;
    }
}