namespace ScoringSystem
{
    partial class mainForm
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
            this.menuSys = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaomiao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScoring = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSys
            // 
            this.menuSys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuItem,
            this.testMenuItem,
            this.groupMenuItem,
            this.temMenuItem,
            this.configMenuItem,
            this.quitMenuItem});
            this.menuSys.Name = "menuSys";
            this.menuSys.Size = new System.Drawing.Size(81, 24);
            this.menuSys.Text = "系统设置";
            this.menuSys.Click += new System.EventHandler(this.menuSys_Click);
            // 
            // userMenuItem
            // 
            this.userMenuItem.Name = "userMenuItem";
            this.userMenuItem.Size = new System.Drawing.Size(189, 26);
            this.userMenuItem.Text = "用户管理";
            this.userMenuItem.Click += new System.EventHandler(this.userMenuItem_Click);
            // 
            // testMenuItem
            // 
            this.testMenuItem.Name = "testMenuItem";
            this.testMenuItem.Size = new System.Drawing.Size(189, 26);
            this.testMenuItem.Text = "考试管理";
            this.testMenuItem.Click += new System.EventHandler(this.testMenuItem_Click);
            // 
            // groupMenuItem
            // 
            this.groupMenuItem.Name = "groupMenuItem";
            this.groupMenuItem.Size = new System.Drawing.Size(189, 26);
            this.groupMenuItem.Text = "班级管理";
            this.groupMenuItem.Click += new System.EventHandler(this.groupMenuItem_Click);
            // 
            // temMenuItem
            // 
            this.temMenuItem.Name = "temMenuItem";
            this.temMenuItem.Size = new System.Drawing.Size(189, 26);
            this.temMenuItem.Text = "试卷标记位录入";
            this.temMenuItem.Click += new System.EventHandler(this.试卷标记位录入ToolStripMenuItem_Click);
            // 
            // configMenuItem
            // 
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(189, 26);
            this.configMenuItem.Text = "设置";
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(189, 26);
            this.quitMenuItem.Text = "退出系统";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // menuSaomiao
            // 
            this.menuSaomiao.Name = "menuSaomiao";
            this.menuSaomiao.Size = new System.Drawing.Size(81, 24);
            this.menuSaomiao.Text = "扫描模板";
            this.menuSaomiao.Click += new System.EventHandler(this.menuSaomiao_Click);
            // 
            // menuScoring
            // 
            this.menuScoring.Name = "menuScoring";
            this.menuScoring.Size = new System.Drawing.Size(81, 24);
            this.menuScoring.Text = "阅卷服务";
            this.menuScoring.Click += new System.EventHandler(this.menuScoring_Click);
            // 
            // menuScore
            // 
            this.menuScore.Name = "menuScore";
            this.menuScore.Size = new System.Drawing.Size(81, 24);
            this.menuScore.Text = "成绩分析";
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(51, 24);
            this.menuHelp.Text = "帮助";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSys,
            this.menuSaomiao,
            this.menuScoring,
            this.menuScore,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1454, 669);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阅卷系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuSys;
        private System.Windows.Forms.ToolStripMenuItem testMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSaomiao;
        private System.Windows.Forms.ToolStripMenuItem menuScoring;
        private System.Windows.Forms.ToolStripMenuItem menuScore;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMenuItem;
    }
}