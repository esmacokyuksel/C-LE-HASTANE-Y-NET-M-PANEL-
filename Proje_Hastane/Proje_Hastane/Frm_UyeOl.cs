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
using System.Security.Cryptography;

namespace Proje_Hastane
{
	public partial class Frm_UyeOl : Form
	{
		public Frm_UyeOl()
		{
			InitializeComponent();
		}
		SqlBağlantısı bgl = new SqlBağlantısı();

		private void btnKayıtOl_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", mkdTc.Text);
			komut.Parameters.AddWithValue("@p4", mkdTel.Text);
			komut.Parameters.AddWithValue("@p5", mkdSifre.Text);
			komut.Parameters.AddWithValue("@p6", cbCinsiyet.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Kaydınız Gerçekleşmiştir  Şifreniz :"+mkdSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);






		}
	}
}
