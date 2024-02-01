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
	public partial class Frm_BransPaneli : Form
	{
		public Frm_BransPaneli()
		{
			InitializeComponent();
		}
		SqlBağlantısı bgl = new SqlBağlantısı();

		private void Frm_BransPaneli_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Brans",bgl.baglanti());
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into Tbl_Brans (BransAd) values (@b1) ", bgl.baglanti());
			komut.Parameters.AddWithValue("@b1" ,txtBrans.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Branş Eklendi ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			txtBrans.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{

			SqlCommand komut = new SqlCommand("Delete from Tbl_Brans Bransid=@b1 ", bgl.baglanti());
			komut.Parameters.AddWithValue("@b1", txtid.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Branş Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

		}

		private void button3_Click(object sender, EventArgs e)
		{

			SqlCommand komut = new SqlCommand("Update  Tbl_Brans set BransAd=@p1 wwhere Bransid=@p2 ", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtBrans.Text);
			komut.Parameters.AddWithValue("@p1", txtid.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Branş Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

		}
	}
}
