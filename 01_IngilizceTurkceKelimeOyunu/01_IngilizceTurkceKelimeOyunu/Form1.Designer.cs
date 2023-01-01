namespace _01_IngilizceTurkceKelimeOyunu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnPas = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBos = new System.Windows.Forms.Label();
            this.pictureDogru = new System.Windows.Forms.PictureBox();
            this.pictureYanlis = new System.Windows.Forms.PictureBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDogru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYanlis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce Kelime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe Karşılığı:";
            // 
            // txtTurkce
            // 
            this.txtTurkce.Enabled = false;
            this.txtTurkce.Location = new System.Drawing.Point(208, 63);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(278, 34);
            this.txtTurkce.TabIndex = 3;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(26, 119);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(219, 51);
            this.btnBaslat.TabIndex = 4;
            this.btnBaslat.Text = "Oyunu Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnPas
            // 
            this.btnPas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPas.Enabled = false;
            this.btnPas.Location = new System.Drawing.Point(267, 119);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(219, 51);
            this.btnPas.TabIndex = 5;
            this.btnPas.Text = "Diğer Soruya Geç";
            this.btnPas.UseVisualStyleBackColor = true;
            this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.Enabled = false;
            this.btnSonraki.Location = new System.Drawing.Point(267, 176);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(219, 51);
            this.btnSonraki.TabIndex = 6;
            this.btnSonraki.Text = "Sonraki Soru";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Enabled = false;
            this.btnBitir.Location = new System.Drawing.Point(26, 176);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(219, 51);
            this.btnBitir.TabIndex = 7;
            this.btnBitir.Text = "Oyunu Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kalan Süre:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(663, 36);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(103, 25);
            this.lblSure.TabIndex = 9;
            this.lblSure.Text = "90 saniye";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Soru:";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(663, 79);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(84, 25);
            this.lblSoru.TabIndex = 11;
            this.lblSoru.Text = "0. Soru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Doğru:";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(663, 122);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(94, 25);
            this.lblDogru.TabIndex = 13;
            this.lblDogru.Text = "0 Doğru";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Yanlış:";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(663, 165);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(86, 25);
            this.lblYanlis.TabIndex = 15;
            this.lblYanlis.Text = "0 Yanlış";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Boş:";
            // 
            // lblBos
            // 
            this.lblBos.AutoSize = true;
            this.lblBos.Location = new System.Drawing.Point(663, 208);
            this.lblBos.Name = "lblBos";
            this.lblBos.Size = new System.Drawing.Size(67, 25);
            this.lblBos.TabIndex = 17;
            this.lblBos.Text = "0 Boş";
            // 
            // pictureDogru
            // 
            this.pictureDogru.Image = ((System.Drawing.Image)(resources.GetObject("pictureDogru.Image")));
            this.pictureDogru.Location = new System.Drawing.Point(459, 276);
            this.pictureDogru.Name = "pictureDogru";
            this.pictureDogru.Size = new System.Drawing.Size(150, 150);
            this.pictureDogru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDogru.TabIndex = 18;
            this.pictureDogru.TabStop = false;
            // 
            // pictureYanlis
            // 
            this.pictureYanlis.Image = ((System.Drawing.Image)(resources.GetObject("pictureYanlis.Image")));
            this.pictureYanlis.Location = new System.Drawing.Point(638, 276);
            this.pictureYanlis.Name = "pictureYanlis";
            this.pictureYanlis.Size = new System.Drawing.Size(150, 150);
            this.pictureYanlis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureYanlis.TabIndex = 19;
            this.pictureYanlis.TabStop = false;
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(208, 22);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(132, 25);
            this.lblEnglish.TabIndex = 20;
            this.lblEnglish.Text = "---------------";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(119, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 25);
            this.label14.TabIndex = 21;
            this.label14.Text = "Oyunun Kuralları";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 276);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(389, 175);
            this.label15.TabIndex = 22;
            this.label15.Text = "1-) Oyun 90 saniyedir.\r\n2-) Cevapları kontrol etmek için enter\r\ntuşuna ya da sonr" +
    "aki soru butonuna \r\ntıklayınız.\r\n3-) Soruyu pas geçmek için esc tuşuna\r\nya da di" +
    "ğer soruya geç butonuna \r\ntıklayınız.";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSonraki;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.btnPas;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.pictureYanlis);
            this.Controls.Add(this.pictureDogru);
            this.Controls.Add(this.lblBos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnPas);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İngilizce Türkçe Kelime Oyunu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDogru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYanlis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnPas;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBos;
        private System.Windows.Forms.PictureBox pictureDogru;
        private System.Windows.Forms.PictureBox pictureYanlis;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
    }
}

