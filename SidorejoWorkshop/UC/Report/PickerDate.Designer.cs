namespace SidorejoWorkshop.UC.Report
{
    partial class PickerDate
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
            this.iBtnClose = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtnYes = new System.Windows.Forms.RadioButton();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.gBoxYear = new System.Windows.Forms.GroupBox();
            this.gBoxMonth = new System.Windows.Forms.GroupBox();
            this.cBoxMonth = new System.Windows.Forms.ComboBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.gBoxYear.SuspendLayout();
            this.gBoxMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // iBtnClose
            // 
            this.iBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnClose.BackColor = System.Drawing.Color.Red;
            this.iBtnClose.FlatAppearance.BorderSize = 0;
            this.iBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iBtnClose.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.iBtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnClose.IconSize = 28;
            this.iBtnClose.Location = new System.Drawing.Point(248, 0);
            this.iBtnClose.Name = "iBtnClose";
            this.iBtnClose.Padding = new System.Windows.Forms.Padding(2);
            this.iBtnClose.Size = new System.Drawing.Size(27, 23);
            this.iBtnClose.TabIndex = 1;
            this.iBtnClose.Text = "\r\n";
            this.iBtnClose.UseVisualStyleBackColor = false;
            this.iBtnClose.Click += new System.EventHandler(this.iBtnClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.2F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rBtnYes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rBtnNo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 47);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Month?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rBtnYes
            // 
            this.rBtnYes.AutoSize = true;
            this.rBtnYes.Checked = true;
            this.rBtnYes.Location = new System.Drawing.Point(3, 26);
            this.rBtnYes.Name = "rBtnYes";
            this.rBtnYes.Size = new System.Drawing.Size(43, 17);
            this.rBtnYes.TabIndex = 2;
            this.rBtnYes.TabStop = true;
            this.rBtnYes.Text = "Yes";
            this.rBtnYes.UseVisualStyleBackColor = true;
            this.rBtnYes.CheckedChanged += new System.EventHandler(this.rBtnYes_CheckedChanged);
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Location = new System.Drawing.Point(80, 26);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(39, 17);
            this.rBtnNo.TabIndex = 3;
            this.rBtnNo.Text = "No";
            this.rBtnNo.UseVisualStyleBackColor = true;
            this.rBtnNo.CheckedChanged += new System.EventHandler(this.rBtnNo_CheckedChanged);
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(16, 19);
            this.nudYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(68, 20);
            this.nudYear.TabIndex = 7;
            this.nudYear.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            // 
            // gBoxYear
            // 
            this.gBoxYear.Controls.Add(this.nudYear);
            this.gBoxYear.Location = new System.Drawing.Point(12, 29);
            this.gBoxYear.Name = "gBoxYear";
            this.gBoxYear.Size = new System.Drawing.Size(250, 50);
            this.gBoxYear.TabIndex = 8;
            this.gBoxYear.TabStop = false;
            this.gBoxYear.Text = "Find Years";
            // 
            // gBoxMonth
            // 
            this.gBoxMonth.Controls.Add(this.cBoxMonth);
            this.gBoxMonth.Location = new System.Drawing.Point(12, 138);
            this.gBoxMonth.Name = "gBoxMonth";
            this.gBoxMonth.Size = new System.Drawing.Size(250, 50);
            this.gBoxMonth.TabIndex = 9;
            this.gBoxMonth.TabStop = false;
            this.gBoxMonth.Text = "Month";
            // 
            // cBoxMonth
            // 
            this.cBoxMonth.FormattingEnabled = true;
            this.cBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cBoxMonth.Location = new System.Drawing.Point(16, 19);
            this.cBoxMonth.Name = "cBoxMonth";
            this.cBoxMonth.Size = new System.Drawing.Size(95, 21);
            this.cBoxMonth.TabIndex = 0;
            // 
            // btnPick
            // 
            this.btnPick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPick.Location = new System.Drawing.Point(94, 210);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(85, 31);
            this.btnPick.TabIndex = 10;
            this.btnPick.Text = "Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // PickerDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 253);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.gBoxMonth);
            this.Controls.Add(this.gBoxYear);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.iBtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PickerDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickerDate";
            this.Load += new System.EventHandler(this.PickerDate_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.gBoxYear.ResumeLayout(false);
            this.gBoxMonth.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtnYes;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.GroupBox gBoxYear;
        private System.Windows.Forms.GroupBox gBoxMonth;
        private System.Windows.Forms.ComboBox cBoxMonth;
        private System.Windows.Forms.Button btnPick;
    }
}