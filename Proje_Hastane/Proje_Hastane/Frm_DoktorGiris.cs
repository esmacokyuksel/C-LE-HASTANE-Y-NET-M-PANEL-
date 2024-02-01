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
	public partial class Frm_DoktorGiris : Form
	{
		public Frm_DoktorGiris()
		{
			InitializeComponent();
		}
		SqlBağlantısı bgl = new SqlBağlantısı();

		private void btnGiris_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Select * From Tbl_Doktor Where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", mskdTC.Text);
			komut.Parameters.AddWithValue("@p2", txtSifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if (dr.Read())
			{
				Frm_DoktorDetay fr = new Frm_DoktorDetay();
				fr.TC = mskdTC.Text;
				fr.Show();
				this.Hide();
			} 
			else
			{
				MessageBox.Show("Hatalı TC & ŞİFRE");
			}
			bgl.baglanti().Close();
		}
	}
}
