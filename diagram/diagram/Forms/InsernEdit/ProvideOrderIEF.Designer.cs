namespace diagram.Forms.InsernEdit
{
    partial class ProvideOrderIEF
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.providerNameCB = new System.Windows.Forms.ComboBox();
            this.provideOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTB = new System.Windows.Forms.TextBox();
            this.totalCostNUD = new System.Windows.Forms.NumericUpDown();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostNUD)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(430, 45);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.closeBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(385, 0);
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
            this.panel3.Size = new System.Drawing.Size(430, 45);
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
            this.label1.Size = new System.Drawing.Size(393, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Загальне замовлення (партії)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.providerNameCB);
            this.panel1.Controls.Add(this.codeTB);
            this.panel1.Controls.Add(this.totalCostNUD);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 420);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Постачальник:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Загальна вартість:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(127, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Код:";
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
            this.saveBtn.Location = new System.Drawing.Point(134, 295);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 77);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // providerNameCB
            // 
            this.providerNameCB.BackColor = System.Drawing.Color.Cornsilk;
            this.providerNameCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.provideOrderBindingSource, "Provide_ID", true));
            this.providerNameCB.DataSource = this.provideBindingSource;
            this.providerNameCB.DisplayMember = "Name";
            this.providerNameCB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerNameCB.FormattingEnabled = true;
            this.providerNameCB.Location = new System.Drawing.Point(213, 130);
            this.providerNameCB.Name = "providerNameCB";
            this.providerNameCB.Size = new System.Drawing.Size(170, 28);
            this.providerNameCB.TabIndex = 3;
            this.providerNameCB.ValueMember = "Provide_ID";
            // 
            // provideOrderBindingSource
            // 
            this.provideOrderBindingSource.DataSource = typeof(diagram.ProvideOrder);
            // 
            // provideBindingSource
            // 
            this.provideBindingSource.DataSource = typeof(diagram.Provide);
            // 
            // codeTB
            // 
            this.codeTB.BackColor = System.Drawing.Color.Cornsilk;
            this.codeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provideOrderBindingSource, "Code", true));
            this.codeTB.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTB.Location = new System.Drawing.Point(213, 89);
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(170, 27);
            this.codeTB.TabIndex = 4;
            // 
            // totalCostNUD
            // 
            this.totalCostNUD.BackColor = System.Drawing.Color.Cornsilk;
            this.totalCostNUD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.provideOrderBindingSource, "TotalCost", true));
            this.totalCostNUD.DecimalPlaces = 2;
            this.totalCostNUD.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostNUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.totalCostNUD.Location = new System.Drawing.Point(213, 222);
            this.totalCostNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.totalCostNUD.Name = "totalCostNUD";
            this.totalCostNUD.Size = new System.Drawing.Size(170, 27);
            this.totalCostNUD.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Cornsilk;
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.Cornsilk;
            this.datePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.provideOrderBindingSource, "Date", true));
            this.datePicker.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(213, 177);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(170, 27);
            this.datePicker.TabIndex = 1;
            // 
            // ProvideOrderIEF
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(74)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(430, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProvideOrderIEF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProvideOrderIEF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProvideOrderIEF_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provideOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provideBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.NumericUpDown totalCostNUD;
        private System.Windows.Forms.BindingSource provideOrderBindingSource;
        private System.Windows.Forms.ComboBox providerNameCB;
        private System.Windows.Forms.BindingSource provideBindingSource;
        private System.Windows.Forms.TextBox codeTB;

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
    }
}