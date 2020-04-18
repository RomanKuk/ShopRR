namespace diagram.Forms.Table
{
    partial class ServiceForm
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
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breakageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.basketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.breakageIDDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn,
            this.basketIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(286, 12);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(286, 75);
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
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(diagram.Service);
            // 
            // breakageBindingSource
            // 
            this.breakageBindingSource.DataSource = typeof(diagram.Breakage);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(diagram.Status);
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataSource = typeof(diagram.Basket);
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "Service_ID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // breakageIDDataGridViewTextBoxColumn
            // 
            this.breakageIDDataGridViewTextBoxColumn.DataPropertyName = "Breakage_ID";
            this.breakageIDDataGridViewTextBoxColumn.DataSource = this.breakageBindingSource;
            this.breakageIDDataGridViewTextBoxColumn.DisplayMember = "Breakege";
            this.breakageIDDataGridViewTextBoxColumn.HeaderText = "Breakage_ID";
            this.breakageIDDataGridViewTextBoxColumn.Name = "breakageIDDataGridViewTextBoxColumn";
            this.breakageIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.breakageIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.breakageIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.breakageIDDataGridViewTextBoxColumn.ValueMember = "Breakage_ID";
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "Status_ID";
            this.statusIDDataGridViewTextBoxColumn.DataSource = this.statusBindingSource;
            this.statusIDDataGridViewTextBoxColumn.DisplayMember = "Status1";
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "Status_ID";
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            this.statusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusIDDataGridViewTextBoxColumn.ValueMember = "Status_ID";
            // 
            // basketIDDataGridViewTextBoxColumn
            // 
            this.basketIDDataGridViewTextBoxColumn.DataPropertyName = "Basket_ID";
            this.basketIDDataGridViewTextBoxColumn.DataSource = this.basketBindingSource;
            this.basketIDDataGridViewTextBoxColumn.DisplayMember = "Basket_ID";
            this.basketIDDataGridViewTextBoxColumn.HeaderText = "Basket_ID";
            this.basketIDDataGridViewTextBoxColumn.Name = "basketIDDataGridViewTextBoxColumn";
            this.basketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.basketIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.basketIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.basketIDDataGridViewTextBoxColumn.ValueMember = "Basket_ID";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn breakageIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource breakageBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn basketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource basketBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource serviceBindingSource;
    }
}