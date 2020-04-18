namespace diagram.Forms.Table
{
    partial class DeliveryForm
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
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provideOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.provideOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliverIDDataGridViewTextBoxColumn,
            this.goodIDDataGridViewTextBoxColumn,
            this.provideOrderIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(148, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(537, 146);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(537, 175);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(537, 204);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSource = typeof(diagram.Delivery);
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(diagram.Goods);
            // 
            // provideOrderBindingSource
            // 
            this.provideOrderBindingSource.DataSource = typeof(diagram.ProvideOrder);
            // 
            // deliverIDDataGridViewTextBoxColumn
            // 
            this.deliverIDDataGridViewTextBoxColumn.DataPropertyName = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn.HeaderText = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn.Name = "deliverIDDataGridViewTextBoxColumn";
            this.deliverIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // goodIDDataGridViewTextBoxColumn
            // 
            this.goodIDDataGridViewTextBoxColumn.DataPropertyName = "Good_ID";
            this.goodIDDataGridViewTextBoxColumn.DataSource = this.goodsBindingSource;
            this.goodIDDataGridViewTextBoxColumn.DisplayMember = "Model";
            this.goodIDDataGridViewTextBoxColumn.HeaderText = "Good_ID";
            this.goodIDDataGridViewTextBoxColumn.Name = "goodIDDataGridViewTextBoxColumn";
            this.goodIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.goodIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.goodIDDataGridViewTextBoxColumn.ValueMember = "Good_ID";
            // 
            // provideOrderIDDataGridViewTextBoxColumn
            // 
            this.provideOrderIDDataGridViewTextBoxColumn.DataPropertyName = "ProvideOrder_ID";
            this.provideOrderIDDataGridViewTextBoxColumn.DataSource = this.provideOrderBindingSource;
            this.provideOrderIDDataGridViewTextBoxColumn.DisplayMember = "ProvideOrder_ID";
            this.provideOrderIDDataGridViewTextBoxColumn.HeaderText = "ProvideOrder_ID";
            this.provideOrderIDDataGridViewTextBoxColumn.Name = "provideOrderIDDataGridViewTextBoxColumn";
            this.provideOrderIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.provideOrderIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.provideOrderIDDataGridViewTextBoxColumn.ValueMember = "ProvideOrder_ID";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn goodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn provideOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource provideOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
    }
}