namespace Proje_Hastane
{
	partial class Frm_SekreterGiris
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
			this.button1 = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtsifre = new System.Windows.Forms.TextBox();
			this.mskdtc = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(60, 138);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(381, 27);
			this.label6.TabIndex = 42;
			this.label6.Text = "Büyükşehir Hastanesi Sekreter Giriş Paneli";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(276, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 26);
			this.button1.TabIndex = 41;
			this.button1.Text = "Giriş Yap";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(197, 291);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(53, 20);
			this.linkLabel1.TabIndex = 40;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Üye ol";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(194, 236);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 27);
			this.label3.TabIndex = 39;
			this.label3.Text = "Şifre:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(117, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 27);
			this.label2.TabIndex = 38;
			this.label2.Text = "TC Kimlik No:";
			// 
			// txtsifre
			// 
			this.txtsifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtsifre.Location = new System.Drawing.Point(256, 241);
			this.txtsifre.Name = "txtsifre";
			this.txtsifre.Size = new System.Drawing.Size(122, 20);
			this.txtsifre.TabIndex = 37;
			this.txtsifre.Text = "1";
			// 
			// mskdtc
			// 
			this.mskdtc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.mskdtc.Location = new System.Drawing.Point(256, 203);
			this.mskdtc.Mask = "00000000000";
			this.mskdtc.Name = "mskdtc";
			this.mskdtc.Size = new System.Drawing.Size(122, 20);
			this.mskdtc.TabIndex = 36;
			this.mskdtc.Text = "61605023699";
			this.mskdtc.ValidatingType = typeof(int);
			// 
			// Frm_SekreterGiris
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(523, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtsifre);
			this.Controls.Add(this.mskdtc);
			this.Name = "Frm_SekreterGiris";
			this.Text = "Frm_SekreterGiris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtsifre;
		private System.Windows.Forms.MaskedTextBox mskdtc;
	}
}