namespace diagram.Forms.expeditor
{
    partial class ExpeditorForm
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
            this.newProvideOrder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DeliveryTabPage = new System.Windows.Forms.TabPage();
            this.ShipmentTabPage = new System.Windows.Forms.TabPage();
            this.newShipment = new System.Windows.Forms.Button();
            this.DeliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.ShipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.DeliveryTabPage.SuspendLayout();
            this.ShipmentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // newProvideOrder
            // 
            this.newProvideOrder.Location = new System.Drawing.Point(12, 415);
            this.newProvideOrder.Name = "newProvideOrder";
            this.newProvideOrder.Size = new System.Drawing.Size(169, 23);
            this.newProvideOrder.TabIndex = 0;
            this.newProvideOrder.Text = "Зробити замовлення";
            this.newProvideOrder.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DeliveryTabPage);
            this.tabControl1.Controls.Add(this.ShipmentTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 388);
            this.tabControl1.TabIndex = 1;
            // 
            // DeliveryTabPage
            // 
            this.DeliveryTabPage.Controls.Add(this.DeliveryDataGridView);
            this.DeliveryTabPage.Location = new System.Drawing.Point(4, 22);
            this.DeliveryTabPage.Name = "DeliveryTabPage";
            this.DeliveryTabPage.Size = new System.Drawing.Size(768, 362);
            this.DeliveryTabPage.TabIndex = 0;
            this.DeliveryTabPage.Text = "Доставки";
            this.DeliveryTabPage.UseVisualStyleBackColor = true;
            // 
            // ShipmentTabPage
            // 
            this.ShipmentTabPage.Controls.Add(this.ShipmentDataGridView);
            this.ShipmentTabPage.Location = new System.Drawing.Point(4, 22);
            this.ShipmentTabPage.Name = "ShipmentTabPage";
            this.ShipmentTabPage.Size = new System.Drawing.Size(768, 362);
            this.ShipmentTabPage.TabIndex = 1;
            this.ShipmentTabPage.Text = "Відвантаження";
            this.ShipmentTabPage.UseVisualStyleBackColor = true;
            // 
            // newShipment
            // 
            this.newShipment.Location = new System.Drawing.Point(231, 415);
            this.newShipment.Name = "newShipment";
            this.newShipment.Size = new System.Drawing.Size(162, 23);
            this.newShipment.TabIndex = 2;
            this.newShipment.Text = "Прийом товару";
            this.newShipment.UseVisualStyleBackColor = true;
            // 
            // DeliveryDataGridView
            // 
            this.DeliveryDataGridView.AllowUserToAddRows = false;
            this.DeliveryDataGridView.AllowUserToDeleteRows = false;
            this.DeliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryDataGridView.Location = new System.Drawing.Point(34, 35);
            this.DeliveryDataGridView.Name = "DeliveryDataGridView";
            this.DeliveryDataGridView.ReadOnly = true;
            this.DeliveryDataGridView.Size = new System.Drawing.Size(283, 207);
            this.DeliveryDataGridView.TabIndex = 0;
            // 
            // ShipmentDataGridView
            // 
            this.ShipmentDataGridView.AllowUserToAddRows = false;
            this.ShipmentDataGridView.AllowUserToDeleteRows = false;
            this.ShipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentDataGridView.Location = new System.Drawing.Point(18, 15);
            this.ShipmentDataGridView.Name = "ShipmentDataGridView";
            this.ShipmentDataGridView.ReadOnly = true;
            this.ShipmentDataGridView.Size = new System.Drawing.Size(582, 253);
            this.ShipmentDataGridView.TabIndex = 0;
            // 
            // ExpeditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newShipment);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.newProvideOrder);
            this.Name = "ExpeditorForm";
            this.Text = "ExpeditorForm";
            this.tabControl1.ResumeLayout(false);
            this.DeliveryTabPage.ResumeLayout(false);
            this.ShipmentTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newProvideOrder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DeliveryTabPage;
        private System.Windows.Forms.TabPage ShipmentTabPage;
        private System.Windows.Forms.Button newShipment;
        private System.Windows.Forms.DataGridView DeliveryDataGridView;
        private System.Windows.Forms.DataGridView ShipmentDataGridView;
    }
}