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
using System.Data.SqlClient;


namespace Proje_Hastane
{
	public partial class Frm_DoktorDetay : Form
	{
		public Frm_DoktorDetay()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
		public string TC;
		SqlBağlantısı bgl = new SqlBağlantısı();
		private void Frm_DoktorDetay_Load(object sender, EventArgs e)
		{
			tctTc.Text = TC;
			//Ad Soyad
			SqlCommand komut1 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorTC=@p1 ", bgl.baglanti());
			komut1.Parameters.AddWithValue("@p1", tctTc.Text);
			SqlDataReader dr1 = komut1.ExecuteReader();
			while (dr1.Read())
			{
				lblad.Text = dr1[0].ToString();
				lblsoyad.Text = dr1[1].ToString();
			}
			bgl.baglanti().Close();

			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + lblad.Text + "'", bgl.baglanti());
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Frm_DoktorBilgiDüzenle fr = new Frm_DoktorBilgiDüzenle();
			fr.TC = tctTc.Text;
			fr.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Frm_Duyurular fr = new Frm_Duyurular();
			fr.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			richTextBox3.Text = dataGridView1.Rows[secilen].Cells[7].ToString();
		}
	}
}
