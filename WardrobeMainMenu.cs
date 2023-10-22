using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ofinger
{
	public partial class WardrobeMainMenu : UserControl
	{
		Database db;
		public WardrobeMainMenu()
		{
			InitializeComponent();
			db = new Database();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			this.Hide();
			db.OpenConnection();
			db.GetConnection();
			db.CloseConnection();
		}
	}
}
