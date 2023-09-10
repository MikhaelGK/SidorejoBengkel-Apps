namespace SidorejoWorkshop.UC.Manage
{
    partial class ManageCustomerControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iBtnCancel = new FontAwesome.Sharp.IconButton();
            this.iBtnSave = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tBoxPho = new System.Windows.Forms.TextBox();
            this.tBoxAds = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.iBtnDelete = new FontAwesome.Sharp.IconButton();
            this.iBtnUpdate = new FontAwesome.Sharp.IconButton();
            this.iBtnAdd = new FontAwesome.Sharp.IconButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colCId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(793, 61);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.93221F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iBtnSearch, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 41);
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
            this.label1.Size = new System.Drawing.Size(89, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(98, 9);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(574, 22);
            this.tbSearch.TabIndex = 1;
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iBtnSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnSearch.IconColor = System.Drawing.Color.Black;
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.Location = new System.Drawing.Point(678, 3);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(92, 35);
            this.iBtnSearch.TabIndex = 2;
            this.iBtnSearch.Text = "Search";
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iBtnCancel);
            this.panel2.Controls.Add(this.iBtnSave);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.iBtnDelete);
            this.panel2.Controls.Add(this.iBtnUpdate);
            this.panel2.Controls.Add(this.iBtnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 357);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(793, 238);
            this.panel2.TabIndex = 3;
            // 
            // iBtnCancel
            // 
            this.iBtnCancel.Enabled = false;
            this.iBtnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnCancel.IconColor = System.Drawing.Color.Black;
            this.iBtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCancel.Location = new System.Drawing.Point(681, 115);
            this.iBtnCancel.Name = "iBtnCancel";
            this.iBtnCancel.Size = new System.Drawing.Size(112, 37);
            this.iBtnCancel.TabIndex = 14;
            this.iBtnCancel.Text = "Cancel";
            this.iBtnCancel.UseVisualStyleBackColor = true;
            // 
            // iBtnSave
            // 
            this.iBtnSave.Enabled = false;
            this.iBtnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnSave.IconColor = System.Drawing.Color.Black;
            this.iBtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSave.Location = new System.Drawing.Point(681, 72);
            this.iBtnSave.Name = "iBtnSave";
            this.iBtnSave.Size = new System.Drawing.Size(112, 37);
            this.iBtnSave.TabIndex = 13;
            this.iBtnSave.Text = "Save";
            this.iBtnSave.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59381F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.4062F));
            this.tableLayoutPanel2.Controls.Add(this.tBoxPho, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tBoxAds, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tBoxName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tBoxId, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 219);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tBoxPho
            // 
            this.tBoxPho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxPho.Enabled = false;
            this.tBoxPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPho.Location = new System.Drawing.Point(149, 179);
            this.tBoxPho.Name = "tBoxPho";
            this.tBoxPho.Size = new System.Drawing.Size(397, 22);
            this.tBoxPho.TabIndex = 11;
            // 
            // tBoxAds
            // 
            this.tBoxAds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxAds.Enabled = false;
            this.tBoxAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAds.Location = new System.Drawing.Point(149, 124);
            this.tBoxAds.Name = "tBoxAds";
            this.tBoxAds.Size = new System.Drawing.Size(397, 22);
            this.tBoxAds.TabIndex = 10;
            // 
            // tBoxName
            // 
            this.tBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxName.Enabled = false;
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxName.Location = new System.Drawing.Point(149, 70);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(397, 22);
            this.tBoxName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(140, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(140, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(140, 54);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 162);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(140, 57);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number Phone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxId
            // 
            this.tBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxId.Enabled = false;
            this.tBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxId.Location = new System.Drawing.Point(149, 16);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.Size = new System.Drawing.Size(397, 22);
            this.tBoxId.TabIndex = 4;
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnDelete.IconColor = System.Drawing.Color.Black;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(563, 140);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(112, 37);
            this.iBtnDelete.TabIndex = 11;
            this.iBtnDelete.Text = "Delete";
            this.iBtnDelete.UseVisualStyleBackColor = true;
            // 
            // iBtnUpdate
            // 
            this.iBtnUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnUpdate.IconColor = System.Drawing.Color.Black;
            this.iBtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnUpdate.Location = new System.Drawing.Point(563, 97);
            this.iBtnUpdate.Name = "iBtnUpdate";
            this.iBtnUpdate.Size = new System.Drawing.Size(112, 37);
            this.iBtnUpdate.TabIndex = 10;
            this.iBtnUpdate.Text = "Edit";
            this.iBtnUpdate.UseVisualStyleBackColor = true;
            // 
            // iBtnAdd
            // 
            this.iBtnAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnAdd.IconColor = System.Drawing.Color.Black;
            this.iBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAdd.Location = new System.Drawing.Point(563, 54);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Size = new System.Drawing.Size(112, 37);
            this.iBtnAdd.TabIndex = 9;
            this.iBtnAdd.Text = "Add";
            this.iBtnAdd.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCId,
            this.colName,
            this.colAds,
            this.colPho});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 64);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(793, 293);
            this.dgv.TabIndex = 4;
            // 
            // colCId
            // 
            this.colCId.DataPropertyName = "colCId";
            this.colCId.HeaderText = "Customer ID";
            this.colCId.Name = "colCId";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "colName";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colAds
            // 
            this.colAds.DataPropertyName = "colAds";
            this.colAds.HeaderText = "Address";
            this.colAds.Name = "colAds";
            // 
            // colPho
            // 
            this.colPho.DataPropertyName = "colPho";
            this.colPho.HeaderText = "Number Phone";
            this.colPho.Name = "colPho";
            // 
            // ManageCustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCustomerControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(799, 598);
            this.Load += new System.EventHandler(this.ManageCustomerControl_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iBtnCancel;
        private FontAwesome.Sharp.IconButton iBtnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tBoxPho;
        private System.Windows.Forms.TextBox tBoxAds;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxId;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private FontAwesome.Sharp.IconButton iBtnUpdate;
        private FontAwesome.Sharp.IconButton iBtnAdd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPho;
    }
}
