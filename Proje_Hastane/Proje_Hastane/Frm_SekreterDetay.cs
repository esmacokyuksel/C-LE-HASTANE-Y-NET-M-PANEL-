using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
	public partial class Frm_SekreterDetay : Form
	{
		public Frm_SekreterDetay()
		{
			InitializeComponent();
		}

		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}
		public string TCnumara;
		SqlBağlantısı bgl = new SqlBağlantısı();

		private void Frm_SekreterDetay_Load(object sender, EventArgs e)
		{
			tctTc.Text = TCnumara;
			//Ad Soyad
			SqlCommand komut1 = new SqlCommand("Select SekreterAd,SekreterSoyad From Tbl_Sekreter where SekreterTC=@p1 ", bgl.baglanti());
			komut1.Parameters.AddWithValue("@p1", tctTc.Text);
			SqlDataReader dr1 = komut1.ExecuteReader();
			while (dr1.Read())
			{
				lblad.Text = dr1[0].ToString();
				lblsoyad.Text = dr1[1].ToString();
			}
			bgl.baglanti().Close();

			//Branşları DataGride Aktarma
			DataTable dt1 = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Tbl_Brans",bgl.baglanti());
			da.Fill(dt1);
			dataGridView1.DataSource = dt1;

			//Doktorları DataGride Aktarma
			DataTable dt2 = new DataTable();
			SqlDataAdapter da2 = new SqlDataAdapter("Select DoktorAd,DoktorSoyad from Tbl_Doktor", bgl.baglanti());
			da2.Fill(dt2);
			dataGridView2.DataSource = dt2;
			// Branşı Combobaxa aktarma
			SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglanti());
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				cbBrans.Items.Add(dr2[0]);
			}
			bgl.baglanti().Close();

		}

		private void txtTc_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
			komutKaydet.Parameters.AddWithValue("@r1",mskdTarih.Text);
			komutKaydet.Parameters.AddWithValue("@r2", mskdSaat.Text);
			komutKaydet.Parameters.AddWithValue("@r3", cbBrans.Text);
			komutKaydet.Parameters.AddWithValue("@r4", cbDoktor.Text);
			komutKaydet.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Randevunuz Oluşturuldu");

			
		}

		private void cbBrans_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbDoktor.Items.Clear();
			SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor Where DoktorBrans=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1",cbBrans.Text);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cbDoktor.Items.Add(dr[0] + " " + dr[1]);
			}
			bgl.baglanti().Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into Tbl_Duyuru (duyuru) values (@d1) ", bgl.baglanti());
			komut.Parameters.AddWithValue("@d1", duyuru.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Duyuru Oluşturuldu");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Frm_DoktorPaneli drp = new Frm_DoktorPaneli();
			drp.Show();

		}

		private void button5_Click(object sender, EventArgs e)
		{
			Frm_BransPaneli frb = new Frm_BransPaneli();
			frb.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Frm_RandevuPaneli frl = new Frm_RandevuPaneli();
			frl.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuTarih=@p1,RandevuSaat=@p2,RandevuBrans=@p3,RandevuDoktor=@p4,HastaTC=@p6", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", mskdTarih.Text);
			komut.Parameters.AddWithValue("@p2", mskdSaat.Text);
			komut.Parameters.AddWithValue("@p3", cbBrans.Text);
			komut.Parameters.AddWithValue("@p4", cbDoktor.Text);
			komut.Parameters.AddWithValue("@p6", mskdTc.Text);

			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Randevu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void btnDuyuru_Click(object sender, EventArgs e)
		{
			Frm_Duyurular fr = new Frm_Duyurular();
			fr.Show();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
