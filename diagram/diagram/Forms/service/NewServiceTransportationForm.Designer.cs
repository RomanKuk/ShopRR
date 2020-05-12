namespace diagram.Forms.service
{
    partial class NewServiceTransportationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceComboBox = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SCComboBox = new System.Windows.Forms.ComboBox();
            this.serviceCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "код заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "сервісний центр";
            // 
            // ServiceComboBox
            // 
            this.ServiceComboBox.DataSource = this.serviceBindingSource;
            this.ServiceComboBox.DisplayMember = "Code";
            this.ServiceComboBox.FormattingEnabled = true;
            this.ServiceComboBox.Location = new System.Drawing.Point(270, 105);
            this.ServiceComboBox.Name = "ServiceComboBox";
            this.ServiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.ServiceComboBox.TabIndex = 2;
            this.ServiceComboBox.ValueMember = "Service_ID";
            this.ServiceComboBox.SelectedIndexChanged += new System.EventHandler(this.ServiceComboBox_SelectedIndexChanged);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(diagram.Service);
            // 
            // SCComboBox
            // 
            this.SCComboBox.DataSource = this.serviceCenterBindingSource;
            this.SCComboBox.DisplayMember = "Code";
            this.SCComboBox.FormattingEnabled = true;
            this.SCComboBox.Location = new System.Drawing.Point(270, 156);
            this.SCComboBox.Name = "SCComboBox";
            this.SCComboBox.Size = new System.Drawing.Size(121, 21);
            this.SCComboBox.TabIndex = 3;
            this.SCComboBox.ValueMember = "SC_ID";
            // 
            // serviceCenterBindingSource
            // 
            this.serviceCenterBindingSource.DataSource = typeof(diagram.ServiceCenter);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(220, 207);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Направити";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // NewServiceTransportationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.SCComboBox);
            this.Controls.Add(this.ServiceComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewServiceTransportationForm";
            this.Text = "NewServiceTransportationForm";
            this.Load += new System.EventHandler(this.NewServiceTransportationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceCenterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServiceComboBox;
        private System.Windows.Forms.ComboBox SCComboBox;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.BindingSource serviceCenterBindingSource;
    }
}