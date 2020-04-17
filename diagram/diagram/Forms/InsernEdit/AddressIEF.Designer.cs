namespace diagram.Forms.InsernEdit
{
    partial class AddressIEF
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
            this.addressNameTB = new System.Windows.Forms.TextBox();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressNameTB
            // 
            this.addressNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "Name", true));
            this.addressNameTB.Location = new System.Drawing.Point(178, 65);
            this.addressNameTB.Name = "addressNameTB";
            this.addressNameTB.Size = new System.Drawing.Size(100, 20);
            this.addressNameTB.TabIndex = 0;
            // 
            // cityCB
            // 
            this.cityCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.addressBindingSource, "City_ID", true));
            this.cityCB.DataSource = this.cityBindingSource;
            this.cityCB.DisplayMember = "Name";
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(172, 147);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(121, 21);
            this.cityCB.TabIndex = 1;
            this.cityCB.ValueMember = "City_ID";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(diagram.City);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(diagram.Address);
            // 
            // save
            // 
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.Location = new System.Drawing.Point(263, 244);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // AddressEIF
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.addressNameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddressEIF";
            this.Text = "AddressEIF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddressEIF_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressNameTB;
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Button save;
    }
}