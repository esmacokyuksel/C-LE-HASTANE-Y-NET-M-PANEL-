namespace Proje_Hastane
{
	partial class Frm_HastaGiris
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
			this.mkdTc = new System.Windows.Forms.MaskedTextBox();
			this.mkdSifre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGirisYap = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// mkdTc
			// 
			this.mkdTc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.mkdTc.Location = new System.Drawing.Point(329, 133);
			this.mkdTc.Mask = "00000000000";
			this.mkdTc.Name = "mkdTc";
			this.mkdTc.Size = new System.Drawing.Size(122, 20);
			this.mkdTc.TabIndex = 1;
			this.mkdTc.ValidatingType = typeof(int);
			// 
			// mkdSifre
			// 
			this.mkdSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.mkdSifre.Location = new System.Drawing.Point(329, 171);
			this.mkdSifre.Name = "mkdSifre";
			this.mkdSifre.Size = new System.Drawing.Size(122, 20);
			this.mkdSifre.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(190, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 27);
			this.label2.TabIndex = 4;
			this.label2.Text = "TC Kimlik No:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(267, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 27);
			this.label3.TabIndex = 5;
			this.label3.Text = "Şifre:";
			// 
			// btnGirisYap
			// 
			this.btnGirisYap.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnGirisYap.Location = new System.Drawing.Point(349, 217);
			this.btnGirisYap.Name = "btnGirisYap";
			this.btnGirisYap.Size = new System.Drawing.Size(102, 26);
			this.btnGirisYap.TabIndex = 7;
			this.btnGirisYap.Text = "Giriş Yap";
			this.btnGirisYap.UseVisualStyleBackColor = true;
			this.btnGirisYap.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(133, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(360, 27);
			this.label6.TabIndex = 28;
			this.label6.Text = "Büyükşehir Hastanesi Hasta Giriş Paneli";
			// 
			// LnkUyeOl
			// 
			this.LnkUyeOl.AutoSize = true;
			this.LnkUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LnkUyeOl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LnkUyeOl.LinkColor = System.Drawing.Color.Transparent;
			this.LnkUyeOl.Location = new System.Drawing.Point(269, 221);
			this.LnkUyeOl.Name = "LnkUyeOl";
			this.LnkUyeOl.Size = new System.Drawing.Size(60, 20);
			this.LnkUyeOl.TabIndex = 6;
			this.LnkUyeOl.TabStop = true;
			this.LnkUyeOl.Text = " Üye Ol";
			this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
			// 
			// Frm_HastaGiris
			// 
			this.AcceptButton = this.btnGirisYap;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(646, 372);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnGirisYap);
			this.Controls.Add(this.LnkUyeOl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mkdSifre);
			this.Controls.Add(this.mkdTc);
			this.MinimizeBox = false;
			this.Name = "Frm_HastaGiris";
			this.Text = "Frm_HastaGiris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox mkdTc;
		private System.Windows.Forms.TextBox mkdSifre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGirisYap;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel LnkUyeOl;
	}
}