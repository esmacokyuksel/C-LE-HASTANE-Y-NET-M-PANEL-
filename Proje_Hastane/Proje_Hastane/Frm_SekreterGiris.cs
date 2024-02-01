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
using System.Runtime.InteropServices.ComTypes;


namespace Proje_Hastane
{
	public partial class Frm_SekreterGiris : Form
	{
		public Frm_SekreterGiris()
		{
			InitializeComponent();
		}
		SqlBağlantısı bgl = new SqlBağlantısı();

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", mskdtc.Text);
			komut.Parameters.AddWithValue("@p2", txtsifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if (dr.Read())
			{
				Frm_SekreterDetay frs = new Frm_SekreterDetay();
				frs.TCnumara = mskdtc.Text;
				frs.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Hatalı TC && Şifre");
			}
			bgl.baglanti().Close();
		}
	}
}
