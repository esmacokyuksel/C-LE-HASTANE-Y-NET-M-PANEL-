namespace Proje_Hastane
{
	partial class FrmBilgiDüzenle
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
			this.button1 = new System.Windows.Forms.Button();
			this.cbcinsiyet = new System.Windows.Forms.ComboBox();
			this.txtad = new System.Windows.Forms.TextBox();
			this.txtsyd = new System.Windows.Forms.TextBox();
			this.mskdtel = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.MSKSİFRE = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tcmkd = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(168, 332);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(189, 29);
			this.button1.TabIndex = 26;
			this.button1.Text = "Bilgilerimi Düzenle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbcinsiyet
			// 
			this.cbcinsiyet.FormattingEnabled = true;
			this.cbcinsiyet.Items.AddRange(new object[] {
            "Cinsiyetiniz:",
            "Erkek",
            "Kadın"});
			this.cbcinsiyet.Location = new System.Drawing.Point(248, 238);
			this.cbcinsiyet.Name = "cbcinsiyet";
			this.cbcinsiyet.Size = new System.Drawing.Size(136, 28);
			this.cbcinsiyet.TabIndex = 25;
			// 
			// txtad
			// 
			this.txtad.Location = new System.Drawing.Point(248, 74);
			this.txtad.Name = "txtad";
			this.txtad.Size = new System.Drawing.Size(136, 27);
			this.txtad.TabIndex = 24;
			// 
			// txtsyd
			// 
			this.txtsyd.Location = new System.Drawing.Point(248, 115);
			this.txtsyd.Name = "txtsyd";
			this.txtsyd.Size = new System.Drawing.Size(136, 27);
			this.txtsyd.TabIndex = 23;
			// 
			// mskdtel
			// 
			this.mskdtel.Location = new System.Drawing.Point(248, 278);
			this.mskdtel.Mask = "(999) 000-00-00";
			this.mskdtel.Name = "mskdtel";
			this.mskdtel.Size = new System.Drawing.Size(136, 27);
			this.mskdtel.TabIndex = 22;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(66, 278);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 27);
			this.label7.TabIndex = 21;
			this.label7.Text = "Telefon Numarası:";
			// 
			// MSKSİFRE
			// 
			this.MSKSİFRE.Location = new System.Drawing.Point(248, 195);
			this.MSKSİFRE.Mask = "000000";
			this.MSKSİFRE.Name = "MSKSİFRE";
			this.MSKSİFRE.Size = new System.Drawing.Size(136, 27);
			this.MSKSİFRE.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(143, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 27);
			this.label5.TabIndex = 18;
			this.label5.Text = "Cinsiyet:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(175, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 27);
			this.label4.TabIndex = 17;
			this.label4.Text = "Şifre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(98, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 27);
			this.label3.TabIndex = 16;
			this.label3.Text = "TC Kimlik No:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(163, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 27);
			this.label2.TabIndex = 15;
			this.label2.Text = "Soyad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(190, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 27);
			this.label1.TabIndex = 14;
			this.label1.Text = "Ad:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(23, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(414, 27);
			this.label6.TabIndex = 27;
			this.label6.Text = "Büyükşehir Hastanesi Bilgi Güncelleme Ekranı";
			// 
			// tcmkd
			// 
			this.tcmkd.Location = new System.Drawing.Point(248, 155);
			this.tcmkd.Mask = "00000000000";
			this.tcmkd.Name = "tcmkd";
			this.tcmkd.Size = new System.Drawing.Size(136, 27);
			this.tcmkd.TabIndex = 19;
			this.tcmkd.ValidatingType = typeof(int);
			// 
			// FrmBilgiDüzenle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(471, 419);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cbcinsiyet);
			this.Controls.Add(this.txtad);
			this.Controls.Add(this.txtsyd);
			this.Controls.Add(this.mskdtel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.MSKSİFRE);
			this.Controls.Add(this.tcmkd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmBilgiDüzenle";
			this.Text = "FrmBilgiDüzenle";
			this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cbcinsiyet;
		private System.Windows.Forms.TextBox txtad;
		private System.Windows.Forms.TextBox txtsyd;
		private System.Windows.Forms.MaskedTextBox mskdtel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox MSKSİFRE;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox tcmkd;
	}
}