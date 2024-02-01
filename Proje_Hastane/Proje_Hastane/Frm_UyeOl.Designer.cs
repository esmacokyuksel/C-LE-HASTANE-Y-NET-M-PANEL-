namespace Proje_Hastane
{
	partial class Frm_UyeOl
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mkdTc = new System.Windows.Forms.MaskedTextBox();
			this.mkdSifre = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mkdTel = new System.Windows.Forms.MaskedTextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.cbCinsiyet = new System.Windows.Forms.ComboBox();
			this.btnKayıtOl = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(256, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(229, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Soyad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(164, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "TC Kimlik No:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(241, 241);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "Şifre:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(209, 284);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 27);
			this.label5.TabIndex = 4;
			this.label5.Text = "Cinsiyet:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(74, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(460, 34);
			this.label6.TabIndex = 5;
			this.label6.Text = "Büyükşehir Hastanesi Üye Olma Ekranı";
			// 
			// mkdTc
			// 
			this.mkdTc.Location = new System.Drawing.Point(314, 201);
			this.mkdTc.Mask = "00000000000";
			this.mkdTc.Name = "mkdTc";
			this.mkdTc.Size = new System.Drawing.Size(136, 20);
			this.mkdTc.TabIndex = 6;
			this.mkdTc.ValidatingType = typeof(int);
			// 
			// mkdSifre
			// 
			this.mkdSifre.Location = new System.Drawing.Point(314, 241);
			this.mkdSifre.Mask = "000000";
			this.mkdSifre.Name = "mkdSifre";
			this.mkdSifre.Size = new System.Drawing.Size(136, 20);
			this.mkdSifre.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(132, 324);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 27);
			this.label7.TabIndex = 8;
			this.label7.Text = "Telefon Numarası:";
			// 
			// mkdTel
			// 
			this.mkdTel.Location = new System.Drawing.Point(314, 324);
			this.mkdTel.Mask = "(999) 000-00-00";
			this.mkdTel.Name = "mkdTel";
			this.mkdTel.Size = new System.Drawing.Size(136, 20);
			this.mkdTel.TabIndex = 9;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(314, 161);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(136, 20);
			this.txtSoyad.TabIndex = 10;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(314, 120);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(136, 20);
			this.txtAd.TabIndex = 11;
			// 
			// cbCinsiyet
			// 
			this.cbCinsiyet.FormattingEnabled = true;
			this.cbCinsiyet.Items.AddRange(new object[] {
            "Cinsiyetiniz:",
            "Erkek",
            "Kadın"});
			this.cbCinsiyet.Location = new System.Drawing.Point(314, 284);
			this.cbCinsiyet.Name = "cbCinsiyet";
			this.cbCinsiyet.Size = new System.Drawing.Size(136, 21);
			this.cbCinsiyet.TabIndex = 12;
			// 
			// btnKayıtOl
			// 
			this.btnKayıtOl.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKayıtOl.Location = new System.Drawing.Point(261, 372);
			this.btnKayıtOl.Name = "btnKayıtOl";
			this.btnKayıtOl.Size = new System.Drawing.Size(121, 29);
			this.btnKayıtOl.TabIndex = 13;
			this.btnKayıtOl.Text = "Kayıt Ol";
			this.btnKayıtOl.UseVisualStyleBackColor = true;
			this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
			// 
			// Frm_UyeOl
			// 
			this.AcceptButton = this.btnKayıtOl;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(635, 450);
			this.Controls.Add(this.btnKayıtOl);
			this.Controls.Add(this.cbCinsiyet);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.mkdTel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.mkdSifre);
			this.Controls.Add(this.mkdTc);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Frm_UyeOl";
			this.Text = "Frm_UyeOl";
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
		private System.Windows.Forms.MaskedTextBox mkdTc;
		private System.Windows.Forms.MaskedTextBox mkdSifre;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox mkdTel;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.ComboBox cbCinsiyet;
		private System.Windows.Forms.Button btnKayıtOl;
	}
}