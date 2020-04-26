namespace diagram.Forms.Table
{
    partial class RepairForm
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
            this.serviceTransportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.insertBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.backToHomeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.repairIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTransportation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTransportationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairIDDataGridViewTextBoxColumn,
            this.ServiceTransportation,
            this.commentDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.repairBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // serviceTransportationBindingSource
            // 
            this.serviceTransportationBindingSource.DataSource = typeof(diagram.ServiceTransportation);
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataSource = typeof(diagram.Repair);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 45);
            this.panel2.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.insertBtn);
            this.panel5.Controls.Add(this.editBtn);
            this.panel5.Controls.Add(this.deleteBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(360, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 45);
            this.panel5.TabIndex = 1;
            // 
            // insertBtn
            // 
            this.insertBtn.BackgroundImage = global::diagram.Properties.Resources.add;
            this.insertBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.insertBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.insertBtn.FlatAppearance.BorderSize = 0;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Location = new System.Drawing.Point(1, 4);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(38, 38);
            this.insertBtn.TabIndex = 8;
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.Insert_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = global::diagram.Properties.Resources.edit;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(40, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(38, 38);
            this.editBtn.TabIndex = 9;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.Edit_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = global::diagram.Properties.Resources.delete;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(79, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(38, 38);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.Delete_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Controls.Add(this.minimizeBtn);
            this.panel4.Controls.Add(this.backToHomeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(682, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 45);
            this.panel4.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::diagram.Properties.Resources.close_icon;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(79, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 38);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackgroundImage = global::diagram.Properties.Resources.minimize_icon;
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Location = new System.Drawing.Point(40, 4);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(38, 38);
            this.minimizeBtn.TabIndex = 12;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // backToHomeBtn
            // 
            this.backToHomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backToHomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backToHomeBtn.FlatAppearance.BorderSize = 0;
            this.backToHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToHomeBtn.Image = global::diagram.Properties.Resources.home_icon;
            this.backToHomeBtn.Location = new System.Drawing.Point(1, 4);
            this.backToHomeBtn.Name = "backToHomeBtn";
            this.backToHomeBtn.Size = new System.Drawing.Size(38, 38);
            this.backToHomeBtn.TabIndex = 13;
            this.backToHomeBtn.UseVisualStyleBackColor = true;
            this.backToHomeBtn.Click += new System.EventHandler(this.backToHomeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.formTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 45);
            this.panel3.TabIndex = 1;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTitle.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.Purple;
            this.formTitle.Location = new System.Drawing.Point(0, 0);
            this.formTitle.Margin = new System.Windows.Forms.Padding(3);
            this.formTitle.Name = "formTitle";
            this.formTitle.Padding = new System.Windows.Forms.Padding(6);
            this.formTitle.Size = new System.Drawing.Size(88, 42);
            this.formTitle.TabIndex = 4;
            this.formTitle.Text = "Repair";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 375);
            this.panel1.TabIndex = 11;
            // 
            // repairIDDataGridViewTextBoxColumn
            // 
            this.repairIDDataGridViewTextBoxColumn.DataPropertyName = "Repair_ID";
            this.repairIDDataGridViewTextBoxColumn.HeaderText = "Repair_ID";
            this.repairIDDataGridViewTextBoxColumn.Name = "repairIDDataGridViewTextBoxColumn";
            this.repairIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.repairIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ServiceTransportation
            // 
            this.ServiceTransportation.DataPropertyName = "ServiceTransportation_ID";
            this.ServiceTransportation.DataSource = this.serviceTransportationBindingSource;
            this.ServiceTransportation.DisplayMember = "Code";
            this.ServiceTransportation.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ServiceTransportation.HeaderText = "ServiceTransportation Code";
            this.ServiceTransportation.Name = "ServiceTransportation";
            this.ServiceTransportation.ReadOnly = true;
            this.ServiceTransportation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceTransportation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ServiceTransportation.ValueMember = "ServiceTransportation_ID";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RepairForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepairForm";
            this.Text = "RepairForm";
            this.Load += new System.EventHandler(this.RepairForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTransportationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button backToHomeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;

        private System.Windows.Forms.BindingSource serviceTransportationBindingSource;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ServiceTransportation;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}