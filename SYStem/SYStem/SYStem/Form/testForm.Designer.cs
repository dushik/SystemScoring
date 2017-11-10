namespace SYStem
{
    partial class testForm
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
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.addTestBtn = new CCWin.SkinControl.SkinButton();
            this.addTestTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.delTestBtn = new CCWin.SkinControl.SkinButton();
            this.upTestBtn = new CCWin.SkinControl.SkinButton();
            this.UpTestTBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.dataGridViewTest = new CCWin.SkinControl.SkinDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).BeginInit();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Controls.Add(this.addTestBtn);
            this.skinGroupBox1.Controls.Add(this.addTestTBox);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(476, 57);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(684, 151);
            this.skinGroupBox1.TabIndex = 1;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "添加考试";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // addTestBtn
            // 
            this.addTestBtn.BackColor = System.Drawing.Color.Transparent;
            this.addTestBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.addTestBtn.DownBack = null;
            this.addTestBtn.Font = new System.Drawing.Font("宋体", 10F);
            this.addTestBtn.ForeColor = System.Drawing.Color.Blue;
            this.addTestBtn.Location = new System.Drawing.Point(551, 73);
            this.addTestBtn.MouseBack = null;
            this.addTestBtn.Name = "addTestBtn";
            this.addTestBtn.NormlBack = null;
            this.addTestBtn.Size = new System.Drawing.Size(75, 24);
            this.addTestBtn.TabIndex = 2;
            this.addTestBtn.Text = "添加";
            this.addTestBtn.UseVisualStyleBackColor = false;
            this.addTestBtn.Click += new System.EventHandler(this.addTestBtn_Click);
            // 
            // addTestTBox
            // 
            this.addTestTBox.Location = new System.Drawing.Point(141, 73);
            this.addTestTBox.Multiline = true;
            this.addTestTBox.Name = "addTestTBox";
            this.addTestTBox.Size = new System.Drawing.Size(373, 25);
            this.addTestTBox.TabIndex = 1;
            this.addTestTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.addTestTBox.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel1.Location = new System.Drawing.Point(40, 73);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(95, 23);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "考试名称：";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.Controls.Add(this.delTestBtn);
            this.skinGroupBox2.Controls.Add(this.upTestBtn);
            this.skinGroupBox2.Controls.Add(this.UpTestTBox);
            this.skinGroupBox2.Controls.Add(this.skinLabel3);
            this.skinGroupBox2.Controls.Add(this.skinLabel2);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Location = new System.Drawing.Point(476, 266);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(684, 247);
            this.skinGroupBox2.TabIndex = 2;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "修改考试";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // delTestBtn
            // 
            this.delTestBtn.BackColor = System.Drawing.Color.Transparent;
            this.delTestBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.delTestBtn.DownBack = null;
            this.delTestBtn.Location = new System.Drawing.Point(533, 165);
            this.delTestBtn.MouseBack = null;
            this.delTestBtn.Name = "delTestBtn";
            this.delTestBtn.NormlBack = null;
            this.delTestBtn.Size = new System.Drawing.Size(75, 23);
            this.delTestBtn.TabIndex = 4;
            this.delTestBtn.Text = "删除";
            this.delTestBtn.UseVisualStyleBackColor = false;
            this.delTestBtn.Click += new System.EventHandler(this.delTestBtn_Click);
            // 
            // upTestBtn
            // 
            this.upTestBtn.BackColor = System.Drawing.Color.Transparent;
            this.upTestBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.upTestBtn.DownBack = null;
            this.upTestBtn.Location = new System.Drawing.Point(533, 83);
            this.upTestBtn.MouseBack = null;
            this.upTestBtn.Name = "upTestBtn";
            this.upTestBtn.NormlBack = null;
            this.upTestBtn.Size = new System.Drawing.Size(75, 23);
            this.upTestBtn.TabIndex = 3;
            this.upTestBtn.Text = "修改";
            this.upTestBtn.UseVisualStyleBackColor = false;
            this.upTestBtn.Click += new System.EventHandler(this.upTestBtn_Click);
            // 
            // UpTestTBox
            // 
            this.UpTestTBox.Location = new System.Drawing.Point(141, 81);
            this.UpTestTBox.Name = "UpTestTBox";
            this.UpTestTBox.Size = new System.Drawing.Size(341, 25);
            this.UpTestTBox.TabIndex = 2;
            this.UpTestTBox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.UpTestTBox.WaterText = "";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.skinLabel3.Location = new System.Drawing.Point(40, 79);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(95, 23);
            this.skinLabel3.TabIndex = 1;
            this.skinLabel3.Text = "考试名称：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Brown;
            this.skinLabel2.Location = new System.Drawing.Point(158, 42);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(324, 19);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "请在左侧选择要修改的考试科目！";
            // 
            // dataGridViewTest
            // 
            this.dataGridViewTest.AllowUserToAddRows = false;
            this.dataGridViewTest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dataGridViewTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTest.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTest.ColumnFont = null;
            this.dataGridViewTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.number,
            this.updateDate,
            this.uid});
            this.dataGridViewTest.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTest.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTest.EnableHeadersVisualStyles = false;
            this.dataGridViewTest.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewTest.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridViewTest.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewTest.Location = new System.Drawing.Point(7, 57);
            this.dataGridViewTest.MultiSelect = false;
            this.dataGridViewTest.Name = "dataGridViewTest";
            this.dataGridViewTest.ReadOnly = true;
            this.dataGridViewTest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewTest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTest.RowTemplate.Height = 23;
            this.dataGridViewTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTest.Size = new System.Drawing.Size(447, 456);
            this.dataGridViewTest.TabIndex = 3;
            this.dataGridViewTest.TitleBack = null;
            this.dataGridViewTest.TitleBackColorBegin = System.Drawing.Color.White;
            this.dataGridViewTest.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dataGridViewTest.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTest_RowEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "考试名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "班级人数";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 104;
            // 
            // updateDate
            // 
            this.updateDate.DataPropertyName = "updateDate";
            this.updateDate.HeaderText = "操作日期";
            this.updateDate.Name = "updateDate";
            this.updateDate.ReadOnly = true;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "uid";
            this.uid.HeaderText = "操作员";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Visible = false;
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 571);
            this.Controls.Add(this.dataGridViewTest);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.InheritBack = true;
            this.InheritTheme = true;
            this.Name = "testForm";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.Text = "";
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinButton addTestBtn;
        private CCWin.SkinControl.SkinWaterTextBox addTestTBox;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinButton delTestBtn;
        private CCWin.SkinControl.SkinButton upTestBtn;
        private CCWin.SkinControl.SkinWaterTextBox UpTestTBox;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinDataGridView dataGridViewTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
    }
}