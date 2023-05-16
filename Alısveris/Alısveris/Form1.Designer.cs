namespace Alısveris
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPantolonFiyati = new System.Windows.Forms.TextBox();
            this.txtElbiseFiyati = new System.Windows.Forms.TextBox();
            this.txtGomlekFiyati = new System.Windows.Forms.TextBox();
            this.txtPantolonAdedi = new System.Windows.Forms.TextBox();
            this.txtElbiseAdedi = new System.Windows.Forms.TextBox();
            this.txtGomlekAdedi = new System.Windows.Forms.TextBox();
            this.txtMusterininAdi = new System.Windows.Forms.TextBox();
            this.txtMusterininParasi = new System.Windows.Forms.TextBox();
            this.lstOdenenMiktar = new System.Windows.Forms.ListBox();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınan Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pantolon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elbise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gömlek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyatları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Müşteri Parası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Müşteri Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gömlek";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Elbise";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Pantolon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "ÖDENEN MİKTAR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "MÜŞTERİLER";
            // 
            // txtPantolonFiyati
            // 
            this.txtPantolonFiyati.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPantolonFiyati.Location = new System.Drawing.Point(82, 157);
            this.txtPantolonFiyati.Name = "txtPantolonFiyati";
            this.txtPantolonFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtPantolonFiyati.TabIndex = 12;
            // 
            // txtElbiseFiyati
            // 
            this.txtElbiseFiyati.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtElbiseFiyati.Location = new System.Drawing.Point(82, 123);
            this.txtElbiseFiyati.Name = "txtElbiseFiyati";
            this.txtElbiseFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtElbiseFiyati.TabIndex = 13;
            // 
            // txtGomlekFiyati
            // 
            this.txtGomlekFiyati.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGomlekFiyati.Location = new System.Drawing.Point(82, 89);
            this.txtGomlekFiyati.Name = "txtGomlekFiyati";
            this.txtGomlekFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtGomlekFiyati.TabIndex = 14;
            // 
            // txtPantolonAdedi
            // 
            this.txtPantolonAdedi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPantolonAdedi.Location = new System.Drawing.Point(95, 355);
            this.txtPantolonAdedi.Name = "txtPantolonAdedi";
            this.txtPantolonAdedi.Size = new System.Drawing.Size(100, 22);
            this.txtPantolonAdedi.TabIndex = 15;
            // 
            // txtElbiseAdedi
            // 
            this.txtElbiseAdedi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtElbiseAdedi.Location = new System.Drawing.Point(95, 327);
            this.txtElbiseAdedi.Name = "txtElbiseAdedi";
            this.txtElbiseAdedi.Size = new System.Drawing.Size(100, 22);
            this.txtElbiseAdedi.TabIndex = 16;
            // 
            // txtGomlekAdedi
            // 
            this.txtGomlekAdedi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGomlekAdedi.Location = new System.Drawing.Point(95, 299);
            this.txtGomlekAdedi.Name = "txtGomlekAdedi";
            this.txtGomlekAdedi.Size = new System.Drawing.Size(100, 22);
            this.txtGomlekAdedi.TabIndex = 17;
            // 
            // txtMusterininAdi
            // 
            this.txtMusterininAdi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMusterininAdi.Location = new System.Drawing.Point(95, 271);
            this.txtMusterininAdi.Name = "txtMusterininAdi";
            this.txtMusterininAdi.Size = new System.Drawing.Size(100, 22);
            this.txtMusterininAdi.TabIndex = 18;
            // 
            // txtMusterininParasi
            // 
            this.txtMusterininParasi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMusterininParasi.Location = new System.Drawing.Point(95, 240);
            this.txtMusterininParasi.Name = "txtMusterininParasi";
            this.txtMusterininParasi.Size = new System.Drawing.Size(100, 22);
            this.txtMusterininParasi.TabIndex = 19;
            // 
            // lstOdenenMiktar
            // 
            this.lstOdenenMiktar.BackColor = System.Drawing.SystemColors.Info;
            this.lstOdenenMiktar.FormattingEnabled = true;
            this.lstOdenenMiktar.ItemHeight = 16;
            this.lstOdenenMiktar.Location = new System.Drawing.Point(538, 89);
            this.lstOdenenMiktar.Name = "lstOdenenMiktar";
            this.lstOdenenMiktar.Size = new System.Drawing.Size(168, 292);
            this.lstOdenenMiktar.TabIndex = 20;
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.BackColor = System.Drawing.SystemColors.Info;
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 16;
            this.lstMusteriler.Location = new System.Drawing.Point(335, 89);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(165, 292);
            this.lstMusteriler.TabIndex = 21;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.BackColor = System.Drawing.Color.DarkGray;
            this.btnSatinAl.Location = new System.Drawing.Point(95, 403);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(111, 35);
            this.btnSatinAl.TabIndex = 22;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(188, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "TL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(188, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "TL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "TL";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(201, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Adet";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 330);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "Adet";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(201, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "Adet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(827, 484);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.lstMusteriler);
            this.Controls.Add(this.lstOdenenMiktar);
            this.Controls.Add(this.txtMusterininParasi);
            this.Controls.Add(this.txtMusterininAdi);
            this.Controls.Add(this.txtGomlekAdedi);
            this.Controls.Add(this.txtElbiseAdedi);
            this.Controls.Add(this.txtPantolonAdedi);
            this.Controls.Add(this.txtGomlekFiyati);
            this.Controls.Add(this.txtElbiseFiyati);
            this.Controls.Add(this.txtPantolonFiyati);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alışveriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPantolonFiyati;
        private System.Windows.Forms.TextBox txtElbiseFiyati;
        private System.Windows.Forms.TextBox txtGomlekFiyati;
        private System.Windows.Forms.TextBox txtPantolonAdedi;
        private System.Windows.Forms.TextBox txtElbiseAdedi;
        private System.Windows.Forms.TextBox txtGomlekAdedi;
        private System.Windows.Forms.TextBox txtMusterininAdi;
        private System.Windows.Forms.TextBox txtMusterininParasi;
        private System.Windows.Forms.ListBox lstOdenenMiktar;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

