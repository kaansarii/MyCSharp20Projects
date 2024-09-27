namespace Project10_PostgreSQLToDolistApp
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIslemId = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtOncelik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbTamamlandi = new System.Windows.Forms.RadioButton();
            this.rdbDevamEdiyor = new System.Windows.Forms.RadioButton();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTamamlananlar = new System.Windows.Forms.Button();
            this.btnTumListe = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnDevamEdenler = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnKategoriListesi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlık:";
            // 
            // txtIslemId
            // 
            this.txtIslemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemId.Location = new System.Drawing.Point(90, 15);
            this.txtIslemId.Name = "txtIslemId";
            this.txtIslemId.Size = new System.Drawing.Size(178, 28);
            this.txtIslemId.TabIndex = 2;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.DarkOrange;
            this.btnListele.Location = new System.Drawing.Point(291, 15);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(236, 38);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.Location = new System.Drawing.Point(90, 52);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(178, 28);
            this.txtBaslik.TabIndex = 5;
            // 
            // txtOncelik
            // 
            this.txtOncelik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOncelik.Location = new System.Drawing.Point(90, 141);
            this.txtOncelik.Name = "txtOncelik";
            this.txtOncelik.Size = new System.Drawing.Size(178, 28);
            this.txtOncelik.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öncelik:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(90, 174);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(178, 127);
            this.txtAciklama.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama:";
            // 
            // rdbTamamlandi
            // 
            this.rdbTamamlandi.AutoSize = true;
            this.rdbTamamlandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTamamlandi.Location = new System.Drawing.Point(6, 307);
            this.rdbTamamlandi.Name = "rdbTamamlandi";
            this.rdbTamamlandi.Size = new System.Drawing.Size(129, 26);
            this.rdbTamamlandi.TabIndex = 13;
            this.rdbTamamlandi.TabStop = true;
            this.rdbTamamlandi.Text = "Tamamlandı";
            this.rdbTamamlandi.UseVisualStyleBackColor = true;
            // 
            // rdbDevamEdiyor
            // 
            this.rdbDevamEdiyor.AutoSize = true;
            this.rdbDevamEdiyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDevamEdiyor.Location = new System.Drawing.Point(150, 307);
            this.rdbDevamEdiyor.Name = "rdbDevamEdiyor";
            this.rdbDevamEdiyor.Size = new System.Drawing.Size(143, 26);
            this.rdbDevamEdiyor.TabIndex = 14;
            this.rdbDevamEdiyor.TabStop = true;
            this.rdbDevamEdiyor.Text = "Devam Ediyor";
            this.rdbDevamEdiyor.UseVisualStyleBackColor = true;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.Gold;
            this.btnOlustur.Location = new System.Drawing.Point(291, 55);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(236, 38);
            this.btnOlustur.TabIndex = 15;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSil.Location = new System.Drawing.Point(291, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(236, 38);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTamamlananlar
            // 
            this.btnTamamlananlar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnTamamlananlar.Location = new System.Drawing.Point(291, 223);
            this.btnTamamlananlar.Name = "btnTamamlananlar";
            this.btnTamamlananlar.Size = new System.Drawing.Size(236, 38);
            this.btnTamamlananlar.TabIndex = 19;
            this.btnTamamlananlar.Text = "Tamamlananlar";
            this.btnTamamlananlar.UseVisualStyleBackColor = false;
            this.btnTamamlananlar.Click += new System.EventHandler(this.btnTamamlananlar_Click);
            // 
            // btnTumListe
            // 
            this.btnTumListe.BackColor = System.Drawing.Color.SpringGreen;
            this.btnTumListe.Location = new System.Drawing.Point(291, 177);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(236, 38);
            this.btnTumListe.TabIndex = 18;
            this.btnTumListe.Text = "Tüm Liste(Kategori)";
            this.btnTumListe.UseVisualStyleBackColor = false;
            this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Fuchsia;
            this.btnGuncelle.Location = new System.Drawing.Point(291, 138);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(236, 38);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnDevamEdenler
            // 
            this.btnDevamEdenler.BackColor = System.Drawing.Color.Chocolate;
            this.btnDevamEdenler.Location = new System.Drawing.Point(291, 263);
            this.btnDevamEdenler.Name = "btnDevamEdenler";
            this.btnDevamEdenler.Size = new System.Drawing.Size(236, 38);
            this.btnDevamEdenler.TabIndex = 20;
            this.btnDevamEdenler.Text = "Devam Edenler";
            this.btnDevamEdenler.UseVisualStyleBackColor = false;
            this.btnDevamEdenler.Click += new System.EventHandler(this.btnDevamEdenler_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(90, 93);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(178, 37);
            this.cmbKategori.TabIndex = 21;
            // 
            // btnKategoriListesi
            // 
            this.btnKategoriListesi.BackColor = System.Drawing.Color.Salmon;
            this.btnKategoriListesi.Location = new System.Drawing.Point(291, 307);
            this.btnKategoriListesi.Name = "btnKategoriListesi";
            this.btnKategoriListesi.Size = new System.Drawing.Size(236, 38);
            this.btnKategoriListesi.TabIndex = 22;
            this.btnKategoriListesi.Text = "Kategori Listesi";
            this.btnKategoriListesi.UseVisualStyleBackColor = false;
            this.btnKategoriListesi.Click += new System.EventHandler(this.btnKategoriListesi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(543, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(890, 325);
            this.dataGridView1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1461, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKategoriListesi);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnDevamEdenler);
            this.Controls.Add(this.btnTamamlananlar);
            this.Controls.Add(this.btnTumListe);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.rdbDevamEdiyor);
            this.Controls.Add(this.rdbTamamlandi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOncelik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtIslemId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIslemId;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtOncelik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbTamamlandi;
        private System.Windows.Forms.RadioButton rdbDevamEdiyor;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTamamlananlar;
        private System.Windows.Forms.Button btnTumListe;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnDevamEdenler;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnKategoriListesi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

