using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppConfigDeleter.Forms
{
	public partial class ConfigGetter : Form
	{
		public ConfigGetter()
		{
			InitializeComponent();
		}
		public string Dev
		{
			get { return Auther.Text; }
			set { Auther.Text = value; }
		}
	}
}
