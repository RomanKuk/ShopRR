namespace diagram.Forms.Users.Seller.Transportations
{
    partial class ManagerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.transportationTabPage = new System.Windows.Forms.TabPage();
            this.statisticsTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.transportationTabPage);
            this.tabControl1.Controls.Add(this.statisticsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // transportationTabPage
            // 
            this.transportationTabPage.Location = new System.Drawing.Point(4, 22);
            this.transportationTabPage.Name = "transportationTabPage";
            this.transportationTabPage.Size = new System.Drawing.Size(768, 400);
            this.transportationTabPage.TabIndex = 0;
            this.transportationTabPage.Text = "Перевезення";
            this.transportationTabPage.UseVisualStyleBackColor = true;
            // 
            // statisticsTabPage
            // 
            this.statisticsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statisticsTabPage.Name = "statisticsTabPage";
            this.statisticsTabPage.Size = new System.Drawing.Size(768, 400);
            this.statisticsTabPage.TabIndex = 1;
            this.statisticsTabPage.Text = "Статистика";
            this.statisticsTabPage.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage transportationTabPage;
        private System.Windows.Forms.TabPage statisticsTabPage;
    }
}