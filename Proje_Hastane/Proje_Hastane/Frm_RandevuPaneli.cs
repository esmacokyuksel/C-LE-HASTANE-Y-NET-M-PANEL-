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
	public partial class Frm_RandevuPaneli : Form
	{
		public Frm_RandevuPaneli()
		{
			InitializeComponent();
		}
		SqlBağlantısı bgl = new SqlBağlantısı();

		private void Frm_RandevuPaneli_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular",bgl.baglanti());
			da.Fill(dt);
			dataGridView2.DataSource = dt;
		}
		private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
