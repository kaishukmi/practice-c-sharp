using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        bool movie          = false;
        int moviecount      = 0;
        int nextmoney       = 10;
        int getmoney        = 0;
        int totalmoney      = 0;
        int life            = 10;
        int nowshot         = 0;
        int totalshot       = 0;
        int highscore       = 0;
        private Random rnd = new Random();
        Bitmap canvas;                  //描画空間
        private int[] bbloodleft = new int[10];         //でかい血
        private int[] bbloodtop = new int[10];
        private int[] bbloodsize = new int[10];
        private int[] lbloodleft = new int[20];         //小さい血
        private int[] lbloodtop = new int[20];
        private int[] lbloodsize = new int[20];
        private double[] usercos = new double[360];     //コサインの計算軽量化
        private double[] usersin = new double[360];     //サインの計算軽量化

        string CurrentDir = Environment.CurrentDirectory;
            private System.Drawing.Text.PrivateFontCollection fontCollection
        = new System.Drawing.Text.PrivateFontCollection();
        private Font displayFont;
        private void SetPrivateFont()
        {
            string fontPath = CurrentDir + "/CARACURA.ttf";
            fontCollection.AddFontFile(fontPath);
            FontFamily addedFont = null;
            foreach (FontFamily ff in fontCollection.Families)
            {
                if (ff.Name == "Caracura")
                {
                    addedFont = ff;
                    break;
                }
            }
            if(addedFont == null)
            {
                return;
            }
            displayFont = new Font(addedFont,
                           label1.Font.Size,
                           FontStyle.Regular,
                           label1.Font.Unit);
            label1.Font = displayFont;
            label2.Font = displayFont;
            label3.Font = displayFont;
            displayFont = new Font(addedFont,
                           label5.Font.Size,
                           FontStyle.Regular,
                           label5.Font.Unit);
            label5.Font = displayFont;

        }

        public Form1()
        {
            InitializeComponent();
            SetPrivateFont();
        }

        private void button1_Click(object sender, EventArgs e)//トリガー
        {
            if (!movie)
            {
                if (rnd.Next(6 - nowshot) == 0)
                {
                    blood();
                    movie = true;
                    moviecount = 0;
                    life = life - 1;
                    totalmoney += getmoney / 2;
                    getmoney = 0;
                    nowshot = 0;
                    totalshot = 0;
                    nextmoney = 10;
                }
                else
                {
                    getmoney += nextmoney;
                    nowshot++;
                    totalshot++;
                    nextmoney = 10 * totalshot * (nowshot + 1);
                }
                disp();
            }
        }

        private void button2_Click(object sender, EventArgs e)//シリンダー
        {
            if (!movie)
            {
                nowshot = 0;
                nextmoney = 10 * totalshot * (nowshot + 1);
                disp();
            }
        }

        private void button3_Click(object sender, EventArgs e)//外れたら死亡 弾が出たら6倍の金額をもらってゲームから降りる
        {
            if (!movie)
            {
                if (rnd.Next(6 - nowshot) == 0)
                {
                    life = life - 1;
                    totalmoney += getmoney / 2;
                    getmoney = 0;
                    nowshot = 0;
                    totalshot = 0;
                    nextmoney = 10;
                    if (life == 0) end();
                }
                else
                {
                    life = life - 1;
                    totalmoney += getmoney * 6;
                    getmoney = 0;
                    nowshot = 0;
                    totalshot = 0;
                    nextmoney = 10;
                    if (life == 0) end();
                }
                disp();
            }
        }

        private void button4_Click(object sender, EventArgs e)//ゲームを降りる
        {
            if(!movie){
            life = life - 1;
            totalmoney += getmoney;
            getmoney = 0;
            nowshot = 0;
            totalshot = 0;
            nextmoney = 10;
            if (life == 0) end();
            disp();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(pictureBox2.Width,pictureBox2.Height);
            for (int i = 0; i < 360; i++)
            {
                usercos[i] = Math.Cos(i);
                usersin[i] = Math.Sin(i);
            }
            label5.Parent = pictureBox2;
            finit();
            init();
            if (MessageBox.Show("このゲームをプレイするのは初めてですか？", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //MessageBox.Show("[はい] ボタンを選択しました");
                Form2 f = new Form2();
                f.ShowDialog(this);
                f.Dispose();
            }
            else
            {
                MessageBox.Show("お帰りなさいませ！");
            }

        }

        private void blood()
        {

        }

        private void end()
        {
            MessageBox.Show("あなたが稼いだ金額は"+ totalmoney +"＄でした");
            if (highscore < totalmoney)
            {
                MessageBox.Show("ハイスコアです！おめでとう");
                highscore = totalmoney;
            }
            else
            {
                MessageBox.Show("ハイスコアは" + highscore + "＄です。次はがんばってください");
            }
            init();
        }

        private void disp()
        {
            this.Text = "Shot " + totalshot.ToString();
            label1.Text = nextmoney.ToString();
            label2.Text = getmoney.ToString();
            label3.Text = totalmoney.ToString();
            label4.Text = life.ToString();
            string filename1 = CurrentDir + "/siri/" + nowshot + ".png";
            Bitmap back = new Bitmap(filename1);
            siri.BackgroundImage = back;
            if(life < 11) progressBar1.Value = life;
            /*switch(nowshot)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }*/
        }

        private void finit()
        {
            /*label1.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;
            button1.Parent = pictureBox2;
            button2.Parent = pictureBox2;
            button3.Parent = pictureBox2;
            button4.Parent = pictureBox2;*/
        }

        private void init()
        {
            this.MaximizeBox = false;

            pictureBox2.Visible = false;
            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, canvas.Width, canvas.Height);
            pictureBox2.Image = canvas;
            g.Dispose();
            label5.Visible = false;

            movie = false;
            moviecount = 0;
            nextmoney = 10;
            getmoney = 0;
            totalmoney = 0;
            life = 10;
            nowshot = 0;
            totalshot = 0;

            disp();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (movie)
            {
                Graphics g = Graphics.FromImage(canvas);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                if (残酷表現ToolStripMenuItem.Text == "残酷表現(オフ)") moviecount = 99;
                if (moviecount == 0)
                {
                    pictureBox2.Visible = true;
                    //label5.Visible = true;
                    spritink(2, canvas.Width / 2, canvas.Height / 2, 50, Color.FromArgb(255, 255/* - (life * 20)*/, 0, 0));
                }
                else if(moviecount > 40)
                {
                    label5.Visible = true;
                    for (int i = 0; i < 10; i++)
                    {
                        bbloodtop[i] += 1;
                        g.FillEllipse(new SolidBrush(Color.FromArgb(255,255/*-(life*20)*/,0,0)), bbloodleft[i] - bbloodsize[i], bbloodtop[i] - bbloodsize[i], bbloodsize[i] * 2, bbloodsize[i] * 2);
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        lbloodtop[i] += 1;
                        g.FillEllipse(new SolidBrush(Color.FromArgb(255, 255/* - (life * 20)*/, 0, 0)), lbloodleft[i] - lbloodsize[i], lbloodtop[i] - lbloodsize[i], lbloodsize[i] * 2, lbloodsize[i] * 2);
                    }
                }
                moviecount++;
                if (moviecount == 100)//150にしとけ
                {
                    movie = false;
                    moviecount = 0;
                    g.FillRectangle(new SolidBrush(Color.FromArgb(100,0,0,0)), 0, 0,canvas.Width,canvas.Height);
                    pictureBox2.Visible = false;
                    pictureBox2.Image = null;
                    //canvas = null;
                    label5.Visible = false;
                    if (life == 0) end();
                }
                pictureBox2.Image = canvas;//描画
                g.Dispose();
            }
        }
        private void spritink(byte mode, int icx, int icy, int irad, Color spritcolor)//インクがはねたような視覚効果を出す関数　かなり乱雑...
        //引数の解説 左から モード(0で座標とサイズのみランダム{この場合他の変数は0で入力する},1でサイズのみ指定でほかはランダム,2で座標とサイズ指定),中心円の中心点のx座標,y座標,中心円の半径,
        {
            Graphics g = Graphics.FromImage(canvas);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Color ccolor;       //中心円の色　モード1の場合飛沫の色もコレになる
            int ccx;            //中心円のx座標 モード0-1で使用
            int ccy;            //中心円のy座標 モード0-1で使用
            int centersize;     //中心円の半径  モード0-1で使用
            int lrad;           //飛沫の中心を中心点から見た半径
            double lang;        //飛沫を中心点から見た角度
            int lsize;          //飛沫の半径
            int lcx;            //飛沫の中心のx座標
            int lcy;            //飛沫の中心のy座標
            switch (mode)
            {
                case 0:
                    ccolor = spritcolor;
                    ccx = rnd.Next(1001);
                    ccy = rnd.Next(701);
                    centersize = rnd.Next(100) + 25;//ここは引数を使って新しいモードを作ってもいいかもしれない... とりあえず汎用性を考えていない
                    g.FillEllipse(new SolidBrush(ccolor), ccx - centersize, ccy - centersize, centersize * 2, centersize * 2);
                    for (int i = 0; i < 20; i++)//第一飛沫円         数値はいい感じになるようにテキトーに変更しましょう
                    {
                        lrad = rnd.Next(centersize / 2) + centersize;       //テキトー
                        lsize = rnd.Next(centersize / 5) + centersize / 10;//ここもテキトー
                        lang = rnd.Next(360);
                        lcx = ccx + (int)(usercos[(int)lang] * lrad);
                        lcy = ccy - (int)(usersin[(int)lang] * lrad);
                        g.FillEllipse(new SolidBrush(ccolor), lcx - lsize, lcy - lsize, lsize * 2, lsize * 2);
                    }
                    for (int i = 0; i < 50; i++)//第二飛沫円         数値はいい感じになるようにテキトーに変更しましょう
                    {
                        lrad = rnd.Next(centersize) + centersize;       //テキトー
                        lsize = rnd.Next(centersize / 8) + centersize / 20;//ここもテキトー
                        lang = rnd.Next(360);
                        lcx = ccx + (int)(usercos[(int)lang] * lrad);
                        lcy = ccy - (int)(usersin[(int)lang] * lrad);
                        g.FillEllipse(new SolidBrush(ccolor), lcx - lsize, lcy - lsize, lsize * 2, lsize * 2);
                    }
                    for (int i = 0; i < 100; i++)//第三飛沫円        数値はいい感じになるようにテキトーに変更しましょう
                    {
                        lrad = rnd.Next(centersize + centersize / 2) + centersize;       //テキトー
                        lsize = rnd.Next(3) + 1;//ここもテキトー
                        lang = rnd.Next(360);
                        lcx = ccx + (int)(usercos[(int)lang] * lrad);
                        lcy = ccy - (int)(usersin[(int)lang] * lrad);
                        g.FillEllipse(new SolidBrush(ccolor), lcx - lsize, lcy - lsize, lsize * 2, lsize * 2);
                    }
                    break;
                case 1:
                    break;
                case 2:
                    ccolor = spritcolor;
                    ccx = icx;
                    ccy = icy;
                    centersize = irad;//ここは引数を使って新しいモードを作ってもいいかもしれない... とりあえず汎用性を考えていない
                    g.FillEllipse(new SolidBrush(ccolor), ccx - centersize, ccy - centersize, centersize * 2, centersize * 2);
                    for (int i = 0; i < 20; i++)//第一飛沫円         数値はいい感じになるようにテキトーに変更しましょう
                    {
                        lrad = rnd.Next(centersize / 2) + centersize;       //テキトー
                        lsize = rnd.Next(centersize / 5) + centersize / 10;//ここもテキトー
                        lang = rnd.Next(360);
                        lcx = ccx + (int)(usercos[(int)lang] * lrad);
                        lcy = ccy - (int)(usersin[(int)lang] * lrad);
                        g.FillEllipse(new SolidBrush(ccolor), lcx - lsize, lcy - lsize, lsize * 2, lsize * 2);
                    }
                    for (int i = 0; i < 50; i++)//第二飛沫円         数値はいい感じになるようにテキトーに変更しましょう
                    {
                        lrad = rnd.Next(centersize) + centersize;       //テキトー
                        lsize = rnd.Next(centersize / 8) + centersize / 20;//ここもテキトー
                        lang = rnd.Next(360);
                        lcx = ccx + (int)(usercos[(int)lang] * lrad);
                        lcy = ccy - (int)(usersin[(int)lang] * lrad);
                        if (i <= 9)
                        {
                            bbloodleft[i] = lcx;
                            bbloodtop[i] = lcy;
                            bbloodsize[i] = lsize;
                        }
                        g.FillEllipse(new SolidBrush(ccolor), lcx - lsize, lcy - lsize, lsize * 2, lsize * 2);
                    }
                    for (int i = 0; i < 150; i++)//第三飛沫円        数値はいい感じになるようにテキトーに変更しましょう
                    {
                        lrad = rnd.Next(centersize + centersize / 2) + centersize;       //テキトー
                        lsize = rnd.Next(3) + 1;//ここもテキトー
                        lang = rnd.Next(360);
                        lcx = ccx + (int)(usercos[(int)lang] * lrad);
                        lcy = ccy - (int)(usersin[(int)lang] * lrad);
                        if (i <= 19)
                        {
                            lbloodleft[i] = lcx;
                            lbloodtop[i] = lcy;
                            lbloodsize[i] = lsize;
                        }
                        g.FillEllipse(new SolidBrush(ccolor), lcx - lsize, lcy - lsize, lsize * 2, lsize * 2);
                    }
                    break;
                    g.Dispose();
            }
        }

        private void 遊び方UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void ハイスコアHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("最も稼いだ金額は" + highscore + "＄です");
        }

        private void リセットRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("本当にリセットしますか？", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                init();
            } 
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ライフ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            life = int.Parse(Interaction.InputBox("how?", "", "", -1, -1));
            disp();
        }

        private void ショット数変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalshot = int.Parse(Interaction.InputBox("how?", "", "", -1, -1));
            disp();
        }

        private void ゲットマネー変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getmoney = int.Parse(Interaction.InputBox("how?", "", "", -1, -1));
            disp();
        }

        private void トータルマネー変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalmoney = int.Parse(Interaction.InputBox("how?", "", "", -1, -1));
            disp();
        }

        private void ハイスコアリセットLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            highscore = 0;
        }

        private void 残酷表現ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (残酷表現ToolStripMenuItem.Text == "残酷表現(オン)")
            {
                残酷表現ToolStripMenuItem.Text = "残酷表現(オフ)";

            }
            else
            {
                残酷表現ToolStripMenuItem.Text = "残酷表現(オン)";
            }

        }

        private void 画面をきれいにするToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
    }
}
