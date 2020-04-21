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
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provideOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insert = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.deliverIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goods = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProvideOrder = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliverIDDataGridViewTextBoxColumn,
            this.Goods,
            this.ProvideOrder,
            this.dateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(148, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(383, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(diagram.Goods);
            // 
            // provideOrderBindingSource
            // 
            this.provideOrderBindingSource.DataSource = typeof(diagram.ProvideOrder);
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSource = typeof(diagram.Delivery);
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
            // deliverIDDataGridViewTextBoxColumn
            // 
            this.deliverIDDataGridViewTextBoxColumn.DataPropertyName = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn.HeaderText = "Deliver_ID";
            this.deliverIDDataGridViewTextBoxColumn.Name = "deliverIDDataGridViewTextBoxColumn";
            this.deliverIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliverIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Goods
            // 
            this.Goods.DataPropertyName = "Goods";
            this.Goods.DataSource = this.goodsBindingSource;
            this.Goods.DisplayMember = "Model";
            this.Goods.HeaderText = "Goods";
            this.Goods.Name = "Goods";
            this.Goods.ReadOnly = true;
            this.Goods.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Goods.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Goods.ValueMember = "Good_ID";
            // 
            // ProvideOrder
            // 
            this.ProvideOrder.DataPropertyName = "ProvideOrder";
            this.ProvideOrder.DataSource = this.provideOrderBindingSource;
            this.ProvideOrder.DisplayMember = "Code";
            this.ProvideOrder.HeaderText = "ProvideOrder";
            this.ProvideOrder.Name = "ProvideOrder";
            this.ProvideOrder.ReadOnly = true;
            this.ProvideOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProvideOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProvideOrder.ValueMember = "Code";
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
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewComboBoxColumn goodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn provideOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource provideOrderBindingSource;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Goods;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProvideOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}