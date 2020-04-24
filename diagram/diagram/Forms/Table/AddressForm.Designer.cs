namespace diagram.Forms.Table
{
    partial class AddressForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.minimizeBtn);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.insertBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 45);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 375);
            this.panel1.TabIndex = 11;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackgroundImage = global::diagram.Properties.Resources.minimize_icon;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Location = new System.Drawing.Point(315, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(38, 38);
            this.minimizeBtn.TabIndex = 12;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::diagram.Properties.Resources.close_icon;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(359, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 38);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = global::diagram.Properties.Resources.delete;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(221, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(38, 38);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.Delete_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = global::diagram.Properties.Resources.edit;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(177, 3);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(38, 38);
            this.editBtn.TabIndex = 9;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.Edit_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.BackgroundImage = global::diagram.Properties.Resources.add;
            this.insertBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertBtn.FlatAppearance.BorderSize = 0;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Location = new System.Drawing.Point(133, 4);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(38, 38);
            this.insertBtn.TabIndex = 8;
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.Insert_Click);
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.DataSource = this.cityBindingSource;
            this.City.DisplayMember = "Name";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.City.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.City.ValueMember = "City_ID";
            this.City.Width = 54;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(diagram.City);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 68;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(diagram.Address);
            // 
            // AddressForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn cityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}