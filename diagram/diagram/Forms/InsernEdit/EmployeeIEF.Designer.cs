namespace diagram.Forms.InsernEdit
{
    partial class EmployeeIEF
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
            this.save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.professionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.Location = new System.Drawing.Point(352, 355);
            this.save.Name = "saveBtn";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "saveBtn";
            this.save.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.textBox1.Location = new System.Drawing.Point(327, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(diagram.Employee);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.textBox2.Location = new System.Drawing.Point(327, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.textBox3.Location = new System.Drawing.Point(337, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "Address", true));
            this.comboBox1.DataSource = this.addressBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(316, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Address_ID";
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(diagram.Address);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "Profession_ID", true));
            this.comboBox2.DataSource = this.professionBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(316, 252);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "Profession_ID";
            // 
            // professionBindingSource
            // 
            this.professionBindingSource.DataSource = typeof(diagram.Profession);
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "Shop_ID", true));
            this.comboBox3.DataSource = this.shopsBindingSource;
            this.comboBox3.DisplayMember = "Code";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(327, 315);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.ValueMember = "Shop_ID";
            // 
            // shopsBindingSource
            // 
            this.shopsBindingSource.DataSource = typeof(diagram.Shops);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "HiringDate", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(316, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // EmployeeIEF
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmployeeIEF";
            this.Text = "EmployeeIEF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeIEF_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource professionBindingSource;
        private System.Windows.Forms.BindingSource shopsBindingSource;
    }
}