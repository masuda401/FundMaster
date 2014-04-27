namespace FundMaster
{
    partial class Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.投信管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.国内投信ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銘柄情報登録ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銘柄情報一覧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.マスタ管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.手数料マスタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.委託会社マスタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.振込先マスタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.銀行マスタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支店マスタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.投信管理ToolStripMenuItem,
            this.マスタ管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 投信管理ToolStripMenuItem
            // 
            this.投信管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.国内投信ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.投信管理ToolStripMenuItem.Name = "投信管理ToolStripMenuItem";
            this.投信管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.投信管理ToolStripMenuItem.Text = "業務";
            // 
            // 国内投信ToolStripMenuItem
            // 
            this.国内投信ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.銘柄情報登録ToolStripMenuItem,
            this.銘柄情報一覧ToolStripMenuItem});
            this.国内投信ToolStripMenuItem.Name = "国内投信ToolStripMenuItem";
            this.国内投信ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.国内投信ToolStripMenuItem.Text = "国内投信";
            // 
            // 銘柄情報登録ToolStripMenuItem
            // 
            this.銘柄情報登録ToolStripMenuItem.Name = "銘柄情報登録ToolStripMenuItem";
            this.銘柄情報登録ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.銘柄情報登録ToolStripMenuItem.Text = "銘柄情報登録";
            this.銘柄情報登録ToolStripMenuItem.Click += new System.EventHandler(this.銘柄情報登録ToolStripMenuItem_Click);
            // 
            // 銘柄情報一覧ToolStripMenuItem
            // 
            this.銘柄情報一覧ToolStripMenuItem.Name = "銘柄情報一覧ToolStripMenuItem";
            this.銘柄情報一覧ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.銘柄情報一覧ToolStripMenuItem.Text = "銘柄情報一覧";
            this.銘柄情報一覧ToolStripMenuItem.Click += new System.EventHandler(this.銘柄情報一覧ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // マスタ管理ToolStripMenuItem
            // 
            this.マスタ管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.手数料マスタToolStripMenuItem,
            this.委託会社マスタToolStripMenuItem,
            this.振込先マスタToolStripMenuItem,
            this.銀行マスタToolStripMenuItem,
            this.支店マスタToolStripMenuItem});
            this.マスタ管理ToolStripMenuItem.Name = "マスタ管理ToolStripMenuItem";
            this.マスタ管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.マスタ管理ToolStripMenuItem.Text = "システム管理";
            // 
            // 手数料マスタToolStripMenuItem
            // 
            this.手数料マスタToolStripMenuItem.Name = "手数料マスタToolStripMenuItem";
            this.手数料マスタToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.手数料マスタToolStripMenuItem.Text = "手数料マスタ";
            // 
            // 委託会社マスタToolStripMenuItem
            // 
            this.委託会社マスタToolStripMenuItem.Name = "委託会社マスタToolStripMenuItem";
            this.委託会社マスタToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.委託会社マスタToolStripMenuItem.Text = "委託会社マスタ";
            // 
            // 振込先マスタToolStripMenuItem
            // 
            this.振込先マスタToolStripMenuItem.Name = "振込先マスタToolStripMenuItem";
            this.振込先マスタToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.振込先マスタToolStripMenuItem.Text = "振込先マスタ";
            // 
            // 銀行マスタToolStripMenuItem
            // 
            this.銀行マスタToolStripMenuItem.Name = "銀行マスタToolStripMenuItem";
            this.銀行マスタToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.銀行マスタToolStripMenuItem.Text = "銀行マスタ";
            // 
            // 支店マスタToolStripMenuItem
            // 
            this.支店マスタToolStripMenuItem.Name = "支店マスタToolStripMenuItem";
            this.支店マスタToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.支店マスタToolStripMenuItem.Text = "支店マスタ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "メニュー";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 投信管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 国内投信ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem マスタ管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手数料マスタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 委託会社マスタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 振込先マスタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銀行マスタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支店マスタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銘柄情報登録ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 銘柄情報一覧ToolStripMenuItem;

    }
}

