using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AppConfigDeleter.Forms;
using System.IO;
using System.Collections.Specialized;
using System.Net;
using System.Web;

namespace AppConfigDeleter
{
	public partial class MainForm : Form
	{
		OrderedDictionary od = new OrderedDictionary();
		string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		public MainForm()
		{
			InitializeComponent();
		}

		private void OpenConfigItem_Click(object sender, EventArgs e)
		{
			ConfigGetter cg = new ConfigGetter();
			if (cg.ShowDialog() != DialogResult.OK&&string.IsNullOrEmpty(cg.Dev)) return;
			string Auther = cg.Dev;
			Auther = Auther.Replace(' ', '_');
			if (Auther.Length > 25)
			{
				Auther=Auther.Remove(25);
			}
			string AutherPath = Path.Combine(LocalAppData, Auther);
			try
			{
				string[] ConfigPaths =
					Directory.GetFiles(
					AutherPath
					, "user.config", 
					SearchOption.AllDirectories);
				//辞書リセットと作成
				od.Clear();
				ConfigList.Items.Clear();
				foreach (string FullPath in ConfigPaths)
				{
					Uri LocalDataPath = new Uri(AutherPath),
						ConfigPath;
					DirectoryInfo di = Directory.GetParent(FullPath);
					ConfigPath = new Uri(di.ToString());
					string relatepath = HttpUtility.UrlDecode(
						LocalDataPath.MakeRelativeUri(ConfigPath).ToString()).Replace('/', '\\');
					od.Add(relatepath, FullPath);
					ConfigList.Items.Add(relatepath);
				}
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show("設定ファイルが見つからなかったよ。（´・ω・）",
					"ねぇよｗｗｗ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			catch (Exception b)
			{
				StringBuilder sb = new StringBuilder();
				sb.AppendLine("別の原因で処理が継続できないみたい。");
				sb.AppendLine("下に診断書みたいなの書いておくから自己解決できるなら自己解決を、出来ないなら開発者に問い合わせてね。");
				sb.AppendLine();
				sb.AppendLine(b.ToString());
				MessageBox.Show(sb.ToString(), "処理が継続不能", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DeleteItem_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("設定ファイルを削除するとアプリケーション設定が初期化されます。");
			sb.AppendLine("それでも行いますか？");
			if (MessageBox.Show(sb.ToString(), "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) !=
				DialogResult.Yes) return;
			string[] list = new string[ConfigList.CheckedItems.Count];
			ConfigList.CheckedItems.CopyTo(list, 0);
			foreach (string rpath in list)
			{
				string FullPath = (string)od[rpath], Dir = Path.GetDirectoryName(FullPath);
				if (File.Exists(FullPath))
				{
					Directory.Delete(Dir, true);
				}
				od.Remove(rpath);
				ConfigList.Items.Remove(rpath);
			}
			//フォルダが全部ない場合、親フォルダを消す
			foreach (string rpath in list)
			{
				string fullpath = Path.Combine(LocalAppData, rpath);
				DirectoryInfo di = Directory.GetParent(fullpath);
				if (di.Exists && di.GetFiles().Length == 0)
				{
					Directory.Delete(di.ToString());
				}
				//さらにその親フォルダから見て、ファイル及びフォルダが存在しなければそれも削除
				di = Directory.GetParent(di.ToString());
				if (di.Exists && di.GetDirectories().Length == 0 && di.GetFiles().Length == 0)
				{
					Directory.Delete(di.ToString());
				}
			}
		}
	}
}
