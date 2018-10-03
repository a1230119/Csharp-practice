namespace Practice_11._1___Menustrip
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.read = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.字體ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellow = new System.Windows.Forms.ToolStripMenuItem();
            this.green = new System.Windows.Forms.ToolStripMenuItem();
            this.red = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.字體ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clear,
            this.save,
            this.read,
            this.exit});
            this.檔案ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.檔案ToolStripMenuItem.Text = "檔案(F)";
            // 
            // clear
            // 
            this.clear.Image = global::Practice_11._1___Menustrip.Properties.Resources.icon1;
            this.clear.Name = "clear";
            this.clear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.clear.Size = new System.Drawing.Size(251, 30);
            this.clear.Text = "清空(N)";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.Image = global::Practice_11._1___Menustrip.Properties.Resources.icon2;
            this.save.Name = "save";
            this.save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save.Size = new System.Drawing.Size(251, 30);
            this.save.Text = "儲存(S)";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // read
            // 
            this.read.Image = global::Practice_11._1___Menustrip.Properties.Resources.icon3;
            this.read.Name = "read";
            this.read.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.read.Size = new System.Drawing.Size(251, 30);
            this.read.Text = "讀取檔案";
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exit.Size = new System.Drawing.Size(251, 30);
            this.exit.Text = "結束(X)";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // 字體ToolStripMenuItem
            // 
            this.字體ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大小ToolStripMenuItem,
            this.顏色ToolStripMenuItem});
            this.字體ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.字體ToolStripMenuItem.Name = "字體ToolStripMenuItem";
            this.字體ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.字體ToolStripMenuItem.Text = "字體";
            // 
            // 大小ToolStripMenuItem
            // 
            this.大小ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.大小ToolStripMenuItem.Name = "大小ToolStripMenuItem";
            this.大小ToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.大小ToolStripMenuItem.Text = "大小";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 30);
            this.toolStripMenuItem2.Text = "10";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(120, 30);
            this.toolStripMenuItem3.Text = "20";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(120, 30);
            this.toolStripMenuItem4.Text = "30";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yellow,
            this.green,
            this.red});
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(136, 30);
            this.顏色ToolStripMenuItem.Text = "顏色";
            // 
            // yellow
            // 
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(116, 30);
            this.yellow.Text = "黃";
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // green
            // 
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(116, 30);
            this.green.Text = "綠";
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // red
            // 
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(116, 30);
            this.red.Text = "紅";
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 476);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 513);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem read;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem 字體ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellow;
        private System.Windows.Forms.ToolStripMenuItem green;
        private System.Windows.Forms.ToolStripMenuItem red;
        private System.Windows.Forms.TextBox textBox1;
    }
}

