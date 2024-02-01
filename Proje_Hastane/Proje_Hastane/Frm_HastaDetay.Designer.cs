namespace Proje_Hastane
{
	partial class Frm_HastaDetay
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAdSoyad = new System.Windows.Forms.Label();
			this.lblTC = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.lblid = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.rchSikayet = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbDoktor = new System.Windows.Forms.ComboBox();
			this.cmbBrans = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblAdSoyad);
			this.groupBox1.Controls.Add(this.lblTC);
			this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox1.Location = new System.Drawing.Point(12, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(238, 119);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kişi Bilgileri";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(11, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "TC Kimlik No:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(11, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Ad-Soyad:";
			// 
			// lblAdSoyad
			// 
			this.lblAdSoyad.AutoSize = true;
			this.lblAdSoyad.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdSoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblAdSoyad.Location = new System.Drawing.Point(94, 65);
			this.lblAdSoyad.Name = "lblAdSoyad";
			this.lblAdSoyad.Size = new System.Drawing.Size(77, 20);
			this.lblAdSoyad.TabIndex = 12;
			this.lblAdSoyad.Text = "Ad-Soyad:";
			// 
			// lblTC
			// 
			this.lblTC.AutoSize = true;
			this.lblTC.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTC.Location = new System.Drawing.Point(116, 45);
			this.lblTC.Name = "lblTC";
			this.lblTC.Size = new System.Drawing.Size(102, 20);
			this.lblTC.TabIndex = 7;
			this.lblTC.Text = "TC Kimlik No:";
			this.lblTC.Click += new System.EventHandler(this.lblTC_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtid);
			this.groupBox2.Controls.Add(this.lblid);
			this.groupBox2.Controls.Add(this.linkLabel1);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.rchSikayet);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.cmbDoktor);
			this.groupBox2.Controls.Add(this.cmbBrans);
			this.groupBox2.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox2.Location = new System.Drawing.Point(11, 160);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(239, 278);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Randevu Paneli";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(120, 23);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(108, 28);
			this.txtid.TabIndex = 2;
			this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			// 
			// lblid
			// 
			this.lblid.AutoSize = true;
			this.lblid.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblid.Location = new System.Drawing.Point(13, 31);
			this.lblid.Name = "lblid";
			this.lblid.Size = new System.Drawing.Size(90, 20);
			this.lblid.TabIndex = 18;
			this.lblid.Text = "Randevu İD:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(54, 246);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(146, 20);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Bilgilerimi düzenle";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(16, 209);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(203, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "Randevu Al";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// rchSikayet
			// 
			this.rchSikayet.Location = new System.Drawing.Point(16, 145);
			this.rchSikayet.Name = "rchSikayet";
			this.rchSikayet.Size = new System.Drawing.Size(203, 58);
			this.rchSikayet.TabIndex = 2;
			this.rchSikayet.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(54, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 20);
			this.label7.TabIndex = 17;
			this.label7.Text = "Şikayetiniz Nedir?";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(7, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 20);
			this.label6.TabIndex = 16;
			this.label6.Text = "Doktor Seçiniz:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Script", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(12, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Branş Seçiniz:";
			// 
			// cmbDoktor
			// 
			this.cmbDoktor.FormattingEnabled = true;
			this.cmbDoktor.Location = new System.Drawing.Point(121, 91);
			this.cmbDoktor.Name = "cmbDoktor";
			this.cmbDoktor.Size = new System.Drawing.Size(107, 28);
			this.cmbDoktor.TabIndex = 3;
			this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
			// 
			// cmbBrans
			// 
			this.cmbBrans.FormattingEnabled = true;
			this.cmbBrans.Location = new System.Drawing.Point(120, 57);
			this.cmbBrans.Name = "cmbBrans";
			this.cmbBrans.Size = new System.Drawing.Size(107, 28);
			this.cmbBrans.TabIndex = 2;
			this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox3.Location = new System.Drawing.Point(256, 26);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(532, 201);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Randevu Geçmişi";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(526, 174);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGridView2);
			this.groupBox4.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox4.Location = new System.Drawing.Point(256, 233);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(532, 205);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Aktif Randevular";
			// 
			// dataGridView2
			// 
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 24);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(526, 178);
			this.dataGridView2.TabIndex = 1;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
			// 
			// Frm_HastaDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(803, 457);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Frm_HastaDetay";
			this.Text = "Frm_HastaDetay";
			this.Load += new System.EventHandler(this.Frm_HastaDetay_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label lblTC;
		private System.Windows.Forms.Label lblAdSoyad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbDoktor;
		private System.Windows.Forms.ComboBox cmbBrans;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox rchSikayet;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblid;
		private System.Windows.Forms.TextBox txtid;
	}
}