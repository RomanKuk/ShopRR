namespace diagram.Forms.InsernEdit
{
    partial class TransportationIEF
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.gsFromCB = new System.Windows.Forms.ComboBox();
            this.transportationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsShopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gsInCB = new System.Windows.Forms.ComboBox();
            this.goodsShopsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeCB = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countNUD = new System.Windows.Forms.NumericUpDown();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 45);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(355, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 45);
            this.panel4.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::diagram.Properties.Resources.close_icon;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 38);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 45);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6);
            this.label1.Size = new System.Drawing.Size(180, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transportations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.gsFromCB);
            this.panel1.Controls.Add(this.gsInCB);
            this.panel1.Controls.Add(this.employeeCB);
            this.panel1.Controls.Add(this.countNUD);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 420);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(94, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(94, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(78, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "In Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "From Code:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveBtn.Image = global::diagram.Properties.Resources.save_icon;
            this.saveBtn.Location = new System.Drawing.Point(165, 320);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(66, 77);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // gsFromCB
            // 
            this.gsFromCB.BackColor = System.Drawing.Color.Cornsilk;
            this.gsFromCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transportationBindingSource, "GS_from_ID", true));
            this.gsFromCB.DataSource = this.goodsShopsBindingSource;
            this.gsFromCB.DisplayMember = "Code";
            this.gsFromCB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsFromCB.FormattingEnabled = true;
            this.gsFromCB.Location = new System.Drawing.Point(199, 94);
            this.gsFromCB.Name = "gsFromCB";
            this.gsFromCB.Size = new System.Drawing.Size(170, 28);
            this.gsFromCB.TabIndex = 1;
            this.gsFromCB.ValueMember = "GoodsShops_ID";
            // 
            // transportationBindingSource
            // 
            this.transportationBindingSource.DataSource = typeof(diagram.Transportation);
            // 
            // goodsShopsBindingSource
            // 
            this.goodsShopsBindingSource.DataSource = typeof(diagram.GoodsShops);
            // 
            // gsInCB
            // 
            this.gsInCB.BackColor = System.Drawing.Color.Cornsilk;
            this.gsInCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transportationBindingSource, "GS_in_ID", true));
            this.gsInCB.DataSource = this.goodsShopsBindingSource1;
            this.gsInCB.DisplayMember = "Code";
            this.gsInCB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gsInCB.FormattingEnabled = true;
            this.gsInCB.Location = new System.Drawing.Point(199, 136);
            this.gsInCB.Name = "gsInCB";
            this.gsInCB.Size = new System.Drawing.Size(170, 28);
            this.gsInCB.TabIndex = 2;
            this.gsInCB.ValueMember = "GoodsShops_ID";
            // 
            // goodsShopsBindingSource1
            // 
            this.goodsShopsBindingSource1.DataSource = typeof(diagram.GoodsShops);
            // 
            // employeeCB
            // 
            this.employeeCB.BackColor = System.Drawing.Color.Cornsilk;
            this.employeeCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transportationBindingSource, "Employee_ID", true));
            this.employeeCB.DataSource = this.employeeBindingSource;
            this.employeeCB.DisplayMember = "LastName";
            this.employeeCB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCB.FormattingEnabled = true;
            this.employeeCB.Location = new System.Drawing.Point(199, 178);
            this.employeeCB.Name = "employeeCB";
            this.employeeCB.Size = new System.Drawing.Size(170, 28);
            this.employeeCB.TabIndex = 3;
            this.employeeCB.ValueMember = "Employee_ID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // countNUD
            // 
            this.countNUD.BackColor = System.Drawing.Color.Cornsilk;
            this.countNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transportationBindingSource, "Count", true));
            this.countNUD.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countNUD.Location = new System.Drawing.Point(199, 262);
            this.countNUD.Name = "countNUD";
            this.countNUD.Size = new System.Drawing.Size(170, 27);
            this.countNUD.TabIndex = 5;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Cornsilk;
            this.datePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transportationBindingSource, "Date", true));
            this.datePicker.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(199, 222);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(170, 27);
            this.datePicker.TabIndex = 4;
            // 
            // TransportationIEF
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransportationIEF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportationIEF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransportationIEF_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsShopsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox gsFromCB;
        private System.Windows.Forms.ComboBox gsInCB;
        private System.Windows.Forms.ComboBox employeeCB;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown countNUD;
        private System.Windows.Forms.BindingSource transportationBindingSource;
        private System.Windows.Forms.BindingSource goodsShopsBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource goodsShopsBindingSource1;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}