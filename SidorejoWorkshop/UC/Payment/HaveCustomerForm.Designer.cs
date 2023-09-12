namespace SidorejoWorkshop.UC.Payment
{
    partial class HaveCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rBtnYes = new System.Windows.Forms.RadioButton();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.gBoxCustomer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tBoxPho = new System.Windows.Forms.TextBox();
            this.tBoxAds = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gBoxCustomer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.iBtnClose.Location = new System.Drawing.Point(355, 0);
            this.iBtnClose.Name = "iBtnClose";
            this.iBtnClose.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iBtnClose.Size = new System.Drawing.Size(27, 23);
            this.iBtnClose.TabIndex = 0;
            this.iBtnClose.Text = "\r\n";
            this.iBtnClose.UseVisualStyleBackColor = false;
            this.iBtnClose.Click += new System.EventHandler(this.iBtnClose_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.36735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.63265F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rBtnYes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rBtnNo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 53);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // rBtnYes
            // 
            this.rBtnYes.AutoSize = true;
            this.rBtnYes.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnYes.Location = new System.Drawing.Point(3, 29);
            this.rBtnYes.Name = "rBtnYes";
            this.rBtnYes.Size = new System.Drawing.Size(44, 21);
            this.rBtnYes.TabIndex = 2;
            this.rBtnYes.TabStop = true;
            this.rBtnYes.Text = "Yes";
            this.rBtnYes.UseVisualStyleBackColor = true;
            this.rBtnYes.CheckedChanged += new System.EventHandler(this.rBtnYes_CheckedChanged);
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnNo.Location = new System.Drawing.Point(88, 29);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(42, 21);
            this.rBtnNo.TabIndex = 3;
            this.rBtnNo.TabStop = true;
            this.rBtnNo.Text = "No";
            this.rBtnNo.UseVisualStyleBackColor = true;
            this.rBtnNo.CheckedChanged += new System.EventHandler(this.rBtnNo_CheckedChanged);
            // 
            // gBoxCustomer
            // 
            this.gBoxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gBoxCustomer.Controls.Add(this.tableLayoutPanel2);
            this.gBoxCustomer.Enabled = false;
            this.gBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxCustomer.Location = new System.Drawing.Point(12, 97);
            this.gBoxCustomer.Name = "gBoxCustomer";
            this.gBoxCustomer.Size = new System.Drawing.Size(357, 176);
            this.gBoxCustomer.TabIndex = 3;
            this.gBoxCustomer.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.79268F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.20731F));
            this.tableLayoutPanel2.Controls.Add(this.tBoxPho, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tBoxAds, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tBoxName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tBoxId, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(351, 155);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tBoxPho
            // 
            this.tBoxPho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxPho.Enabled = false;
            this.tBoxPho.Location = new System.Drawing.Point(111, 123);
            this.tBoxPho.Name = "tBoxPho";
            this.tBoxPho.Size = new System.Drawing.Size(237, 22);
            this.tBoxPho.TabIndex = 9;
            // 
            // tBoxAds
            // 
            this.tBoxAds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxAds.Enabled = false;
            this.tBoxAds.Location = new System.Drawing.Point(111, 84);
            this.tBoxAds.Name = "tBoxAds";
            this.tBoxAds.Size = new System.Drawing.Size(237, 22);
            this.tBoxAds.TabIndex = 8;
            // 
            // tBoxName
            // 
            this.tBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxName.Enabled = false;
            this.tBoxName.Location = new System.Drawing.Point(111, 46);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(237, 22);
            this.tBoxName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(102, 41);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(102, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(102, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(102, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxId
            // 
            this.tBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxId.Location = new System.Drawing.Point(111, 8);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.ReadOnly = true;
            this.tBoxId.Size = new System.Drawing.Size(237, 22);
            this.tBoxId.TabIndex = 6;
            this.tBoxId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxId_KeyDown);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.Location = new System.Drawing.Point(266, 279);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(103, 30);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // HaveCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 321);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.gBoxCustomer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.iBtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HaveCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HaveCustomerForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gBoxCustomer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iBtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rBtnYes;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.GroupBox gBoxCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tBoxPho;
        private System.Windows.Forms.TextBox tBoxAds;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.Button btnPay;
    }
}