namespace MetinYazariBelirleme_200601021_SanerYesil
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
            this.btnMetinYukle = new System.Windows.Forms.Button();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.txtShowInfo = new System.Windows.Forms.TextBox();
            this.btnAgacAktar = new System.Windows.Forms.Button();
            this.btnCommonWords = new System.Windows.Forms.Button();
            this.btnHashOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMetinYukle
            // 
            this.btnMetinYukle.Location = new System.Drawing.Point(12, 12);
            this.btnMetinYukle.Name = "btnMetinYukle";
            this.btnMetinYukle.Size = new System.Drawing.Size(292, 57);
            this.btnMetinYukle.TabIndex = 0;
            this.btnMetinYukle.Text = "Metin Yükle";
            this.btnMetinYukle.UseVisualStyleBackColor = true;
            this.btnMetinYukle.Click += new System.EventHandler(this.btnMetinYukle_Click);
            // 
            // btnStackOku
            // 
            this.btnStackOku.Location = new System.Drawing.Point(310, 12);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(292, 57);
            this.btnStackOku.TabIndex = 1;
            this.btnStackOku.Text = "Stack\'e Oku";
            this.btnStackOku.UseVisualStyleBackColor = true;
            // 
            // txtShowInfo
            // 
            this.txtShowInfo.Location = new System.Drawing.Point(12, 138);
            this.txtShowInfo.Multiline = true;
            this.txtShowInfo.Name = "txtShowInfo";
            this.txtShowInfo.Size = new System.Drawing.Size(883, 268);
            this.txtShowInfo.TabIndex = 2;
            // 
            // btnAgacAktar
            // 
            this.btnAgacAktar.Location = new System.Drawing.Point(608, 12);
            this.btnAgacAktar.Name = "btnAgacAktar";
            this.btnAgacAktar.Size = new System.Drawing.Size(292, 57);
            this.btnAgacAktar.TabIndex = 3;
            this.btnAgacAktar.Text = "Ağaca Aktar";
            this.btnAgacAktar.UseVisualStyleBackColor = true;
            // 
            // btnCommonWords
            // 
            this.btnCommonWords.Location = new System.Drawing.Point(152, 75);
            this.btnCommonWords.Name = "btnCommonWords";
            this.btnCommonWords.Size = new System.Drawing.Size(292, 57);
            this.btnCommonWords.TabIndex = 4;
            this.btnCommonWords.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.btnCommonWords.UseVisualStyleBackColor = true;
            // 
            // btnHashOlustur
            // 
            this.btnHashOlustur.Location = new System.Drawing.Point(450, 75);
            this.btnHashOlustur.Name = "btnHashOlustur";
            this.btnHashOlustur.Size = new System.Drawing.Size(292, 57);
            this.btnHashOlustur.TabIndex = 5;
            this.btnHashOlustur.Text = "Hash Tablo Oluştur";
            this.btnHashOlustur.UseVisualStyleBackColor = true;
            this.btnHashOlustur.Click += new System.EventHandler(this.btnHashOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 418);
            this.Controls.Add(this.btnHashOlustur);
            this.Controls.Add(this.btnCommonWords);
            this.Controls.Add(this.btnAgacAktar);
            this.Controls.Add(this.txtShowInfo);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.btnMetinYukle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinYukle;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.TextBox txtShowInfo;
        private System.Windows.Forms.Button btnAgacAktar;
        private System.Windows.Forms.Button btnCommonWords;
        private System.Windows.Forms.Button btnHashOlustur;
    }
}

