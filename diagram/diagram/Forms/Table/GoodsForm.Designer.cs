namespace diagram.Forms.Table
{
    partial class GoodsForm
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
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenuePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guaranteePeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodIDDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.makerIDDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.revenuePriceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.guaranteePeriodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(285, 65);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 1;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(285, 104);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(285, 156);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(diagram.Goods);
            // 
            // makersBindingSource
            // 
            this.makersBindingSource.DataSource = typeof(diagram.Makers);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(diagram.Categories);
            // 
            // goodIDDataGridViewTextBoxColumn
            // 
            this.goodIDDataGridViewTextBoxColumn.DataPropertyName = "Good_ID";
            this.goodIDDataGridViewTextBoxColumn.HeaderText = "Good_ID";
            this.goodIDDataGridViewTextBoxColumn.Name = "goodIDDataGridViewTextBoxColumn";
            this.goodIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makerIDDataGridViewTextBoxColumn
            // 
            this.makerIDDataGridViewTextBoxColumn.DataPropertyName = "Maker_ID";
            this.makerIDDataGridViewTextBoxColumn.DataSource = this.makersBindingSource;
            this.makerIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.makerIDDataGridViewTextBoxColumn.HeaderText = "Maker_ID";
            this.makerIDDataGridViewTextBoxColumn.Name = "makerIDDataGridViewTextBoxColumn";
            this.makerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.makerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.makerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.makerIDDataGridViewTextBoxColumn.ValueMember = "Maker_ID";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.DataSource = this.categoriesBindingSource;
            this.categoryIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryIDDataGridViewTextBoxColumn.ValueMember = "Category_ID";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // revenuePriceDataGridViewTextBoxColumn
            // 
            this.revenuePriceDataGridViewTextBoxColumn.DataPropertyName = "RevenuePrice";
            this.revenuePriceDataGridViewTextBoxColumn.HeaderText = "RevenuePrice";
            this.revenuePriceDataGridViewTextBoxColumn.Name = "revenuePriceDataGridViewTextBoxColumn";
            this.revenuePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // guaranteePeriodDataGridViewTextBoxColumn
            // 
            this.guaranteePeriodDataGridViewTextBoxColumn.DataPropertyName = "GuaranteePeriod";
            this.guaranteePeriodDataGridViewTextBoxColumn.HeaderText = "GuaranteePeriod";
            this.guaranteePeriodDataGridViewTextBoxColumn.Name = "guaranteePeriodDataGridViewTextBoxColumn";
            this.guaranteePeriodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn makerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource makersBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenuePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guaranteePeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
    }
}