using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FtpDawoon
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string start = "ftp://speedtest.tele2.net/1KB.zip"; // 다운 받을 주소
			string end = "1kb.zip";                             // 다운 받은 주소

			string user = "aa";
			string pwd = "bb";

			using (WebClient client = new WebClient())
			{
				client.Credentials = new NetworkCredential(user, pwd);
				client.DownloadFile(start, end);
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}
	}
}
