namespace Alison
{
	partial class FrmMain
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
			this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.バージョンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ツールToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(640, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 433);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(640, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// objectListView1
			// 
			this.objectListView1.CellEditUseWholeCell = false;
			this.objectListView1.Location = new System.Drawing.Point(12, 27);
			this.objectListView1.Name = "objectListView1";
			this.objectListView1.Size = new System.Drawing.Size(616, 403);
			this.objectListView1.TabIndex = 3;
			this.objectListView1.UseCompatibleStateImageBehavior = false;
			this.objectListView1.View = System.Windows.Forms.View.Details;
			// 
			// ファイルToolStripMenuItem
			// 
			this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了ToolStripMenuItem});
			this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
			this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ファイルToolStripMenuItem.Text = "ファイル";
			// 
			// ツールToolStripMenuItem
			// 
			this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
			this.ツールToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.ツールToolStripMenuItem.Text = "ツール";
			// 
			// ヘルプToolStripMenuItem
			// 
			this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョンToolStripMenuItem});
			this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
			this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.ヘルプToolStripMenuItem.Text = "ヘルプ";
			// 
			// バージョンToolStripMenuItem
			// 
			this.バージョンToolStripMenuItem.Name = "バージョンToolStripMenuItem";
			this.バージョンToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.バージョンToolStripMenuItem.Text = "バージョン";
			// 
			// 終了ToolStripMenuItem
			// 
			this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
			this.終了ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.終了ToolStripMenuItem.Text = "終了";
			// 
			// 設定ToolStripMenuItem
			// 
			this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
			this.設定ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.設定ToolStripMenuItem.Text = "設定";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 455);
			this.Controls.Add(this.objectListView1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alison";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem バージョンToolStripMenuItem;
		private BrightIdeasSoftware.ObjectListView objectListView1;
		private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

