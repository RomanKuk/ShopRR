namespace diagram.Forms.Table
{
    partial class ServiceCenterForm
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
            this.serviceCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCIDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceCenterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(281, 12);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(281, 70);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(281, 127);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // serviceCenterBindingSource
            // 
            this.serviceCenterBindingSource.DataSource = typeof(diagram.ServiceCenter);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(diagram.Address);
            // 
            // sCIDDataGridViewTextBoxColumn
            // 
            this.sCIDDataGridViewTextBoxColumn.DataPropertyName = "SC_ID";
            this.sCIDDataGridViewTextBoxColumn.HeaderText = "SC_ID";
            this.sCIDDataGridViewTextBoxColumn.Name = "sCIDDataGridViewTextBoxColumn";
            this.sCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCIDDataGridViewTextBoxColumn.Visible = false;
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
            // ServiceCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ServiceCenterForm";
            this.Text = "ServiceCenterForm";
            this.Load += new System.EventHandler(this.ServiceCenterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource serviceCenterBindingSource;
    }
}