﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
	 class SqlBağlantısı
	{
		public SqlConnection baglanti()
		{
			SqlConnection baglan = new SqlConnection("Data Source=MYCOMPUTER\\ESMAASQL;Initial Catalog=HastaneProjesi;Integrated Security=True");
			baglan.Open();
			return baglan;
		}
	}
}
