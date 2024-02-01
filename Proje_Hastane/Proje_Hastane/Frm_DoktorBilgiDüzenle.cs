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
	public partial class Frm_DoktorBilgiDüzenle : Form
	{
		public Frm_DoktorBilgiDüzenle()
		{
			InitializeComponent();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		SqlBağlantısı bgl = new SqlBağlantısı();
		public string TC;
		private void Frm_DoktorBilgiDüzenle_Load(object sender, EventArgs e)
		{
			maskedTextBox1.Text = TC;
			SqlCommand komut = new SqlCommand("Select * From Tbl_Doktor where DoktorTC=@p1" ,bgl.baglanti());
			komut.Parameters.AddWithValue("@p1",maskedTextBox1.Text);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				textBox2.Text = dr[1].ToString();
				textBox1.Text = dr[2].ToString();
				comboBox1.Text = dr[3].ToString();
				maskedTextBox2.Text = dr[5].ToString();

			}
			bgl.baglanti().Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1" , textBox2.Text);
			komut.Parameters.AddWithValue("@p2", textBox1.Text);

			komut.Parameters.AddWithValue("@p3", comboBox1.Text);

			komut.Parameters.AddWithValue("@p4", maskedTextBox1.Text);

			komut.Parameters.AddWithValue("@p5", maskedTextBox2.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Kayıt Güncellendi");
		}
	}
}
