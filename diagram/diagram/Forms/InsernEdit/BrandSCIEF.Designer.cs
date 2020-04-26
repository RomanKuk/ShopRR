namespace diagram.Forms.InsernEdit
{
    partial class BrandSCIEF
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.serviceCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandSCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandSCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.brandSCBindingSource, "SC_ID", true));
            this.comboBox1.DataSource = this.serviceCenterBindingSource;
            this.comboBox1.DisplayMember = "Code";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "SC_ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.brandSCBindingSource, "Brand_ID", true));
            this.comboBox2.DataSource = this.brandBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(233, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Brand_ID";
            // 
            // save
            // 
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.Location = new System.Drawing.Point(254, 174);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // serviceCenterBindingSource
            // 
            this.serviceCenterBindingSource.DataSource = typeof(diagram.ServiceCenter);
            // 
            // brandSCBindingSource
            // 
            this.brandSCBindingSource.DataSource = typeof(diagram.BrandSC);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(diagram.Brand);
            // 
            // BrandSCIEF
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BrandSCIEF";
            this.Text = "BrandSCIEF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BrandSCIEF_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandSCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource brandSCBindingSource;
        private System.Windows.Forms.BindingSource serviceCenterBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.Button save;
    }
}