namespace SidorejoWorkshop.UC.Manage
{
    partial class ManageCustomerVehicleControl
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
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iBtnCancel = new FontAwesome.Sharp.IconButton();
            this.iBtnSave = new FontAwesome.Sharp.IconButton();
            this.gBoxVehicle = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxVName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxVId = new System.Windows.Forms.TextBox();
            this.tBoxVNumber = new System.Windows.Forms.TextBox();
            this.gBoxCustomer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxCId = new System.Windows.Forms.TextBox();
            this.tBoxPho = new System.Windows.Forms.TextBox();
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
            this.panel2.SuspendLayout();
            this.gBoxVehicle.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gBoxCustomer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(799, 58);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.93221F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBoxSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.iBtnSearch, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 38);
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
            this.label1.Size = new System.Drawing.Size(89, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSearch.Location = new System.Drawing.Point(98, 8);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(574, 22);
            this.tBoxSearch.TabIndex = 1;
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
            this.iBtnSearch.Size = new System.Drawing.Size(98, 32);
            this.iBtnSearch.TabIndex = 2;
            this.iBtnSearch.Text = "Search";
            this.iBtnSearch.UseVisualStyleBackColor = true;
            this.iBtnSearch.Click += new System.EventHandler(this.iBtnSearch_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gBoxVehicle);
            this.splitContainer1.Panel2.Controls.Add(this.gBoxCustomer);
            this.splitContainer1.Panel2.Controls.Add(this.iBtnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.iBtnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.iBtnAdd);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(799, 540);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 5;
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
            this.colId,
            this.colCId,
            this.colCName,
            this.colVName,
            this.colVNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(5, 5);
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
            this.dgv.Size = new System.Drawing.Size(411, 487);
            this.dgv.TabIndex = 18;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "colId";
            this.colId.HeaderText = "Customer Vehicle Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colCId
            // 
            this.colCId.DataPropertyName = "colCId";
            this.colCId.HeaderText = "Customer Id";
            this.colCId.Name = "colCId";
            // 
            // colCName
            // 
            this.colCName.DataPropertyName = "colCName";
            this.colCName.HeaderText = "Customer Name";
            this.colCName.Name = "colCName";
            // 
            // colVName
            // 
            this.colVName.DataPropertyName = "colVName";
            this.colVName.HeaderText = "Vehicle Name";
            this.colVName.Name = "colVName";
            // 
            // colVNumber
            // 
            this.colVNumber.DataPropertyName = "colVNumber";
            this.colVNumber.HeaderText = "Police Number";
            this.colVNumber.Name = "colVNumber";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iBtnCancel);
            this.panel2.Controls.Add(this.iBtnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 43);
            this.panel2.TabIndex = 17;
            // 
            // iBtnCancel
            // 
            this.iBtnCancel.Enabled = false;
            this.iBtnCancel.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnCancel.IconColor = System.Drawing.Color.Black;
            this.iBtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCancel.Location = new System.Drawing.Point(121, 3);
            this.iBtnCancel.Name = "iBtnCancel";
            this.iBtnCancel.Size = new System.Drawing.Size(112, 37);
            this.iBtnCancel.TabIndex = 22;
            this.iBtnCancel.Text = "Cancel";
            this.iBtnCancel.UseVisualStyleBackColor = true;
            this.iBtnCancel.Click += new System.EventHandler(this.iBtnCancel_Click);
            // 
            // iBtnSave
            // 
            this.iBtnSave.Enabled = false;
            this.iBtnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnSave.IconColor = System.Drawing.Color.Black;
            this.iBtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSave.Location = new System.Drawing.Point(3, 3);
            this.iBtnSave.Name = "iBtnSave";
            this.iBtnSave.Size = new System.Drawing.Size(112, 37);
            this.iBtnSave.TabIndex = 21;
            this.iBtnSave.Text = "Save";
            this.iBtnSave.UseVisualStyleBackColor = true;
            this.iBtnSave.Click += new System.EventHandler(this.iBtnSave_Click);
            // 
            // gBoxVehicle
            // 
            this.gBoxVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxVehicle.Controls.Add(this.tableLayoutPanel3);
            this.gBoxVehicle.Enabled = false;
            this.gBoxVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxVehicle.Location = new System.Drawing.Point(12, 198);
            this.gBoxVehicle.Name = "gBoxVehicle";
            this.gBoxVehicle.Size = new System.Drawing.Size(349, 157);
            this.gBoxVehicle.TabIndex = 22;
            this.gBoxVehicle.TabStop = false;
            this.gBoxVehicle.Text = "Vehicle Data";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.15625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.84375F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tBoxVName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tBoxVId, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tBoxVNumber, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(343, 136);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(114, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "Police Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxVName
            // 
            this.tBoxVName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxVName.Enabled = false;
            this.tBoxVName.Location = new System.Drawing.Point(123, 56);
            this.tBoxVName.Name = "tBoxVName";
            this.tBoxVName.Size = new System.Drawing.Size(217, 22);
            this.tBoxVName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(114, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vehicle Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 45);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(114, 45);
            this.label7.TabIndex = 1;
            this.label7.Text = "Vehicle Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxVId
            // 
            this.tBoxVId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxVId.Location = new System.Drawing.Point(123, 11);
            this.tBoxVId.Name = "tBoxVId";
            this.tBoxVId.ReadOnly = true;
            this.tBoxVId.Size = new System.Drawing.Size(217, 22);
            this.tBoxVId.TabIndex = 4;
            this.tBoxVId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxVId_KeyDown);
            // 
            // tBoxVNumber
            // 
            this.tBoxVNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxVNumber.Location = new System.Drawing.Point(123, 102);
            this.tBoxVNumber.Name = "tBoxVNumber";
            this.tBoxVNumber.Size = new System.Drawing.Size(217, 22);
            this.tBoxVNumber.TabIndex = 11;
            // 
            // gBoxCustomer
            // 
            this.gBoxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxCustomer.Controls.Add(this.tableLayoutPanel2);
            this.gBoxCustomer.Enabled = false;
            this.gBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxCustomer.Location = new System.Drawing.Point(9, 13);
            this.gBoxCustomer.Name = "gBoxCustomer";
            this.gBoxCustomer.Size = new System.Drawing.Size(349, 160);
            this.gBoxCustomer.TabIndex = 20;
            this.gBoxCustomer.TabStop = false;
            this.gBoxCustomer.Text = "Customer Data";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.15625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.84375F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tBoxCName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tBoxCId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tBoxPho, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(343, 139);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(114, 47);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxCName
            // 
            this.tBoxCName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxCName.Enabled = false;
            this.tBoxCName.Location = new System.Drawing.Point(123, 58);
            this.tBoxCName.Name = "tBoxCName";
            this.tBoxCName.Size = new System.Drawing.Size(217, 22);
            this.tBoxCName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(114, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(114, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxCId
            // 
            this.tBoxCId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxCId.Location = new System.Drawing.Point(123, 12);
            this.tBoxCId.Name = "tBoxCId";
            this.tBoxCId.ReadOnly = true;
            this.tBoxCId.Size = new System.Drawing.Size(217, 22);
            this.tBoxCId.TabIndex = 4;
            this.tBoxCId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxCId_KeyDown);
            // 
            // tBoxPho
            // 
            this.tBoxPho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxPho.Enabled = false;
            this.tBoxPho.Location = new System.Drawing.Point(123, 104);
            this.tBoxPho.Name = "tBoxPho";
            this.tBoxPho.Size = new System.Drawing.Size(217, 22);
            this.tBoxPho.TabIndex = 11;
            // 
            // iBtnDelete
            // 
            this.iBtnDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iBtnDelete.IconColor = System.Drawing.Color.Black;
            this.iBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDelete.Location = new System.Drawing.Point(264, 361);
            this.iBtnDelete.Name = "iBtnDelete";
            this.iBtnDelete.Size = new System.Drawing.Size(100, 37);
            this.iBtnDelete.TabIndex = 19;
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
            this.iBtnUpdate.Location = new System.Drawing.Point(158, 361);
            this.iBtnUpdate.Name = "iBtnUpdate";
            this.iBtnUpdate.Size = new System.Drawing.Size(100, 37);
            this.iBtnUpdate.TabIndex = 18;
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
            this.iBtnAdd.Location = new System.Drawing.Point(54, 361);
            this.iBtnAdd.Name = "iBtnAdd";
            this.iBtnAdd.Size = new System.Drawing.Size(100, 37);
            this.iBtnAdd.TabIndex = 17;
            this.iBtnAdd.Text = "Add";
            this.iBtnAdd.UseVisualStyleBackColor = true;
            this.iBtnAdd.Click += new System.EventHandler(this.iBtnAdd_Click);
            // 
            // ManageCustomerVehicleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCustomerVehicleControl";
            this.Size = new System.Drawing.Size(799, 598);
            this.Load += new System.EventHandler(this.ManageCustomerVehicleControl_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gBoxVehicle.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gBoxCustomer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxSearch;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iBtnCancel;
        private FontAwesome.Sharp.IconButton iBtnSave;
        private FontAwesome.Sharp.IconButton iBtnDelete;
        private FontAwesome.Sharp.IconButton iBtnUpdate;
        private FontAwesome.Sharp.IconButton iBtnAdd;
        private System.Windows.Forms.GroupBox gBoxVehicle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxVName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxVId;
        private System.Windows.Forms.TextBox tBoxVNumber;
        private System.Windows.Forms.GroupBox gBoxCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxCId;
        private System.Windows.Forms.TextBox tBoxPho;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVNumber;
    }
}
