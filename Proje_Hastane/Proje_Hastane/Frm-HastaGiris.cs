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
	public partial class Frm_HastaGiris : Form
	{
		public Frm_HastaGiris()
		{
			InitializeComponent();
		}
		SqlBağlantısı bgl = new SqlBağlantısı();

		private void button1_Click(object sender, EventArgs e)
		{
			
			SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", mkdTc.Text);
			komut.Parameters.AddWithValue("@p2", mkdSifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if(dr.Read())
			{
				Frm_HastaDetay fr = new Frm_HastaDetay();
				fr.tc = mkdTc.Text;
				fr.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Hatalı TC & ŞİFRE");
			}
			bgl.baglanti().Close();
		}

		private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Frm_UyeOl fr = new Frm_UyeOl();
			fr.Show();
		}
	}
}
