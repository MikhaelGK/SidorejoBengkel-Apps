namespace SidorejoWorkshop.UC.Payment
{
    partial class TransactionHomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new SidorejoWorkshop.Helper.GradientPanel();
            this.iBtnService = new FontAwesome.Sharp.IconButton();
            this.iBtnProduct = new FontAwesome.Sharp.IconButton();
            this.gradientPanel2 = new SidorejoWorkshop.Helper.GradientPanel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.iBtnService);
            this.panel1.Controls.Add(this.iBtnProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 65);
            this.panel1.TabIndex = 1;
            // 
            // sidePanel
            // 
            this.sidePanel.Angle = 0F;
            this.sidePanel.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(172, 10);
            this.sidePanel.TabIndex = 4;
            this.sidePanel.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            // 
            // iBtnService
            // 
            this.iBtnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.iBtnService.BackColor = System.Drawing.Color.Transparent;
            this.iBtnService.FlatAppearance.BorderSize = 0;
            this.iBtnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnService.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnService.ForeColor = System.Drawing.Color.Black;
            this.iBtnService.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnService.IconColor = System.Drawing.Color.White;
            this.iBtnService.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnService.IconSize = 28;
            this.iBtnService.Location = new System.Drawing.Point(175, 0);
            this.iBtnService.Name = "iBtnService";
            this.iBtnService.Size = new System.Drawing.Size(169, 65);
            this.iBtnService.TabIndex = 3;
            this.iBtnService.Text = "Service";
            this.iBtnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnService.UseVisualStyleBackColor = false;
            this.iBtnService.Click += new System.EventHandler(this.iBtnService_Click);
            // 
            // iBtnProduct
            // 
            this.iBtnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.iBtnProduct.BackColor = System.Drawing.Color.Transparent;
            this.iBtnProduct.FlatAppearance.BorderSize = 0;
            this.iBtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnProduct.ForeColor = System.Drawing.Color.Black;
            this.iBtnProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnProduct.IconColor = System.Drawing.Color.White;
            this.iBtnProduct.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBtnProduct.IconSize = 28;
            this.iBtnProduct.Location = new System.Drawing.Point(0, 0);
            this.iBtnProduct.Name = "iBtnProduct";
            this.iBtnProduct.Size = new System.Drawing.Size(169, 65);
            this.iBtnProduct.TabIndex = 2;
            this.iBtnProduct.Text = "Product";
            this.iBtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnProduct.UseVisualStyleBackColor = false;
            this.iBtnProduct.Click += new System.EventHandler(this.iBtnProduct_Click);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 65);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(799, 10);
            this.gradientPanel2.TabIndex = 3;
            this.gradientPanel2.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 75);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(799, 608);
            this.contentPanel.TabIndex = 4;
            // 
            // TransactionHomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionHomeControl";
            this.Size = new System.Drawing.Size(799, 683);
            this.Load += new System.EventHandler(this.TransactionHomeControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iBtnService;
        private FontAwesome.Sharp.IconButton iBtnProduct;
        private Helper.GradientPanel gradientPanel2;
        private Helper.GradientPanel sidePanel;
        private System.Windows.Forms.Panel contentPanel;
    }
}
