namespace RussianRoulette
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siri = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ゲームGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.リセットRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.チートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ライフ1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ショット数変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ゲットマネー変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.トータルマネー変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.その他OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ハイスコアHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ハイスコアリセットLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.遊び方UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.残酷表現ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画面をきれいにするToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.siri)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siri
            // 
            this.siri.BackColor = System.Drawing.Color.Transparent;
            this.siri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siri.BackgroundImage")));
            this.siri.Location = new System.Drawing.Point(345, 297);
            this.siri.Name = "siri";
            this.siri.Size = new System.Drawing.Size(170, 170);
            this.siri.TabIndex = 0;
            this.siri.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "トリガー";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 611);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "シリンダー";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 611);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "エアショット";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 611);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "フォールド";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ゲームGToolStripMenuItem,
            this.その他OToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 26);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ゲームGToolStripMenuItem
            // 
            this.ゲームGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.リセットRToolStripMenuItem,
            this.終了XToolStripMenuItem,
            this.toolStripSeparator2,
            this.チートToolStripMenuItem});
            this.ゲームGToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.ゲームGToolStripMenuItem.Name = "ゲームGToolStripMenuItem";
            this.ゲームGToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.ゲームGToolStripMenuItem.Text = "ゲーム(&G)";
            // 
            // リセットRToolStripMenuItem
            // 
            this.リセットRToolStripMenuItem.Name = "リセットRToolStripMenuItem";
            this.リセットRToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.リセットRToolStripMenuItem.Text = "リセット(&R)";
            this.リセットRToolStripMenuItem.Click += new System.EventHandler(this.リセットRToolStripMenuItem_Click);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // チートToolStripMenuItem
            // 
            this.チートToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ライフ1ToolStripMenuItem,
            this.ショット数変更ToolStripMenuItem,
            this.ゲットマネー変更ToolStripMenuItem,
            this.トータルマネー変更ToolStripMenuItem});
            this.チートToolStripMenuItem.Name = "チートToolStripMenuItem";
            this.チートToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.チートToolStripMenuItem.Text = "チート(&T)";
            // 
            // ライフ1ToolStripMenuItem
            // 
            this.ライフ1ToolStripMenuItem.Name = "ライフ1ToolStripMenuItem";
            this.ライフ1ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ライフ1ToolStripMenuItem.Text = "ライフ変更";
            this.ライフ1ToolStripMenuItem.Click += new System.EventHandler(this.ライフ1ToolStripMenuItem_Click);
            // 
            // ショット数変更ToolStripMenuItem
            // 
            this.ショット数変更ToolStripMenuItem.Name = "ショット数変更ToolStripMenuItem";
            this.ショット数変更ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ショット数変更ToolStripMenuItem.Text = "ショット数変更";
            this.ショット数変更ToolStripMenuItem.Click += new System.EventHandler(this.ショット数変更ToolStripMenuItem_Click);
            // 
            // ゲットマネー変更ToolStripMenuItem
            // 
            this.ゲットマネー変更ToolStripMenuItem.Name = "ゲットマネー変更ToolStripMenuItem";
            this.ゲットマネー変更ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ゲットマネー変更ToolStripMenuItem.Text = "ゲットマネー変更";
            this.ゲットマネー変更ToolStripMenuItem.Click += new System.EventHandler(this.ゲットマネー変更ToolStripMenuItem_Click);
            // 
            // トータルマネー変更ToolStripMenuItem
            // 
            this.トータルマネー変更ToolStripMenuItem.Name = "トータルマネー変更ToolStripMenuItem";
            this.トータルマネー変更ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.トータルマネー変更ToolStripMenuItem.Text = "トータルマネー変更";
            this.トータルマネー変更ToolStripMenuItem.Click += new System.EventHandler(this.トータルマネー変更ToolStripMenuItem_Click);
            // 
            // その他OToolStripMenuItem
            // 
            this.その他OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ハイスコアHToolStripMenuItem,
            this.ハイスコアリセットLToolStripMenuItem,
            this.toolStripSeparator1,
            this.遊び方UToolStripMenuItem,
            this.オプションOToolStripMenuItem});
            this.その他OToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.その他OToolStripMenuItem.Name = "その他OToolStripMenuItem";
            this.その他OToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.その他OToolStripMenuItem.Text = "その他(&O)";
            // 
            // ハイスコアHToolStripMenuItem
            // 
            this.ハイスコアHToolStripMenuItem.Name = "ハイスコアHToolStripMenuItem";
            this.ハイスコアHToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ハイスコアHToolStripMenuItem.Text = "ハイスコア(&H)";
            this.ハイスコアHToolStripMenuItem.Click += new System.EventHandler(this.ハイスコアHToolStripMenuItem_Click);
            // 
            // ハイスコアリセットLToolStripMenuItem
            // 
            this.ハイスコアリセットLToolStripMenuItem.Name = "ハイスコアリセットLToolStripMenuItem";
            this.ハイスコアリセットLToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ハイスコアリセットLToolStripMenuItem.Text = "ハイスコアリセット(&L)";
            this.ハイスコアリセットLToolStripMenuItem.Click += new System.EventHandler(this.ハイスコアリセットLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // 遊び方UToolStripMenuItem
            // 
            this.遊び方UToolStripMenuItem.Name = "遊び方UToolStripMenuItem";
            this.遊び方UToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.遊び方UToolStripMenuItem.Text = "遊び方(&U)";
            this.遊び方UToolStripMenuItem.Click += new System.EventHandler(this.遊び方UToolStripMenuItem_Click);
            // 
            // オプションOToolStripMenuItem
            // 
            this.オプションOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.残酷表現ToolStripMenuItem,
            this.画面をきれいにするToolStripMenuItem});
            this.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            this.オプションOToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.オプションOToolStripMenuItem.Text = "オプション(&O)";
            // 
            // 残酷表現ToolStripMenuItem
            // 
            this.残酷表現ToolStripMenuItem.Name = "残酷表現ToolStripMenuItem";
            this.残酷表現ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.残酷表現ToolStripMenuItem.Text = "残酷表現(オン)";
            this.残酷表現ToolStripMenuItem.Click += new System.EventHandler(this.残酷表現ToolStripMenuItem_Click);
            // 
            // 画面をきれいにするToolStripMenuItem
            // 
            this.画面をきれいにするToolStripMenuItem.Name = "画面をきれいにするToolStripMenuItem";
            this.画面をきれいにするToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.画面をきれいにするToolStripMenuItem.Text = "画面をきれいにする";
            this.画面をきれいにするToolStripMenuItem.Click += new System.EventHandler(this.画面をきれいにするToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(23, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 60);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(23, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 60);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(518, 762);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(397, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 60);
            this.label4.TabIndex = 10;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(92, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 259);
            this.label5.TabIndex = 11;
            this.label5.Text = "BANG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "ピクチャボックス\t\t\t\t\t1",
            "メインメニュー\t\t\t\t\t11",
            "ユーザーフォームの追加\t\t\t\t3",
            "授業で学習してないコントロール(タブコントロール)\t4",
            "授業で学習してないコントロール(プログレスバー)\t\t4",
            "授業で学習してないコントロール(セパレータ)\t\t4",
            "",
            "",
            "プログラムからのプロパティの変更\t\t\t1",
            "",
            "サイコロ以外にしたい\t\t\t\t5",
            "",
            "計\t\t\t\t\t\t33"});
            this.listBox1.Location = new System.Drawing.Point(12, 668);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(485, 88);
            this.listBox1.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 26);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 737);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(31, 600);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(438, 10);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(518, 763);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.siri);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RussianRoulette";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siri)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox siri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ゲームGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem その他OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem リセットRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ハイスコアHToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 遊び方UToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem チートToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ライフ1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ショット数変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ゲットマネー変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem トータルマネー変更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ハイスコアリセットLToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 残酷表現ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画面をきれいにするToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

