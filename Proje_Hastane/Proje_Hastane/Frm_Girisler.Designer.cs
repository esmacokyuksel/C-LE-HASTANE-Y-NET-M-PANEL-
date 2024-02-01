namespace Proje_Hastane
{
	partial class Frm_Girisler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Girisler));
			this.BtnHastaGirisi = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.BtnDoktorGirisi = new System.Windows.Forms.Button();
			this.BtnSekreterGirisi = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnHastaGirisi
			// 
			this.BtnHastaGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGirisi.BackgroundImage")));
			this.BtnHastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnHastaGirisi.Location = new System.Drawing.Point(18, 180);
			this.BtnHastaGirisi.Name = "BtnHastaGirisi";
			this.BtnHastaGirisi.Size = new System.Drawing.Size(177, 106);
			this.BtnHastaGirisi.TabIndex = 0;
			this.BtnHastaGirisi.UseVisualStyleBackColor = true;
			this.BtnHastaGirisi.Click += new System.EventHandler(this.button1_Click);
			// 
			// BtnDoktorGirisi
			// 
			this.BtnDoktorGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGirisi.BackgroundImage")));
			this.BtnDoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnDoktorGirisi.Location = new System.Drawing.Point(201, 180);
			this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
			this.BtnDoktorGirisi.Size = new System.Drawing.Size(177, 106);
			this.BtnDoktorGirisi.TabIndex = 1;
			this.BtnDoktorGirisi.UseVisualStyleBackColor = true;
			this.BtnDoktorGirisi.Click += new System.EventHandler(this.button2_Click);
			// 
			// BtnSekreterGirisi
			// 
			this.BtnSekreterGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGirisi.BackgroundImage")));
			this.BtnSekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.BtnSekreterGirisi.Location = new System.Drawing.Point(384, 180);
			this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
			this.BtnSekreterGirisi.Size = new System.Drawing.Size(177, 106);
			this.BtnSekreterGirisi.TabIndex = 2;
			this.BtnSekreterGirisi.UseVisualStyleBackColor = true;
			this.BtnSekreterGirisi.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(74, 289);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 31);
			this.label1.TabIndex = 3;
			this.label1.Text = "Hasta";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(250, 289);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 31);
			this.label2.TabIndex = 4;
			this.label2.Text = "Doktor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(424, 289);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Sekreter";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(168, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(259, 34);
			this.label4.TabIndex = 7;
			this.label4.Text = "Büyükşehir Hastanesi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(128, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(331, 34);
			this.label5.TabIndex = 8;
			this.label5.Text = "Hastane Paneli Giriş Ekranı";
			// 
			// Frm_Girisler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(584, 388);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnSekreterGirisi);
			this.Controls.Add(this.BtnDoktorGirisi);
			this.Controls.Add(this.BtnHastaGirisi);
			this.MaximizeBox = false;
			this.Name = "Frm_Girisler";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnHastaGirisi;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button BtnDoktorGirisi;
		private System.Windows.Forms.Button BtnSekreterGirisi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

