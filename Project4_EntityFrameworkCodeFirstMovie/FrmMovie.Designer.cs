namespace Project4_EntityFrameworkCodeFirstMovie
{
    partial class FrmMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovieDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMovieDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCreatedDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnMovieListele = new System.Windows.Forms.Button();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.btnMovieAdd = new System.Windows.Forms.Button();
            this.btnMovieRemove = new System.Windows.Forms.Button();
            this.btnMovieSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMovieSearch2 = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnMovieWithCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Id:";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(190, 4);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(266, 34);
            this.txtMovieId.TabIndex = 1;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(190, 54);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(266, 34);
            this.txtMovieName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film Adı:";
            // 
            // txtMovieDuration
            // 
            this.txtMovieDuration.Location = new System.Drawing.Point(190, 104);
            this.txtMovieDuration.Name = "txtMovieDuration";
            this.txtMovieDuration.Size = new System.Drawing.Size(266, 34);
            this.txtMovieDuration.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Film Süresi:";
            // 
            // txtMovieDescription
            // 
            this.txtMovieDescription.Location = new System.Drawing.Point(194, 160);
            this.txtMovieDescription.Name = "txtMovieDescription";
            this.txtMovieDescription.Size = new System.Drawing.Size(266, 34);
            this.txtMovieDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "İzlenme Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kategori:";
            // 
            // mskCreatedDate
            // 
            this.mskCreatedDate.Location = new System.Drawing.Point(194, 206);
            this.mskCreatedDate.Mask = "00/00/0000";
            this.mskCreatedDate.Name = "mskCreatedDate";
            this.mskCreatedDate.Size = new System.Drawing.Size(266, 34);
            this.mskCreatedDate.TabIndex = 10;
            this.mskCreatedDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(194, 254);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(266, 37);
            this.cmbCategory.TabIndex = 11;
            // 
            // btnMovieListele
            // 
            this.btnMovieListele.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMovieListele.Location = new System.Drawing.Point(495, 9);
            this.btnMovieListele.Name = "btnMovieListele";
            this.btnMovieListele.Size = new System.Drawing.Size(167, 36);
            this.btnMovieListele.TabIndex = 12;
            this.btnMovieListele.Text = "Listele";
            this.btnMovieListele.UseVisualStyleBackColor = false;
            this.btnMovieListele.Click += new System.EventHandler(this.btnMovieListele_Click);
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnMovieUpdate.Location = new System.Drawing.Point(495, 52);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(167, 36);
            this.btnMovieUpdate.TabIndex = 13;
            this.btnMovieUpdate.Text = "Güncelle";
            this.btnMovieUpdate.UseVisualStyleBackColor = false;
            this.btnMovieUpdate.Click += new System.EventHandler(this.btnMovieUpdate_Click);
            // 
            // btnMovieAdd
            // 
            this.btnMovieAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnMovieAdd.Location = new System.Drawing.Point(495, 136);
            this.btnMovieAdd.Name = "btnMovieAdd";
            this.btnMovieAdd.Size = new System.Drawing.Size(167, 36);
            this.btnMovieAdd.TabIndex = 14;
            this.btnMovieAdd.Text = "Ekle";
            this.btnMovieAdd.UseVisualStyleBackColor = false;
            this.btnMovieAdd.Click += new System.EventHandler(this.btnMovieAdd_Click);
            // 
            // btnMovieRemove
            // 
            this.btnMovieRemove.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMovieRemove.Location = new System.Drawing.Point(495, 178);
            this.btnMovieRemove.Name = "btnMovieRemove";
            this.btnMovieRemove.Size = new System.Drawing.Size(167, 36);
            this.btnMovieRemove.TabIndex = 15;
            this.btnMovieRemove.Text = "Sil";
            this.btnMovieRemove.UseVisualStyleBackColor = false;
            this.btnMovieRemove.Click += new System.EventHandler(this.btnMovieRemove_Click);
            // 
            // btnMovieSearch
            // 
            this.btnMovieSearch.BackColor = System.Drawing.Color.Lime;
            this.btnMovieSearch.Location = new System.Drawing.Point(495, 94);
            this.btnMovieSearch.Name = "btnMovieSearch";
            this.btnMovieSearch.Size = new System.Drawing.Size(167, 36);
            this.btnMovieSearch.TabIndex = 16;
            this.btnMovieSearch.Text = "Ara";
            this.btnMovieSearch.UseVisualStyleBackColor = false;
            this.btnMovieSearch.Click += new System.EventHandler(this.btnMovieSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 262);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnMovieSearch2
            // 
            this.btnMovieSearch2.BackColor = System.Drawing.Color.Crimson;
            this.btnMovieSearch2.Location = new System.Drawing.Point(495, 220);
            this.btnMovieSearch2.Name = "btnMovieSearch2";
            this.btnMovieSearch2.Size = new System.Drawing.Size(167, 36);
            this.btnMovieSearch2.TabIndex = 18;
            this.btnMovieSearch2.Text = "Bul";
            this.btnMovieSearch2.UseVisualStyleBackColor = false;
            this.btnMovieSearch2.Click += new System.EventHandler(this.btnMovieSearch2_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.HotPink;
            this.btnGo.Location = new System.Drawing.Point(495, 258);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(167, 36);
            this.btnGo.TabIndex = 19;
            this.btnGo.Text = "Diğer Sayfa";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnMovieWithCategory
            // 
            this.btnMovieWithCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMovieWithCategory.Location = new System.Drawing.Point(678, 12);
            this.btnMovieWithCategory.Name = "btnMovieWithCategory";
            this.btnMovieWithCategory.Size = new System.Drawing.Size(100, 136);
            this.btnMovieWithCategory.TabIndex = 20;
            this.btnMovieWithCategory.Text = "Detaylı Listele";
            this.btnMovieWithCategory.UseVisualStyleBackColor = false;
            this.btnMovieWithCategory.Click += new System.EventHandler(this.btnMovieWithCategory_Click);
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(790, 591);
            this.Controls.Add(this.btnMovieWithCategory);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnMovieSearch2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMovieSearch);
            this.Controls.Add(this.btnMovieRemove);
            this.Controls.Add(this.btnMovieAdd);
            this.Controls.Add(this.btnMovieUpdate);
            this.Controls.Add(this.btnMovieListele);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.mskCreatedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMovieDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMovieDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMovie";
            this.Text = "FrmMovie";
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovieDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMovieDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCreatedDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnMovieListele;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.Button btnMovieAdd;
        private System.Windows.Forms.Button btnMovieRemove;
        private System.Windows.Forms.Button btnMovieSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMovieSearch2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnMovieWithCategory;
    }
}