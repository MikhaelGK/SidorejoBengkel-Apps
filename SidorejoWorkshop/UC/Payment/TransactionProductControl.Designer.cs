namespace SidorejoWorkshop.UC.Payment
{
    partial class TransactionProductControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lTrxId = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.gBoxProduct = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxPId = new System.Windows.Forms.TextBox();
            this.tBoxPName = new System.Windows.Forms.TextBox();
            this.tBoxSPrice = new System.Windows.Forms.TextBox();
            this.tBoxQty = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gBoxProduct.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lTrxId);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddToCart);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveFromCart);
            this.splitContainer1.Panel1.Controls.Add(this.gBoxProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(779, 588);
            this.splitContainer1.SplitterDistance = 416;
            this.splitContainer1.TabIndex = 0;
            // 
            // lTrxId
            // 
            this.lTrxId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lTrxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTrxId.Location = new System.Drawing.Point(0, 560);
            this.lTrxId.Name = "lTrxId";
            this.lTrxId.Size = new System.Drawing.Size(416, 28);
            this.lTrxId.TabIndex = 16;
            this.lTrxId.Text = "Transaction ID: T2023";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(297, 248);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(111, 36);
            this.btnAddToCart.TabIndex = 15;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(149, 248);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(142, 36);
            this.btnRemoveFromCart.TabIndex = 14;
            this.btnRemoveFromCart.Text = "Remove from Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // gBoxProduct
            // 
            this.gBoxProduct.Controls.Add(this.tableLayoutPanel1);
            this.gBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxProduct.Location = new System.Drawing.Point(3, 3);
            this.gBoxProduct.Name = "gBoxProduct";
            this.gBoxProduct.Size = new System.Drawing.Size(411, 239);
            this.gBoxProduct.TabIndex = 13;
            this.gBoxProduct.TabStop = false;
            this.gBoxProduct.Text = "Product Data";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.89655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.10345F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tBoxDesc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBoxPId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBoxPName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBoxSPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBoxQty, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 218);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxDesc
            // 
            this.tBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxDesc.Location = new System.Drawing.Point(132, 184);
            this.tBoxDesc.Name = "tBoxDesc";
            this.tBoxDesc.Size = new System.Drawing.Size(270, 22);
            this.tBoxDesc.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 43);
            this.label8.TabIndex = 5;
            this.label8.Text = "Qty";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 43);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sell Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxPId
            // 
            this.tBoxPId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxPId.Location = new System.Drawing.Point(132, 10);
            this.tBoxPId.Name = "tBoxPId";
            this.tBoxPId.ReadOnly = true;
            this.tBoxPId.Size = new System.Drawing.Size(270, 22);
            this.tBoxPId.TabIndex = 8;
            this.tBoxPId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxPId_KeyDown);
            // 
            // tBoxPName
            // 
            this.tBoxPName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxPName.Enabled = false;
            this.tBoxPName.Location = new System.Drawing.Point(132, 53);
            this.tBoxPName.Name = "tBoxPName";
            this.tBoxPName.Size = new System.Drawing.Size(270, 22);
            this.tBoxPName.TabIndex = 9;
            // 
            // tBoxSPrice
            // 
            this.tBoxSPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxSPrice.Enabled = false;
            this.tBoxSPrice.Location = new System.Drawing.Point(132, 96);
            this.tBoxSPrice.Name = "tBoxSPrice";
            this.tBoxSPrice.Size = new System.Drawing.Size(270, 22);
            this.tBoxSPrice.TabIndex = 10;
            // 
            // tBoxQty
            // 
            this.tBoxQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxQty.Location = new System.Drawing.Point(132, 139);
            this.tBoxQty.Name = "tBoxQty";
            this.tBoxQty.Size = new System.Drawing.Size(270, 22);
            this.tBoxQty.TabIndex = 11;
            // 
            // dgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPId,
            this.colPName,
            this.colQty,
            this.colSPrice,
            this.colSubs});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(359, 507);
            this.dgv.TabIndex = 18;
            // 
            // colPId
            // 
            this.colPId.DataPropertyName = "colPId";
            this.colPId.HeaderText = "Product ID";
            this.colPId.Name = "colPId";
            // 
            // colPName
            // 
            this.colPName.DataPropertyName = "colPName";
            this.colPName.HeaderText = "Product Name";
            this.colPName.Name = "colPName";
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "colQty";
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            // 
            // colSPrice
            // 
            this.colSPrice.DataPropertyName = "colSPrice";
            this.colSPrice.HeaderText = "Sell Price";
            this.colSPrice.Name = "colSPrice";
            // 
            // colSubs
            // 
            this.colSubs.DataPropertyName = "colSubs";
            this.colSubs.HeaderText = "Subtotal";
            this.colSubs.Name = "colSubs";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lTotal);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 507);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(359, 81);
            this.panel1.TabIndex = 17;
            // 
            // lTotal
            // 
            this.lTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTotal.Location = new System.Drawing.Point(5, 5);
            this.lTotal.Name = "lTotal";
            this.lTotal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lTotal.Size = new System.Drawing.Size(349, 33);
            this.lTotal.TabIndex = 8;
            this.lTotal.Text = "Total: Rp 0";
            this.lTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(240, 37);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(111, 36);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // TransactionProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TransactionProductControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(799, 608);
            this.Load += new System.EventHandler(this.TransactionProductControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gBoxProduct.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.GroupBox gBoxProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxPId;
        private System.Windows.Forms.TextBox tBoxPName;
        private System.Windows.Forms.TextBox tBoxSPrice;
        private System.Windows.Forms.TextBox tBoxQty;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxDesc;
        private System.Windows.Forms.Label lTrxId;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubs;
        private System.Windows.Forms.Panel panel1;
    }
}
