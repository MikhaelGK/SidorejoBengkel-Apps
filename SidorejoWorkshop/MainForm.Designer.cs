namespace SidorejoWorkshop
{
    partial class MainForm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new SidorejoWorkshop.Helper.GradientPanel();
            this.iBtnStock = new FontAwesome.Sharp.IconButton();
            this.sidePanel = new SidorejoWorkshop.Helper.GradientPanel();
            this.iBtnLogout = new FontAwesome.Sharp.IconButton();
            this.iBtnExit = new FontAwesome.Sharp.IconButton();
            this.iBtnReport = new FontAwesome.Sharp.IconButton();
            this.iBtnTransaction = new FontAwesome.Sharp.IconButton();
            this.iBtnManage = new FontAwesome.Sharp.IconButton();
            this.lTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(197, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(799, 683);
            this.contentPanel.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(234)))), ((int)(((byte)(207)))));
            this.gradientPanel1.Controls.Add(this.iBtnStock);
            this.gradientPanel1.Controls.Add(this.sidePanel);
            this.gradientPanel1.Controls.Add(this.iBtnLogout);
            this.gradientPanel1.Controls.Add(this.iBtnExit);
            this.gradientPanel1.Controls.Add(this.iBtnReport);
            this.gradientPanel1.Controls.Add(this.iBtnTransaction);
            this.gradientPanel1.Controls.Add(this.iBtnManage);
            this.gradientPanel1.Controls.Add(this.lTime);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(197, 683);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            // 
            // iBtnStock
            // 
            this.iBtnStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnStock.BackColor = System.Drawing.Color.Transparent;
            this.iBtnStock.FlatAppearance.BorderSize = 0;
            this.iBtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnStock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnStock.ForeColor = System.Drawing.Color.White;
            this.iBtnStock.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            this.iBtnStock.IconColor = System.Drawing.Color.White;
            this.iBtnStock.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnStock.IconSize = 28;
            this.iBtnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnStock.Location = new System.Drawing.Point(-1, 251);
            this.iBtnStock.Name = "iBtnStock";
            this.iBtnStock.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnStock.Size = new System.Drawing.Size(197, 52);
            this.iBtnStock.TabIndex = 8;
            this.iBtnStock.Text = "Incoming Stock";
            this.iBtnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnStock.UseVisualStyleBackColor = false;
            this.iBtnStock.Click += new System.EventHandler(this.iBtnStock_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.Angle = 135F;
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.BottomColor = System.Drawing.Color.Empty;
            this.sidePanel.Location = new System.Drawing.Point(0, 77);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(8, 52);
            this.sidePanel.TabIndex = 7;
            this.sidePanel.TopColor = System.Drawing.Color.Empty;
            // 
            // iBtnLogout
            // 
            this.iBtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.iBtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iBtnLogout.FlatAppearance.BorderSize = 0;
            this.iBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnLogout.ForeColor = System.Drawing.Color.White;
            this.iBtnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.iBtnLogout.IconColor = System.Drawing.Color.White;
            this.iBtnLogout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnLogout.IconSize = 28;
            this.iBtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnLogout.Location = new System.Drawing.Point(0, 577);
            this.iBtnLogout.Name = "iBtnLogout";
            this.iBtnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnLogout.Size = new System.Drawing.Size(195, 52);
            this.iBtnLogout.TabIndex = 5;
            this.iBtnLogout.Text = "Logout";
            this.iBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnLogout.UseVisualStyleBackColor = false;
            this.iBtnLogout.Click += new System.EventHandler(this.iBtnLogout_Click);
            // 
            // iBtnExit
            // 
            this.iBtnExit.BackColor = System.Drawing.Color.Transparent;
            this.iBtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iBtnExit.FlatAppearance.BorderSize = 0;
            this.iBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnExit.ForeColor = System.Drawing.Color.White;
            this.iBtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iBtnExit.IconColor = System.Drawing.Color.White;
            this.iBtnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnExit.IconSize = 28;
            this.iBtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnExit.Location = new System.Drawing.Point(0, 629);
            this.iBtnExit.Name = "iBtnExit";
            this.iBtnExit.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnExit.Size = new System.Drawing.Size(195, 52);
            this.iBtnExit.TabIndex = 4;
            this.iBtnExit.Text = "Exit";
            this.iBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnExit.UseVisualStyleBackColor = false;
            this.iBtnExit.Click += new System.EventHandler(this.iBtnExit_Click);
            // 
            // iBtnReport
            // 
            this.iBtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnReport.BackColor = System.Drawing.Color.Transparent;
            this.iBtnReport.FlatAppearance.BorderSize = 0;
            this.iBtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnReport.ForeColor = System.Drawing.Color.White;
            this.iBtnReport.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.iBtnReport.IconColor = System.Drawing.Color.White;
            this.iBtnReport.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnReport.IconSize = 28;
            this.iBtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnReport.Location = new System.Drawing.Point(-1, 193);
            this.iBtnReport.Name = "iBtnReport";
            this.iBtnReport.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnReport.Size = new System.Drawing.Size(197, 52);
            this.iBtnReport.TabIndex = 3;
            this.iBtnReport.Text = "Report";
            this.iBtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnReport.UseVisualStyleBackColor = false;
            this.iBtnReport.Click += new System.EventHandler(this.iBtnReport_Click);
            // 
            // iBtnTransaction
            // 
            this.iBtnTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.iBtnTransaction.FlatAppearance.BorderSize = 0;
            this.iBtnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnTransaction.ForeColor = System.Drawing.Color.White;
            this.iBtnTransaction.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.iBtnTransaction.IconColor = System.Drawing.Color.White;
            this.iBtnTransaction.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnTransaction.IconSize = 28;
            this.iBtnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnTransaction.Location = new System.Drawing.Point(-2, 135);
            this.iBtnTransaction.Name = "iBtnTransaction";
            this.iBtnTransaction.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnTransaction.Size = new System.Drawing.Size(197, 52);
            this.iBtnTransaction.TabIndex = 2;
            this.iBtnTransaction.Text = "Payment";
            this.iBtnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnTransaction.UseVisualStyleBackColor = false;
            this.iBtnTransaction.Click += new System.EventHandler(this.iBtnTransaction_Click);
            // 
            // iBtnManage
            // 
            this.iBtnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iBtnManage.BackColor = System.Drawing.Color.Transparent;
            this.iBtnManage.FlatAppearance.BorderSize = 0;
            this.iBtnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnManage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnManage.ForeColor = System.Drawing.Color.White;
            this.iBtnManage.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iBtnManage.IconColor = System.Drawing.Color.White;
            this.iBtnManage.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnManage.IconSize = 28;
            this.iBtnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnManage.Location = new System.Drawing.Point(-1, 77);
            this.iBtnManage.Name = "iBtnManage";
            this.iBtnManage.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.iBtnManage.Size = new System.Drawing.Size(197, 52);
            this.iBtnManage.TabIndex = 1;
            this.iBtnManage.Text = "Manage";
            this.iBtnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnManage.UseVisualStyleBackColor = false;
            this.iBtnManage.Click += new System.EventHandler(this.iBtnManage_Click);
            // 
            // lTime
            // 
            this.lTime.BackColor = System.Drawing.Color.Transparent;
            this.lTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTime.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.ForeColor = System.Drawing.Color.White;
            this.lTime.Location = new System.Drawing.Point(0, 0);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(195, 32);
            this.lTime.TabIndex = 0;
            this.lTime.Text = "Time";
            this.lTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(197, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 683);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Helper.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconButton iBtnManage;
        private FontAwesome.Sharp.IconButton iBtnTransaction;
        private FontAwesome.Sharp.IconButton iBtnReport;
        private FontAwesome.Sharp.IconButton iBtnLogout;
        private FontAwesome.Sharp.IconButton iBtnExit;
        private Helper.GradientPanel sidePanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iBtnStock;
    }
}