namespace AppConfigDeleter.Forms
{
	partial class ConfigGetter
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Description = new System.Windows.Forms.Label();
			this.Auther = new System.Windows.Forms.TextBox();
			this.OKBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Description
			// 
			this.Description.AutoSize = true;
			this.Description.Location = new System.Drawing.Point(13, 13);
			this.Description.Name = "Description";
			this.Description.Size = new System.Drawing.Size(305, 48);
			this.Description.TabIndex = 0;
			this.Description.Text = "設定を削除するソフトウェアの作成会社の名前を入れてください。\r\n通常はソフトウェアのバージョン情報に記述されています。\r\nが、ソフトウェアのアセンブリから作成元が" +
				"判別できる場合は、\r\n多分アセンブリ側の方が正確です。(笑）";
			// 
			// Auther
			// 
			this.Auther.Location = new System.Drawing.Point(15, 65);
			this.Auther.MaxLength = 10240;
			this.Auther.Name = "Auther";
			this.Auther.Size = new System.Drawing.Size(297, 19);
			this.Auther.TabIndex = 1;
			// 
			// OKBtn
			// 
			this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKBtn.Location = new System.Drawing.Point(236, 91);
			this.OKBtn.Name = "OKBtn";
			this.OKBtn.Size = new System.Drawing.Size(75, 23);
			this.OKBtn.TabIndex = 2;
			this.OKBtn.Text = "OK";
			this.OKBtn.UseVisualStyleBackColor = true;
			// 
			// CancelBtn
			// 
			this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new System.Drawing.Point(155, 90);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 3;
			this.CancelBtn.Text = "キャンセル";
			this.CancelBtn.UseVisualStyleBackColor = true;
			// 
			// ConfigGetter
			// 
			this.AcceptButton = this.OKBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.OKBtn;
			this.ClientSize = new System.Drawing.Size(324, 123);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.OKBtn);
			this.Controls.Add(this.Auther);
			this.Controls.Add(this.Description);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfigGetter";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "設定ファイルの取得";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Description;
		private System.Windows.Forms.TextBox Auther;
		private System.Windows.Forms.Button OKBtn;
		private System.Windows.Forms.Button CancelBtn;
	}
}