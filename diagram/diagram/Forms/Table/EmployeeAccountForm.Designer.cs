namespace diagram.Forms.Table
{
    partial class EmployeeAccountForm
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
            this.employeeAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeAccountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAccountBindingSource)).BeginInit();
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
            this.employeeAccountIDDataGridViewTextBoxColumn,
            this.loginNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeAccountBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(282, 46);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(282, 95);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(282, 139);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // employeeAccountBindingSource
            // 
            this.employeeAccountBindingSource.DataSource = typeof(diagram.EmployeeAccount);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // employeeAccountIDDataGridViewTextBoxColumn
            // 
            this.employeeAccountIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeAccount_ID";
            this.employeeAccountIDDataGridViewTextBoxColumn.HeaderText = "EmployeeAccount_ID";
            this.employeeAccountIDDataGridViewTextBoxColumn.Name = "employeeAccountIDDataGridViewTextBoxColumn";
            this.employeeAccountIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeAccountIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // loginNameDataGridViewTextBoxColumn
            // 
            this.loginNameDataGridViewTextBoxColumn.DataPropertyName = "LoginName";
            this.loginNameDataGridViewTextBoxColumn.HeaderText = "LoginName";
            this.loginNameDataGridViewTextBoxColumn.Name = "loginNameDataGridViewTextBoxColumn";
            this.loginNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
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
            // EmployeeAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeAccountForm";
            this.Text = "EmployeeAccountForm";
            this.Load += new System.EventHandler(this.EmployeeAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAccountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource employeeAccountBindingSource;
    }
}