namespace diagram.Forms.Table
{
    partial class TransportationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.transportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsShopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSfromIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gSinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportationIDDataGridViewTextBoxColumn,
            this.gSfromIDDataGridViewTextBoxColumn,
            this.gSinIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transportationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(275, 28);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(275, 78);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(275, 127);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // transportationBindingSource
            // 
            this.transportationBindingSource.DataSource = typeof(diagram.Transportation);
            // 
            // goodsShopsBindingSource
            // 
            this.goodsShopsBindingSource.DataSource = typeof(diagram.GoodsShops);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // transportationIDDataGridViewTextBoxColumn
            // 
            this.transportationIDDataGridViewTextBoxColumn.DataPropertyName = "Transportation_ID";
            this.transportationIDDataGridViewTextBoxColumn.HeaderText = "Transportation_ID";
            this.transportationIDDataGridViewTextBoxColumn.Name = "transportationIDDataGridViewTextBoxColumn";
            this.transportationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.transportationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // gSfromIDDataGridViewTextBoxColumn
            // 
            this.gSfromIDDataGridViewTextBoxColumn.DataPropertyName = "GS_from_ID";
            this.gSfromIDDataGridViewTextBoxColumn.DataSource = this.goodsShopsBindingSource;
            this.gSfromIDDataGridViewTextBoxColumn.DisplayMember = "GoodsShops_ID";
            this.gSfromIDDataGridViewTextBoxColumn.HeaderText = "GS_from_ID";
            this.gSfromIDDataGridViewTextBoxColumn.Name = "gSfromIDDataGridViewTextBoxColumn";
            this.gSfromIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSfromIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gSfromIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gSfromIDDataGridViewTextBoxColumn.ValueMember = "GoodsShops_ID";
            // 
            // gSinIDDataGridViewTextBoxColumn
            // 
            this.gSinIDDataGridViewTextBoxColumn.DataPropertyName = "GS_in_ID";
            this.gSinIDDataGridViewTextBoxColumn.DataSource = this.goodsShopsBindingSource;
            this.gSinIDDataGridViewTextBoxColumn.DisplayMember = "GoodsShops_ID";
            this.gSinIDDataGridViewTextBoxColumn.HeaderText = "GS_in_ID";
            this.gSinIDDataGridViewTextBoxColumn.Name = "gSinIDDataGridViewTextBoxColumn";
            this.gSinIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSinIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gSinIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gSinIDDataGridViewTextBoxColumn.ValueMember = "GoodsShops_ID";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource;
            this.employeeIDDataGridViewTextBoxColumn.DisplayMember = "LastName";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeIDDataGridViewTextBoxColumn.ValueMember = "Employee_ID";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TransportationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TransportationForm";
            this.Text = "TransportationForm";
            this.Load += new System.EventHandler(this.TransportationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gSfromIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsShopsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn gSinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transportationBindingSource;
    }
}