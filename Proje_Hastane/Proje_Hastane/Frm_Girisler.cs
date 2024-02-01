using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
	public partial class Frm_Girisler : Form
	{
		public Frm_Girisler()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Frm_DoktorGiris fr = new Frm_DoktorGiris();
			fr.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Frm_HastaGiris fr = new Frm_HastaGiris();
			fr.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Frm_SekreterGiris fr = new Frm_SekreterGiris();
			fr.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
