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
	public partial class Frm_HastaDetay : Form
	{
		public Frm_HastaDetay()
		{
			InitializeComponent();
		}
		public string tc;

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		SqlBağlantısı bgl = new SqlBağlantısı();
		private void mkdTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		
		}

		private void lblTC_Click(object sender, EventArgs e)
		{
	
		}

		private void Frm_HastaDetay_Load(object sender, EventArgs e)
		{
			//Ad Soyad Çekme
			lblTC.Text = tc;
			SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", lblTC.Text);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				lblAdSoyad.Text = dr[0] + " " + dr[1];
				bgl.baglanti().Close();
			}
			//Randevu Geçmişi
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc,bgl.baglanti());
			da.Fill(dt);
			dataGridView1.DataSource = dt;

			//Branşları Çekme

			SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans" ,bgl.baglanti());
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				cmbBrans.Items.Add(dr2[0]);
			}
			bgl.baglanti().Close();














		}

		private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbDoktor.Items.Clear();
			SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorBrans=@p1",bgl.baglanti());
			komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
			SqlDataReader dr3 = komut3.ExecuteReader();
			while (dr3.Read())
			{
				cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
			}
			bgl.baglanti().Close();
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter ("Select * From Tbl_Randevular where RandevuBrans='" + cmbBrans.Text + "'" ,bgl.baglanti());
			da.Fill(dt);
			dataGridView2.DataSource = dt;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
			fr.TCno = lblTC.Text;
			fr.Show();
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut4 = new SqlCommand("Update Tbl_Randevular set HastaTC=@p1,HastaSikayet=@p2  where Randevuid=@p3", bgl.baglanti());
			komut4.Parameters.AddWithValue("@p2", rchSikayet.Text);
			komut4.Parameters.AddWithValue("@p3", txtid.Text);
			komut4.Parameters.AddWithValue("@p1", lblTC.Text);
			komut4.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Randevu Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView2.SelectedCells[0].RowIndex;
			txtid.Text = dataGridView2.Rows[secilen].ToString();

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
