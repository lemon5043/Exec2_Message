using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblResult.Text = string.Empty;
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
			lblResult.Text = $"It's {now}\r\n{Greet()}";
		}

		private string Greet()
		{
			int hour = DateTime.Now.Hour;

			if (hour > 5 && hour <= 11)
			{
				return "Good morning!";
			} else if (hour > 11 && hour <= 17)
			{
				return "Good afternoon!";
			}
			else
			{
				return "Good evening!";
			}
		} 
	}
}
