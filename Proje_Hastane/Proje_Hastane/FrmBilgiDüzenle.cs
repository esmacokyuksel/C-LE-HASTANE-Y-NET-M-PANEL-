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
	public partial class FrmBilgiDüzenle : Form
	{
		public FrmBilgiDüzenle()
		{
			InitializeComponent();
		}
		public string TCno;
		SqlBağlantısı bgl = new SqlBağlantısı();
		private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
		{
			tcmkd.Text = TCno;
			SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1",tcmkd.Text);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				txtad.Text = dr[1].ToString();
				txtsyd.Text = dr[2].ToString();
				mskdtel.Text = dr[4].ToString();
				MSKSİFRE.Text = dr[5].ToString();
				cbcinsiyet.Text = dr[6].ToString();
			}
			bgl.baglanti().Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglanti());
			komut2.Parameters.AddWithValue("@p1",txtad.Text);
			komut2.Parameters.AddWithValue("@p2", txtsyd.Text);
			komut2.Parameters.AddWithValue("@p3", mskdtel.Text);
			komut2.Parameters.AddWithValue("@p4", MSKSİFRE.Text); 
			komut2.Parameters.AddWithValue("@p5", cbcinsiyet.Text);
			komut2.Parameters.AddWithValue("@p6", tcmkd.Text);
			komut2.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);





		}
	}
}
