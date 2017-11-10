namespace SYStem
{
    partial class subForm
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
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.beforeBtn = new CCWin.SkinControl.SkinButton();
            this.nextBtn = new CCWin.SkinControl.SkinButton();
            this.scoreTBox = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Location = new System.Drawing.Point(45, 50);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(587, 491);
            this.skinPictureBox1.TabIndex = 0;
            this.skinPictureBox1.TabStop = false;
            // 
            // beforeBtn
            // 
            this.beforeBtn.BackColor = System.Drawing.Color.Transparent;
            this.beforeBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.beforeBtn.DownBack = null;
            this.beforeBtn.Location = new System.Drawing.Point(743, 119);
            this.beforeBtn.MouseBack = null;
            this.beforeBtn.Name = "beforeBtn";
            this.beforeBtn.NormlBack = null;
            this.beforeBtn.Size = new System.Drawing.Size(87, 33);
            this.beforeBtn.TabIndex = 1;
            this.beforeBtn.Text = "上一题";
            this.beforeBtn.UseVisualStyleBackColor = false;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.nextBtn.DownBack = null;
            this.nextBtn.Location = new System.Drawing.Point(908, 119);
            this.nextBtn.MouseBack = null;
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.NormlBack = null;
            this.nextBtn.Size = new System.Drawing.Size(81, 33);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "下一题";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // scoreTBox
            // 
            this.scoreTBox.BackColor = System.Drawing.Color.Transparent;
            this.scoreTBox.DownBack = null;
            this.scoreTBox.Icon = null;
            this.scoreTBox.IconIsButton = false;
            this.scoreTBox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.scoreTBox.IsPasswordChat = '\0';
            this.scoreTBox.IsSystemPasswordChar = false;
            this.scoreTBox.Lines = new string[0];
            this.scoreTBox.Location = new System.Drawing.Point(834, 255);
            this.scoreTBox.Margin = new System.Windows.Forms.Padding(0);
            this.scoreTBox.MaxLength = 32767;
            this.scoreTBox.MinimumSize = new System.Drawing.Size(28, 28);
            this.scoreTBox.MouseBack = null;
            this.scoreTBox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.scoreTBox.Multiline = false;
            this.scoreTBox.Name = "scoreTBox";
            this.scoreTBox.NormlBack = null;
            this.scoreTBox.Padding = new System.Windows.Forms.Padding(5);
            this.scoreTBox.ReadOnly = false;
            this.scoreTBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scoreTBox.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.scoreTBox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreTBox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreTBox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.scoreTBox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.scoreTBox.SkinTxt.Name = "BaseText";
            this.scoreTBox.SkinTxt.Size = new System.Drawing.Size(175, 22);
            this.scoreTBox.SkinTxt.TabIndex = 0;
            this.scoreTBox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.scoreTBox.SkinTxt.WaterText = "";
            this.scoreTBox.TabIndex = 3;
            this.scoreTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.scoreTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.scoreTBox.WaterText = "";
            this.scoreTBox.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(727, 263);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(54, 20);
            this.skinLabel1.TabIndex = 5;
            this.skinLabel1.Text = "得分：";
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(908, 359);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(81, 33);
            this.skinButton3.TabIndex = 6;
            this.skinButton3.Text = "打分";
            this.skinButton3.UseVisualStyleBackColor = false;
            // 
            // subForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 601);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.scoreTBox);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.beforeBtn);
            this.Controls.Add(this.skinPictureBox1);
            this.Name = "subForm";
            this.Text = "主观题阅卷窗口";
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinButton beforeBtn;
        private CCWin.SkinControl.SkinButton nextBtn;
        private CCWin.SkinControl.SkinTextBox scoreTBox;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton skinButton3;
    }
}