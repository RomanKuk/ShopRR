namespace diagram.Forms.Table
{
    partial class EmployeeForm
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hiringDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.professionIDDataGridViewTextBoxColumn,
            this.hiringDateDataGridViewTextBoxColumn,
            this.shopIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(286, 33);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(286, 80);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(286, 127);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(diagram.Address);
            // 
            // professionBindingSource
            // 
            this.professionBindingSource.DataSource = typeof(diagram.Profession);
            // 
            // shopsBindingSource
            // 
            this.shopsBindingSource.DataSource = typeof(diagram.Shops);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.DataSource = this.addressBindingSource;
            this.addressDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.addressDataGridViewTextBoxColumn.ValueMember = "Address_ID";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // professionIDDataGridViewTextBoxColumn
            // 
            this.professionIDDataGridViewTextBoxColumn.DataPropertyName = "Profession_ID";
            this.professionIDDataGridViewTextBoxColumn.DataSource = this.professionBindingSource;
            this.professionIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.professionIDDataGridViewTextBoxColumn.HeaderText = "Profession_ID";
            this.professionIDDataGridViewTextBoxColumn.Name = "professionIDDataGridViewTextBoxColumn";
            this.professionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.professionIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.professionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.professionIDDataGridViewTextBoxColumn.ValueMember = "Profession_ID";
            // 
            // hiringDateDataGridViewTextBoxColumn
            // 
            this.hiringDateDataGridViewTextBoxColumn.DataPropertyName = "HiringDate";
            this.hiringDateDataGridViewTextBoxColumn.HeaderText = "HiringDate";
            this.hiringDateDataGridViewTextBoxColumn.Name = "hiringDateDataGridViewTextBoxColumn";
            this.hiringDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shopIDDataGridViewTextBoxColumn
            // 
            this.shopIDDataGridViewTextBoxColumn.DataPropertyName = "Shop_ID";
            this.shopIDDataGridViewTextBoxColumn.DataSource = this.shopsBindingSource;
            this.shopIDDataGridViewTextBoxColumn.DisplayMember = "Address";
            this.shopIDDataGridViewTextBoxColumn.HeaderText = "Shop_ID";
            this.shopIDDataGridViewTextBoxColumn.Name = "shopIDDataGridViewTextBoxColumn";
            this.shopIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shopIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shopIDDataGridViewTextBoxColumn.ValueMember = "Shop_ID";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn professionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiringDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shopIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shopsBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}