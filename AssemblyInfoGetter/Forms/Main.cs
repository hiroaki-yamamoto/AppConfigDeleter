using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace AssemblyInfoGetter
{
	public partial class MinForm : Form
	{
		public MinForm()
		{
			InitializeComponent();
		}

		private void DropPanel_DragDrop(object sender, DragEventArgs e)
		{
			string[] fnames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			Assembly[] fileAs = new Assembly[fnames.Length];
			for (int i = 0; i < fileAs.Length; i++)
			{
				fileAs[i] = Assembly.LoadFrom(fnames[i]);
			}
			foreach (Assembly file in fileAs)
			{
				object[] version = file.GetCustomAttributes(
					typeof(AssemblyFileVersionAttribute), false),
					company = file.GetCustomAttributes(
					typeof(AssemblyCompanyAttribute), false),
					buildCof = file.GetCustomAttributes(
					typeof(AssemblyConfigurationAttribute), false),
					Copyright = file.GetCustomAttributes(
					typeof(AssemblyCopyrightAttribute), false),
					Desc = file.GetCustomAttributes(
					typeof(AssemblyDescriptionAttribute), false);
				StringBuilder sb = new StringBuilder();
				sb.AppendLine("このファイルの名前：" + file.FullName);
				sb.AppendLine("ファイルバージョン：");
				foreach (object v in version)
				{
					AssemblyFileVersionAttribute ver =
						(AssemblyFileVersionAttribute)v;
					sb.AppendLine(ver.Version);
				}
				sb.AppendLine("著作権表示：");
				foreach (object c in Copyright)
				{
					AssemblyCopyrightAttribute co = (AssemblyCopyrightAttribute)c;
					sb.AppendLine(co.Copyright);
				}
				sb.AppendLine("ビルド構成：");
				foreach (object b in buildCof)
				{
					AssemblyConfigurationAttribute ac = (AssemblyConfigurationAttribute)b;
					sb.AppendLine(ac.Configuration);
				}
				sb.AppendLine("作成元：");
				foreach (object cp in company)
				{
					AssemblyCompanyAttribute aca = (AssemblyCompanyAttribute)cp;
					sb.AppendLine(aca.Company);
				}
				sb.AppendLine("説明：");
				foreach (object desc in Desc)
				{
					AssemblyDescriptionAttribute ad = (AssemblyDescriptionAttribute)desc;
					sb.AppendLine(ad.Description);
				}
				
				MessageBox.Show(sb.ToString(), "情報", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}

		private void DropPanel_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
	}
}
