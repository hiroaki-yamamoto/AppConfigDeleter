namespace AppConfigDeleter
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MenuTools = new System.Windows.Forms.ToolStrip();
			this.OpenConfigItem = new System.Windows.Forms.ToolStripButton();
			this.DeleteItem = new System.Windows.Forms.ToolStripButton();
			this.StatusMenu = new System.Windows.Forms.StatusStrip();
			this.ReadyLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ConfigList = new System.Windows.Forms.CheckedListBox();
			this.MenuTools.SuspendLayout();
			this.StatusMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuTools
			// 
			this.MenuTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenConfigItem,
            this.DeleteItem});
			this.MenuTools.Location = new System.Drawing.Point(0, 0);
			this.MenuTools.Name = "MenuTools";
			this.MenuTools.Size = new System.Drawing.Size(464, 25);
			this.MenuTools.TabIndex = 0;
			this.MenuTools.Text = "MainTools";
			// 
			// OpenConfigItem
			// 
			this.OpenConfigItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenConfigItem.Image")));
			this.OpenConfigItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenConfigItem.Name = "OpenConfigItem";
			this.OpenConfigItem.Size = new System.Drawing.Size(136, 22);
			this.OpenConfigItem.Text = "設定フォルダを開く";
			this.OpenConfigItem.Click += new System.EventHandler(this.OpenConfigItem_Click);
			// 
			// DeleteItem
			// 
			this.DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteItem.Image")));
			this.DeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteItem.Name = "DeleteItem";
			this.DeleteItem.Size = new System.Drawing.Size(88, 22);
			this.DeleteItem.Text = "設定の削除";
			this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
			// 
			// StatusMenu
			// 
			this.StatusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadyLabel});
			this.StatusMenu.Location = new System.Drawing.Point(0, 260);
			this.StatusMenu.Name = "StatusMenu";
			this.StatusMenu.Size = new System.Drawing.Size(464, 23);
			this.StatusMenu.TabIndex = 1;
			this.StatusMenu.Text = "statusStrip1";
			// 
			// ReadyLabel
			// 
			this.ReadyLabel.Name = "ReadyLabel";
			this.ReadyLabel.Size = new System.Drawing.Size(44, 18);
			this.ReadyLabel.Text = "Ready";
			// 
			// ConfigList
			// 
			this.ConfigList.CheckOnClick = true;
			this.ConfigList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConfigList.FormattingEnabled = true;
			this.ConfigList.Location = new System.Drawing.Point(0, 25);
			this.ConfigList.Name = "ConfigList";
			this.ConfigList.Size = new System.Drawing.Size(464, 228);
			this.ConfigList.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 283);
			this.Controls.Add(this.ConfigList);
			this.Controls.Add(this.StatusMenu);
			this.Controls.Add(this.MenuTools);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "ApplicationDeleter";
			this.MenuTools.ResumeLayout(false);
			this.MenuTools.PerformLayout();
			this.StatusMenu.ResumeLayout(false);
			this.StatusMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip MenuTools;
		private System.Windows.Forms.ToolStripButton OpenConfigItem;
		private System.Windows.Forms.ToolStripButton DeleteItem;
		private System.Windows.Forms.StatusStrip StatusMenu;
		private System.Windows.Forms.ToolStripStatusLabel ReadyLabel;
		private System.Windows.Forms.CheckedListBox ConfigList;

	}
}

