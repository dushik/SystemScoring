namespace SYStem
{
    partial class userForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            this.useDataGridView = new CCWin.SkinControl.SkinDataGridView();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.cleanBtn = new CCWin.SkinControl.SkinButton();
            this.addBtn = new CCWin.SkinControl.SkinButton();
            this.addApwdTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.addPwdTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.addNameTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.upBtn = new CCWin.SkinControl.SkinButton();
            this.auppwdTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.upPwdTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.upnameTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.useDataGridView)).BeginInit();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // useDataGridView
            // 
            this.useDataGridView.AllowUserToAddRows = false;
            this.useDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.useDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.useDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.useDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.useDataGridView.ColumnFont = null;
            this.useDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.useDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.useDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.useDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.updateDate,
            this.pword,
            this.uid});
            this.useDataGridView.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.useDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.useDataGridView.EnableHeadersVisualStyles = false;
            this.useDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.useDataGridView.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.useDataGridView.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.useDataGridView.Location = new System.Drawing.Point(109, 169);
            this.useDataGridView.MultiSelect = false;
            this.useDataGridView.Name = "useDataGridView";
            this.useDataGridView.ReadOnly = true;
            this.useDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.useDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.useDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.useDataGridView.RowTemplate.Height = 23;
            this.useDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.useDataGridView.Size = new System.Drawing.Size(243, 231);
            this.useDataGridView.TabIndex = 0;
            this.useDataGridView.TitleBack = null;
            this.useDataGridView.TitleBackColorBegin = System.Drawing.Color.White;
            this.useDataGridView.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.useDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.useDataGridView_RowEnter);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Controls.Add(this.cleanBtn);
            this.skinGroupBox1.Controls.Add(this.addBtn);
            this.skinGroupBox1.Controls.Add(this.addApwdTBox);
            this.skinGroupBox1.Controls.Add(this.addPwdTBox);
            this.skinGroupBox1.Controls.Add(this.addNameTBox);
            this.skinGroupBox1.Controls.Add(this.skinLabel3);
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Brown;
            this.skinGroupBox1.Location = new System.Drawing.Point(480, 70);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(675, 231);
            this.skinGroupBox1.TabIndex = 1;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "添加系统用户";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // cleanBtn
            // 
            this.cleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.cleanBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cleanBtn.DownBack = null;
            this.cleanBtn.Font = new System.Drawing.Font("宋体", 10F);
            this.cleanBtn.Location = new System.Drawing.Point(437, 193);
            this.cleanBtn.MouseBack = null;
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.NormlBack = null;
            this.cleanBtn.Size = new System.Drawing.Size(75, 23);
            this.cleanBtn.TabIndex = 7;
            this.cleanBtn.Text = "清空";
            this.cleanBtn.UseVisualStyleBackColor = false;
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.addBtn.DownBack = null;
            this.addBtn.Font = new System.Drawing.Font("宋体", 10F);
            this.addBtn.Location = new System.Drawing.Point(253, 193);
            this.addBtn.MouseBack = null;
            this.addBtn.Name = "addBtn";
            this.addBtn.NormlBack = null;
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addApwdTBox
            // 
            this.addApwdTBox.Location = new System.Drawing.Point(253, 136);
            this.addApwdTBox.Name = "addApwdTBox";
            this.addApwdTBox.PasswordChar = '*';
            this.addApwdTBox.Size = new System.Drawing.Size(259, 25);
            this.addApwdTBox.TabIndex = 5;
            this.addApwdTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.addApwdTBox.WaterText = "";
            // 
            // addPwdTBox
            // 
            this.addPwdTBox.Location = new System.Drawing.Point(253, 87);
            this.addPwdTBox.Name = "addPwdTBox";
            this.addPwdTBox.PasswordChar = '*';
            this.addPwdTBox.Size = new System.Drawing.Size(259, 25);
            this.addPwdTBox.TabIndex = 4;
            this.addPwdTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.addPwdTBox.WaterText = "";
            // 
            // addNameTBox
            // 
            this.addNameTBox.Location = new System.Drawing.Point(253, 40);
            this.addNameTBox.Name = "addNameTBox";
            this.addNameTBox.Size = new System.Drawing.Size(259, 25);
            this.addNameTBox.TabIndex = 3;
            this.addNameTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.addNameTBox.WaterText = "";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(112, 136);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(114, 20);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "再次输入密码：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(172, 87);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(54, 20);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "密码：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(157, 40);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(69, 20);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "用户名：";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.Controls.Add(this.upBtn);
            this.skinGroupBox2.Controls.Add(this.auppwdTBox);
            this.skinGroupBox2.Controls.Add(this.upPwdTBox);
            this.skinGroupBox2.Controls.Add(this.upnameTBox);
            this.skinGroupBox2.Controls.Add(this.skinLabel4);
            this.skinGroupBox2.Controls.Add(this.skinLabel5);
            this.skinGroupBox2.Controls.Add(this.skinLabel6);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Brown;
            this.skinGroupBox2.Location = new System.Drawing.Point(480, 307);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(675, 231);
            this.skinGroupBox2.TabIndex = 2;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "修改系统用户";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // upBtn
            // 
            this.upBtn.BackColor = System.Drawing.Color.Transparent;
            this.upBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.upBtn.DownBack = null;
            this.upBtn.Font = new System.Drawing.Font("宋体", 10F);
            this.upBtn.Location = new System.Drawing.Point(437, 186);
            this.upBtn.MouseBack = null;
            this.upBtn.Name = "upBtn";
            this.upBtn.NormlBack = null;
            this.upBtn.Size = new System.Drawing.Size(75, 23);
            this.upBtn.TabIndex = 6;
            this.upBtn.Text = "添加";
            this.upBtn.UseVisualStyleBackColor = false;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // auppwdTBox
            // 
            this.auppwdTBox.Location = new System.Drawing.Point(253, 136);
            this.auppwdTBox.Name = "auppwdTBox";
            this.auppwdTBox.PasswordChar = '*';
            this.auppwdTBox.Size = new System.Drawing.Size(259, 25);
            this.auppwdTBox.TabIndex = 5;
            this.auppwdTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.auppwdTBox.WaterText = "";
            // 
            // upPwdTBox
            // 
            this.upPwdTBox.Location = new System.Drawing.Point(253, 87);
            this.upPwdTBox.Name = "upPwdTBox";
            this.upPwdTBox.PasswordChar = '*';
            this.upPwdTBox.Size = new System.Drawing.Size(259, 25);
            this.upPwdTBox.TabIndex = 4;
            this.upPwdTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.upPwdTBox.WaterText = "";
            // 
            // upnameTBox
            // 
            this.upnameTBox.Location = new System.Drawing.Point(253, 40);
            this.upnameTBox.Name = "upnameTBox";
            this.upnameTBox.Size = new System.Drawing.Size(259, 25);
            this.upnameTBox.TabIndex = 3;
            this.upnameTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.upnameTBox.WaterText = "";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(112, 136);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(114, 20);
            this.skinLabel4.TabIndex = 2;
            this.skinLabel4.Text = "再次输入密码：";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(172, 87);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(54, 20);
            this.skinLabel5.TabIndex = 1;
            this.skinLabel5.Text = "密码：";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(157, 40);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(69, 20);
            this.skinLabel6.TabIndex = 0;
            this.skinLabel6.Text = "用户名：";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "用户名";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // updateDate
            // 
            this.updateDate.DataPropertyName = "updateDate";
            this.updateDate.HeaderText = "操作时间";
            this.updateDate.Name = "updateDate";
            this.updateDate.ReadOnly = true;
            // 
            // pword
            // 
            this.pword.DataPropertyName = "pword";
            this.pword.HeaderText = "用户密码";
            this.pword.Name = "pword";
            this.pword.ReadOnly = true;
            this.pword.Visible = false;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "uid";
            this.uid.HeaderText = "操作人id";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Visible = false;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 572);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.useDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.InheritBack = true;
            this.InheritTheme = true;
            this.Name = "userForm";
            this.ShadowWidth = 1;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.useDataGridView)).EndInit();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView useDataGridView;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinButton cleanBtn;
        private CCWin.SkinControl.SkinButton addBtn;
        private CCWin.SkinControl.SkinWaterTextBox addApwdTBox;
        private CCWin.SkinControl.SkinWaterTextBox addPwdTBox;
        private CCWin.SkinControl.SkinWaterTextBox addNameTBox;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinButton upBtn;
        private CCWin.SkinControl.SkinWaterTextBox auppwdTBox;
        private CCWin.SkinControl.SkinWaterTextBox upPwdTBox;
        private CCWin.SkinControl.SkinWaterTextBox upnameTBox;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pword;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
    }
}