namespace diagram.Forms.Table
{
    partial class ServiceTransportationForm
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
            this.serviceTransportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTransportationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTransportationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceTransportationIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.sCIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceTransportationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(272, 38);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(272, 77);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(272, 127);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // serviceTransportationBindingSource
            // 
            this.serviceTransportationBindingSource.DataSource = typeof(diagram.ServiceTransportation);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(diagram.Service);
            // 
            // serviceCenterBindingSource
            // 
            this.serviceCenterBindingSource.DataSource = typeof(diagram.ServiceCenter);
            // 
            // serviceTransportationIDDataGridViewTextBoxColumn
            // 
            this.serviceTransportationIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceTransportation_ID";
            this.serviceTransportationIDDataGridViewTextBoxColumn.HeaderText = "ServiceTransportation_ID";
            this.serviceTransportationIDDataGridViewTextBoxColumn.Name = "serviceTransportationIDDataGridViewTextBoxColumn";
            this.serviceTransportationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceTransportationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.DataSource = this.serviceBindingSource;
            this.serviceIDDataGridViewTextBoxColumn.DisplayMember = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.serviceIDDataGridViewTextBoxColumn.ValueMember = "Service_ID";
            // 
            // sCIDDataGridViewTextBoxColumn
            // 
            this.sCIDDataGridViewTextBoxColumn.DataPropertyName = "SC_ID";
            this.sCIDDataGridViewTextBoxColumn.DataSource = this.serviceCenterBindingSource;
            this.sCIDDataGridViewTextBoxColumn.DisplayMember = "SC_ID";
            this.sCIDDataGridViewTextBoxColumn.HeaderText = "SC_ID";
            this.sCIDDataGridViewTextBoxColumn.Name = "sCIDDataGridViewTextBoxColumn";
            this.sCIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sCIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sCIDDataGridViewTextBoxColumn.ValueMember = "SC_ID";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ServiceTransportationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ServiceTransportationForm";
            this.Text = "ServiceTransportationForm";
            this.Load += new System.EventHandler(this.ServiceTransportationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTransportationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.BindingSource serviceTransportationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTransportationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn sCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceCenterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}