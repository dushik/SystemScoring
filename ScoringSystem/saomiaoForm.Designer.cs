namespace ScoringSystem
{
    partial class saomiaoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.选择相应考试 = new System.Windows.Forms.Label();
            this.testComBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.btnDuruOk = new System.Windows.Forms.Button();
            this.btnLiulan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yuejuanListBox = new System.Windows.Forms.ListBox();
            this.saomiaoProBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.选择相应考试);
            this.groupBox1.Controls.Add(this.testComBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择考试信息";
            // 
            // 选择相应考试
            // 
            this.选择相应考试.AutoSize = true;
            this.选择相应考试.Location = new System.Drawing.Point(15, 49);
            this.选择相应考试.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.选择相应考试.Name = "选择相应考试";
            this.选择相应考试.Size = new System.Drawing.Size(89, 12);
            this.选择相应考试.TabIndex = 1;
            this.选择相应考试.Text = "选择相应考试：";
            // 
            // testComBox
            // 
            this.testComBox.FormattingEnabled = true;
            this.testComBox.Location = new System.Drawing.Point(108, 46);
            this.testComBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.testComBox.Name = "testComBox";
            this.testComBox.Size = new System.Drawing.Size(183, 20);
            this.testComBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "试卷模板存放路径：";
            // 
            // tboxPath
            // 
            this.tboxPath.Location = new System.Drawing.Point(454, 34);
            this.tboxPath.Name = "tboxPath";
            this.tboxPath.Size = new System.Drawing.Size(232, 21);
            this.tboxPath.TabIndex = 6;
            // 
            // btnDuruOk
            // 
            this.btnDuruOk.Location = new System.Drawing.Point(845, 32);
            this.btnDuruOk.Name = "btnDuruOk";
            this.btnDuruOk.Size = new System.Drawing.Size(75, 23);
            this.btnDuruOk.TabIndex = 8;
            this.btnDuruOk.Text = "读入信息";
            this.btnDuruOk.UseVisualStyleBackColor = true;
            this.btnDuruOk.Click += new System.EventHandler(this.btnDuruOk_Click);
            // 
            // btnLiulan
            // 
            this.btnLiulan.Location = new System.Drawing.Point(735, 34);
            this.btnLiulan.Name = "btnLiulan";
            this.btnLiulan.Size = new System.Drawing.Size(75, 23);
            this.btnLiulan.TabIndex = 9;
            this.btnLiulan.Text = "浏览";
            this.btnLiulan.UseVisualStyleBackColor = true;
            this.btnLiulan.Click += new System.EventHandler(this.btnLiulan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yuejuanListBox);
            this.groupBox2.Controls.Add(this.saomiaoProBar);
            this.groupBox2.Location = new System.Drawing.Point(337, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 295);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // yuejuanListBox
            // 
            this.yuejuanListBox.FormattingEnabled = true;
            this.yuejuanListBox.ItemHeight = 12;
            this.yuejuanListBox.Location = new System.Drawing.Point(9, 17);
            this.yuejuanListBox.Name = "yuejuanListBox";
            this.yuejuanListBox.Size = new System.Drawing.Size(574, 232);
            this.yuejuanListBox.TabIndex = 1;
            // 
            // saomiaoProBar
            // 
            this.saomiaoProBar.Location = new System.Drawing.Point(6, 266);
            this.saomiaoProBar.Name = "saomiaoProBar";
            this.saomiaoProBar.Size = new System.Drawing.Size(577, 23);
            this.saomiaoProBar.TabIndex = 0;
            this.saomiaoProBar.Value = 60;
            // 
            // saomiaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLiulan);
            this.Controls.Add(this.btnDuruOk);
            this.Controls.Add(this.tboxPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "saomiaoForm";
            this.Text = "扫描模板";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxPath;
        private System.Windows.Forms.Button btnDuruOk;
        private System.Windows.Forms.Button btnLiulan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox yuejuanListBox;
        private System.Windows.Forms.ProgressBar saomiaoProBar;
        private System.Windows.Forms.Label 选择相应考试;
        private System.Windows.Forms.ComboBox testComBox;
    }
}