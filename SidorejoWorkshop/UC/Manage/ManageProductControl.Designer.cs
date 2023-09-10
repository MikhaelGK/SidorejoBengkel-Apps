namespace SidorejoWorkshop.UC.Manage
{
    partial class ManageProductControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProductLabel = new System.Windows.Forms.Label();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(799, 61);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.93221F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iBtnSearch, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(90, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(99, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(581, 22);
            this.tbSearch.TabIndex = 1;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBtnSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnSearch.IconColor = System.Drawing.Color.Black;
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.Location = new System.Drawing.Point(686, 3);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(90, 35);
            this.iBtnSearch.TabIndex = 2;
            this.iBtnSearch.Text = "Search";
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.totalProductLabel);
            this.splitContainer1.Panel2.Controls.Add(this.iBtnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.iBtnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.iBtnAdd);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.splitContainer1.Size = new System.Drawing.Size(799, 537);
            this.splitContainer1.SplitterDistance = 660;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colDesc,
            this.colQty,
            this.colCostPrice,
            this.colPrice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(10, 0);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(650, 527);
            this.dgv.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "colId";
            this.colId.HeaderText = "Product ID";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "colName";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colDesc
            // 
            this.colDesc.DataPropertyName = "colDesc";
            this.colDesc.HeaderText = "Description";
            this.colDesc.Name = "colDesc";
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "colQty";
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            // 
            // colCostPrice
            // 
            this.colCostPrice.DataPropertyName = "colCostPrice";
            this.colCostPrice.HeaderText = "Cost Price";
            this.colCostPrice.Name = "colCostPrice";
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "colPrice";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // totalProductLabel
            // 
            this.totalProductLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalProductLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductLabel.Location = new System.Drawing.Point(0, 488);
            this.totalProductLabel.Name = "totalProductLabel";
            this.totalProductLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.totalProductLabel.Size = new System.Drawing.Size(125, 39);
            this.totalProductLabel.TabIndex = 3;
            this.totalProductLabel.Text = "Total Product: 0";
            this.totalProductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnDelete.IconColor = System.Drawing.Color.Black;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(2, 92);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(112, 37);
            this.iBtnDelete.TabIndex = 2;
            this.iBtnDelete.Text = "Delete";
            this.iBtnDelete.UseVisualStyleBackColor = true;
            this.iBtnDelete.Click += new System.EventHandler(this.iBtnDelete_Click);
            // 
            // iBtnUpdate
            // 
            this.iBtnUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnUpdate.IconColor = System.Drawing.Color.Black;
            this.iBtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnUpdate.Location = new System.Drawing.Point(2, 49);
            this.iBtnUpdate.Name = "iBtnUpdate";
            this.iBtnUpdate.Size = new System.Drawing.Size(112, 37);
            this.iBtnUpdate.TabIndex = 1;
            this.iBtnUpdate.Text = "Edit";
            this.iBtnUpdate.UseVisualStyleBackColor = true;
            this.iBtnUpdate.Click += new System.EventHandler(this.iBtnUpdate_Click);
            // 
            // iBtnAdd
            // 
            this.iBtnAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnAdd.IconColor = System.Drawing.Color.Black;
            this.iBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAdd.Location = new System.Drawing.Point(3, 6);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Size = new System.Drawing.Size(112, 37);
            this.iBtnAdd.TabIndex = 0;
            this.iBtnAdd.Text = "Add";
            this.iBtnAdd.UseVisualStyleBackColor = true;
            this.iBtnAdd.Click += new System.EventHandler(this.iBtnAdd_Click);
            // 
            // ManageProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProductControl";
            this.Size = new System.Drawing.Size(799, 598);
            this.Load += new System.EventHandler(this.ManageProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label totalProductLabel;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private FontAwesome.Sharp.IconButton iBtnUpdate;
        private FontAwesome.Sharp.IconButton iBtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}
