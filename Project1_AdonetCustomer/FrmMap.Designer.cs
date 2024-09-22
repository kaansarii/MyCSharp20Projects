namespace Project1_AdonetCustomer
{
    partial class FrmMap
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
            this.BtnOpenCityForm = new System.Windows.Forms.Button();
            this.BtnOpenCustomerForm = new System.Windows.Forms.Button();
            this.BtnExis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOpenCityForm
            // 
            this.BtnOpenCityForm.BackColor = System.Drawing.Color.Olive;
            this.BtnOpenCityForm.Location = new System.Drawing.Point(12, 12);
            this.BtnOpenCityForm.Name = "BtnOpenCityForm";
            this.BtnOpenCityForm.Size = new System.Drawing.Size(267, 120);
            this.BtnOpenCityForm.TabIndex = 0;
            this.BtnOpenCityForm.Text = "Şehir İşlemleri";
            this.BtnOpenCityForm.UseVisualStyleBackColor = false;
            this.BtnOpenCityForm.Click += new System.EventHandler(this.BtnOpenCityForm_Click);
            // 
            // BtnOpenCustomerForm
            // 
            this.BtnOpenCustomerForm.BackColor = System.Drawing.Color.Tan;
            this.BtnOpenCustomerForm.Location = new System.Drawing.Point(12, 153);
            this.BtnOpenCustomerForm.Name = "BtnOpenCustomerForm";
            this.BtnOpenCustomerForm.Size = new System.Drawing.Size(267, 120);
            this.BtnOpenCustomerForm.TabIndex = 1;
            this.BtnOpenCustomerForm.Text = "Müşteri İşlemleri";
            this.BtnOpenCustomerForm.UseVisualStyleBackColor = false;
            this.BtnOpenCustomerForm.Click += new System.EventHandler(this.BtnOpenCustomerForm_Click);
            // 
            // BtnExis
            // 
            this.BtnExis.BackColor = System.Drawing.Color.Crimson;
            this.BtnExis.Location = new System.Drawing.Point(12, 290);
            this.BtnExis.Name = "BtnExis";
            this.BtnExis.Size = new System.Drawing.Size(267, 120);
            this.BtnExis.TabIndex = 2;
            this.BtnExis.Text = "Çıkış";
            this.BtnExis.UseVisualStyleBackColor = false;
            this.BtnExis.Click += new System.EventHandler(this.BtnExis_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(296, 439);
            this.Controls.Add(this.BtnExis);
            this.Controls.Add(this.BtnOpenCustomerForm);
            this.Controls.Add(this.BtnOpenCityForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenCityForm;
        private System.Windows.Forms.Button BtnOpenCustomerForm;
        private System.Windows.Forms.Button BtnExis;
    }
}