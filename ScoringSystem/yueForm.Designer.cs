namespace SYStem
{
    partial class yueForm
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
            this.testComBox = new CCWin.SkinControl.SkinComboBox();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.skinProgressBar1 = new CCWin.SkinControl.SkinProgressBar();
            this.skinWaterTextBox2 = new CCWin.SkinControl.SkinWaterTextBox();
            this.startButton = new CCWin.SkinControl.SkinButton();
            this.scanButton = new CCWin.SkinControl.SkinButton();
            this.skinWaterTextBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // testComBox
            // 
            this.testComBox.BackColor = System.Drawing.Color.AliceBlue;
            this.testComBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.testComBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.testComBox.FormattingEnabled = true;
            this.testComBox.ItemBorderColor = System.Drawing.Color.Cyan;
            this.testComBox.Items.AddRange(new object[] {
            "2017春季考试",
            "2017春季考试",
            "2017春季考试",
            "2017春季考试",
            "2017春季考试",
            "2017春季考试",
            "2017春季考试",
            "2017春季考试",
            "2017春季考试",
            "2017春季考试"});
            this.testComBox.Location = new System.Drawing.Point(141, 47);
            this.testComBox.Name = "testComBox";
            this.testComBox.Size = new System.Drawing.Size(183, 28);
            this.testComBox.TabIndex = 0;
            this.testComBox.WaterText = "";
            this.testComBox.SelectedIndexChanged += new System.EventHandler(this.skinComboBox1_SelectedIndexChanged);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.Controls.Add(this.testComBox);
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.skinGroupBox1.Location = new System.Drawing.Point(61, 68);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(340, 455);
            this.skinGroupBox1.TabIndex = 1;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "选择考试信息";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.SystemColors.ScrollBar;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinLabel1.Location = new System.Drawing.Point(6, 52);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(129, 23);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "选择相应考试：";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.Controls.Add(this.skinProgressBar1);
            this.skinGroupBox2.Controls.Add(this.skinWaterTextBox2);
            this.skinGroupBox2.Controls.Add(this.startButton);
            this.skinGroupBox2.Controls.Add(this.scanButton);
            this.skinGroupBox2.Controls.Add(this.skinWaterTextBox1);
            this.skinGroupBox2.Controls.Add(this.skinLabel2);
            this.skinGroupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Chocolate;
            this.skinGroupBox2.Location = new System.Drawing.Point(491, 68);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.SystemColors.ButtonFace;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(745, 455);
            this.skinGroupBox2.TabIndex = 2;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "扫描试卷";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinProgressBar1
            // 
            this.skinProgressBar1.Back = null;
            this.skinProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.BarBack = null;
            this.skinProgressBar1.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.ForeColor = System.Drawing.Color.Red;
            this.skinProgressBar1.Location = new System.Drawing.Point(40, 396);
            this.skinProgressBar1.Name = "skinProgressBar1";
            this.skinProgressBar1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.Size = new System.Drawing.Size(672, 23);
            this.skinProgressBar1.TabIndex = 6;
            // 
            // skinWaterTextBox2
            // 
            this.skinWaterTextBox2.Location = new System.Drawing.Point(40, 116);
            this.skinWaterTextBox2.Multiline = true;
            this.skinWaterTextBox2.Name = "skinWaterTextBox2";
            this.skinWaterTextBox2.Size = new System.Drawing.Size(672, 259);
            this.skinWaterTextBox2.TabIndex = 4;
            this.skinWaterTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox2.WaterText = "";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.startButton.DownBack = null;
            this.startButton.Location = new System.Drawing.Point(620, 63);
            this.startButton.MouseBack = null;
            this.startButton.Name = "startButton";
            this.startButton.NormlBack = null;
            this.startButton.Size = new System.Drawing.Size(92, 27);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "开始阅卷";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // scanButton
            // 
            this.scanButton.BackColor = System.Drawing.Color.Transparent;
            this.scanButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.scanButton.DownBack = null;
            this.scanButton.Location = new System.Drawing.Point(510, 63);
            this.scanButton.MouseBack = null;
            this.scanButton.Name = "scanButton";
            this.scanButton.NormlBack = null;
            this.scanButton.Size = new System.Drawing.Size(75, 27);
            this.scanButton.TabIndex = 2;
            this.scanButton.Text = "浏览";
            this.scanButton.UseVisualStyleBackColor = false;
            // 
            // skinWaterTextBox1
            // 
            this.skinWaterTextBox1.Location = new System.Drawing.Point(171, 63);
            this.skinWaterTextBox1.Name = "skinWaterTextBox1";
            this.skinWaterTextBox1.Size = new System.Drawing.Size(292, 27);
            this.skinWaterTextBox1.TabIndex = 1;
            this.skinWaterTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox1.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel2.ForeColor = System.Drawing.Color.Black;
            this.skinLabel2.Location = new System.Drawing.Point(36, 63);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(129, 23);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "试卷存放目录：";
            // 
            // yueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 573);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Name = "yueForm";
            this.Text = "阅卷服务";
            this.Load += new System.EventHandler(this.yuejuan_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinComboBox testComBox;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinProgressBar skinProgressBar1;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox2;
        private CCWin.SkinControl.SkinButton startButton;
        private CCWin.SkinControl.SkinButton scanButton;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
    }
}