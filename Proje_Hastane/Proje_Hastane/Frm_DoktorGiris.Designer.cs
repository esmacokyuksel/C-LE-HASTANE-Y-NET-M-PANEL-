namespace Proje_Hastane
{
	partial class Frm_DoktorGiris
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
			this.label6 = new System.Windows.Forms.Label();
			this.btnGiris = new System.Windows.Forms.Button();
			this.lnkUyeOl = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.mskdTC = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(86, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(371, 27);
			this.label6.TabIndex = 35;
			this.label6.Text = "Büyükşehir Hastanesi Doktor Giriş Paneli";
			// 
			// btnGiris
			// 
			this.btnGiris.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnGiris.Location = new System.Drawing.Point(302, 253);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(102, 26);
			this.btnGiris.TabIndex = 34;
			this.btnGiris.Text = "Giriş Yap";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// lnkUyeOl
			// 
			this.lnkUyeOl.AutoSize = true;
			this.lnkUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lnkUyeOl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lnkUyeOl.LinkColor = System.Drawing.Color.Transparent;
			this.lnkUyeOl.Location = new System.Drawing.Point(223, 257);
			this.lnkUyeOl.Name = "lnkUyeOl";
			this.lnkUyeOl.Size = new System.Drawing.Size(53, 20);
			this.lnkUyeOl.TabIndex = 33;
			this.lnkUyeOl.TabStop = true;
			this.lnkUyeOl.Text = "Üye ol";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(220, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 27);
			this.label3.TabIndex = 32;
			this.label3.Text = "Şifre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(143, 169);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 27);
			this.label2.TabIndex = 31;
			this.label2.Text = "TC Kimlik No:";
			// 
			// txtSifre
			// 
			this.txtSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtSifre.Location = new System.Drawing.Point(282, 207);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(122, 20);
			this.txtSifre.TabIndex = 30;
			this.txtSifre.Text = "202020";
			// 
			// mskdTC
			// 
			this.mskdTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.mskdTC.Location = new System.Drawing.Point(282, 169);
			this.mskdTC.Mask = "00000000000";
			this.mskdTC.Name = "mskdTC";
			this.mskdTC.Size = new System.Drawing.Size(122, 20);
			this.mskdTC.TabIndex = 29;
			this.mskdTC.Text = "20202020202";
			this.mskdTC.ValidatingType = typeof(int);
			// 
			// Frm_DoktorGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(574, 429);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.lnkUyeOl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.mskdTC);
			this.Name = "Frm_DoktorGiris";
			this.Text = "Frm_DoktorGiris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.LinkLabel lnkUyeOl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.MaskedTextBox mskdTC;
	}
}