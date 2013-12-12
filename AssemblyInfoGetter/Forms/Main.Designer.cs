namespace AssemblyInfoGetter
{
	partial class MinForm
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
			this.DropPanel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// DropPanel
			// 
			this.DropPanel.AllowDrop = true;
			this.DropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DropPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DropPanel.Location = new System.Drawing.Point(0, 0);
			this.DropPanel.Name = "DropPanel";
			this.DropPanel.Size = new System.Drawing.Size(284, 263);
			this.DropPanel.TabIndex = 0;
			this.DropPanel.Text = "ここにファイルをドラッグアンドドロップして下さい。";
			this.DropPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragDrop);
			this.DropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropPanel_DragEnter);
			// 
			// MinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 263);
			this.Controls.Add(this.DropPanel);
			this.Name = "MinForm";
			this.Text = "AssemblyInfoGetter";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label DropPanel;
	}
}

