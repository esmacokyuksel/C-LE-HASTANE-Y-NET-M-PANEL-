using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proje_Hastane
{
	public partial class Frm_DoktorPaneli : Form
	{
		public Frm_DoktorPaneli()
		{
			InitializeComponent();
		}
		SqlBağlantısı bgl = new SqlBağlantısı();

		private void Frm_DoktorPaneli_Load(object sender, EventArgs e)
		{
			//Doktorları DataGride Aktarma
			DataTable dt2 = new DataTable();
			SqlDataAdapter da2 = new SqlDataAdapter("Select * from Tbl_Doktor", bgl.baglanti());
			da2.Fill(dt2);
			dataGridView1.DataSource = dt2;

			// Branşı Combobaxa aktarma
			SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Brans", bgl.baglanti());
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				cbBrans.Items.Add(dr2[0]);
			}
			bgl.baglanti().Close();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut1 = new SqlCommand("insert into Tbl_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
			komut1.Parameters.AddWithValue("@d1", txtAd.Text);
			komut1.Parameters.AddWithValue("@d2", txtSoyad.Text);
			komut1.Parameters.AddWithValue("@d3", cbBrans.Text);
			komut1.Parameters.AddWithValue("@d4", mskdTC.Text);
			komut1.Parameters.AddWithValue("@d5", txtSifre.Text);
		komut1.ExecuteNonQuery();
			bgl.baglanti().Close();
		MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Hand);
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			cbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			mskdTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Delete from Tbl_Doktor DoktorTC=@p1 ", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", mskdTC.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Doktor Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorTC=@p4,DoktorSifre=@p5", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", cbBrans.Text);
			komut.Parameters.AddWithValue("@p4", mskdTC.Text);
			komut.Parameters.AddWithValue("@p5", txtSifre.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
	}
}
