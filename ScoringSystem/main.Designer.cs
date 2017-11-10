namespace SYStem
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.skinMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSys,
            this.menuSaomiao,
            this.menuScoring,
            this.menuScore,
            this.menuHelp});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 28);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 0;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
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
            this.userMenuItem.Size = new System.Drawing.Size(159, 26);
            this.userMenuItem.Text = "用户管理";
            this.userMenuItem.Click += new System.EventHandler(this.userMenuItem_Click);
            // 
            // testMenuItem
            // 
            this.testMenuItem.Name = "testMenuItem";
            this.testMenuItem.Size = new System.Drawing.Size(159, 26);
            this.testMenuItem.Text = "班级管理";
            this.testMenuItem.Click += new System.EventHandler(this.testMenuItem_Click);
            // 
            // groupMenuItem
            // 
            this.groupMenuItem.Name = "groupMenuItem";
            this.groupMenuItem.Size = new System.Drawing.Size(159, 26);
            this.groupMenuItem.Text = "考试管理";
            this.groupMenuItem.Click += new System.EventHandler(this.groupMenuItem_Click);
            // 
            // temMenuItem
            // 
            this.temMenuItem.Name = "temMenuItem";
            this.temMenuItem.Size = new System.Drawing.Size(159, 26);
            this.temMenuItem.Text = "标记位录入";
            this.temMenuItem.Click += new System.EventHandler(this.temMenuItem_Click);
            // 
            // configMenuItem
            // 
            this.configMenuItem.Name = "configMenuItem";
            this.configMenuItem.Size = new System.Drawing.Size(159, 26);
            this.configMenuItem.Text = "设置";
            this.configMenuItem.Click += new System.EventHandler(this.configMenuItem_Click);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(159, 26);
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
            this.menuScore.Click += new System.EventHandler(this.menuScore_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(51, 24);
            this.menuHelp.Text = "帮助";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(8, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1475, 505);
            this.mainPanel.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 572);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.skinMenuStrip1);
            this.Name = "main";
            this.Text = "自动化阅卷系统";
            this.Load += new System.EventHandler(this.main_Load);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSys;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem userMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSaomiao;
        private System.Windows.Forms.ToolStripMenuItem menuScoring;
        private System.Windows.Forms.ToolStripMenuItem menuScore;
        private System.Windows.Forms.Panel mainPanel;
    }
}