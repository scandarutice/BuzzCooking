using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzCookingFinal
{
    public partial class Battle : Form
    {
        private int btem;
        private string btenemy;
        private Image btenemyimg;
        private string btmenu;
        private Image btmenuimg;
        private Bitmap bm1, bm2, bm3;
        private int i;
        private int btway;
        private int bt_click;
        public Battle(int enemynum, string enemy, Image enemyimg, int way, string menu, Image menuimg)
        {
            InitializeComponent();

            //サイズの固定
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            //引数によってメニュー名、客名、画像のセット
            btenemy = enemy;
            EnemyTb.Text = btenemy;

            btenemyimg = enemyimg;
            bm1 = new Bitmap(btenemyimg);
            bm2 = new Bitmap(btenemyimg);
            BattlePb.Image = bm1;
            ReactPb.Image = bm1;
            ReactPb.Paint += new PaintEventHandler(reactpb_Paint);

            btmenu = menu;
            MenuTb.Text = btmenu;

            btmenuimg = menuimg;
            DishPb.Image = btmenuimg;

            btway = way;
            btem = enemynum;

            //客の初期セリフ
            if (btem == 0)
            {
                ReactTb.Text = "「待ってたよー！いただきまーす！」";
            }
            else if (btem == 1)
            {
                ReactTb.Text = "「はあ・・・早く食べて仕事に・・・\r\nメールの返信もしなきゃ・・」";
            }
            else if (btem == 2)
            {
                ReactTb.Text = "「お腹が空いたわ・・\r\nあら、やっときたわね。」";
            }
            else if (btem == 3)
            {
                ReactTb.Text = "「お！キタキタ。さあ、食べよう！」";
            }
            else if (btem == 4)
            {
                ReactTb.Text = "「お腹すいたー・・」";
            }
            else if (btem == 5)
            {
                ReactTb.Text = "「I'm Hungry・・・」";
            }
            else if (btem == 6)
            {
                ReactTb.Text = "「ニーハオー！！\r\nコノミセノアジ、タシカメルアル！」";
            }
            else if (btem == 7)
            {
                ReactTb.Text = "「ナマステー！\r\nアープ キャ リコメンド カルテ ヘン？」";
            }
            else if (btem == 8)
            {
                ReactTb.Text = "「不味いと評判ですが・・\r\nどれほどでしょうか・・」";
            }
            else if (btem == 9)
            {
                ReactTb.Text = "「美味しいと評判ですが・・・\r\nどれほどでしょうか・・」";
            }
            else if (btem == 10)
            {
                ReactTb.Text = "「法に触れている可能性があります！\r\n行政指導のために試食します！」";
            }
            else if (btem == 11)
            {
                ReactTb.Text = "「違法な食材使っていませんか？\r\n調査させていただきます！」";
            }
            else if (btem == 12)
            {
                ReactTb.Text = "「ここが大量中毒事件の現場か・・」";
            }
            else if (btem == 13)
            {
                ReactTb.Text = "「はよ美味いもん出さんかいコラァ！」";
            }
            else if (btem == 14)
            {
                ReactTb.Text = "「世界を滅亡させる料理など\r\n神であるワシが認めん！！！」";
            }
            else if (btem == 15)
            {
                ReactTb.Text = "「世界を変える料理とな？\r\n面白い・・来るがいい！！！」";
            }
        }

        public void convert()//客の反応によってトーンを変える
        {
            for (int x = 0; x < bm1.Width; x++)
            {
                for (int y = 0; y < bm1.Height; y++)
                {
                    Color c = bm1.GetPixel(x, y);
                    int rgb = c.ToArgb();
                    int a = (rgb >> 24) & 0xFF;
                    int r = (rgb >> 16) & 0xFF;
                    int g = (rgb >> 8) & 0xFF;
                    int b = (rgb >> 0) & 0xFF;

                    if (btway == 0)
                    {
                        r >>= 2;
                        ReactPb.BackColor = Color.Black;
                    }
                    else
                    {
                        g >>= 1;
                        ReactPb.BackColor = Color.Pink;
                    }

                    rgb = (a << 24) | (r << 16) | (g << 8) | (b << 0);

                    c = Color.FromArgb(rgb);

                    bm2.SetPixel(x, y, c);
                    BattlePb.Image = bm2;
                    ReactPb.Image = bm2;
                }
            }
        }

        private void ActBt_Click(object sender, EventArgs e)
        {
            bt_click++;
            if (bt_click == 1)
            {
                convert();
                ReactPb.Invalidate();//客の反応処理
            }
            if (bt_click == 2)
            {
                Timer tm = new Timer();
                tm.Start();
                tm.Tick += new EventHandler(tm_Tick);
                ReactPb.Paint += new PaintEventHandler(reactpb_Paint);
                ActBt.Text = "リザルトへ";

                //攻撃ステータスで処理時の客のセリフと画像
                if (btway == 0)
                {
                    ReactPb.Image = BuzzCookingFinal.Properties.Resources.badbg;

                    if (btem == 0)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.free_bad;
                        ReactTb.Text = "「う・・・く、苦ｓ・・」";
                    }
                    else if (btem == 1)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.businessman_bad;
                        ReactTb.Text = "「・・・！？\r\n疲れが味にも支障を・・？？」";
                    }
                    else if (btem == 2)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.ol_bad;
                        ReactTb.Text = "「ちょ・・！なんなのこｒ。。。」";
                    }
                    else if (btem == 3)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.family_bad;
                        ReactTb.Text = "「パｐ・・・ああ、あなｔ・・\r\n・コンナトコロデ・・・」";
                    }
                    else if (btem == 4)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.kids_bad;
                        ReactTb.Text = "「おえ・・・\r\n泥と蟻を食べてるみｔ・・i」";
                    }
                    else if (btem == 5)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.american_bad;
                        ReactTb.Text = "「OH....MY...GOD.....」";
                    }
                    else if (btem == 6)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.china_bad;
                        ReactTb.Text = "「..ワタシノレキシ..\r\nココデオワルアｒ...」";
                    }
                    else if (btem == 7)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.india_bad;
                        ReactTb.Text = "「イセ ワパス レ ジャエｎ....」";
                    }
                    else if (btem == 8)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.bisyokuwoman_bad;
                        ReactTb.Text = "「うぷ....口いっぱいに...\r\nゴｍ...」";
                    }
                    else if (btem == 9)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.bisyokuman_bad;
                        ReactTb.Text = "「うぷ....口いっぱいに...\r\nゴｍ...」";
                    }
                    else if (btem == 10)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.kansaman_bad;
                        ReactTb.Text = "「食品......衛生法....違反...\r\nというか.もはｙ」";
                    }
                    else if (btem == 11)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.kansawoman_bad;
                        ReactTb.Text = "「こんな....許されな....」";
                    }
                    else if (btem == 12)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.police_bad;
                        ReactTb.Text = "「すまない....逮捕より先に...\r\n殉職した仲間のもとへ....」";
                    }
                    else if (btem == 13)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.yakuza_bad;
                        ReactTb.Text = "「毒デモ盛ったノカ！？\r\nテメエ....ヨクモ....」";
                    }
                    else if (btem == 14)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.boss_bad;
                        ReactTb.Text = "「これは....終末の....」";
                    }
                    else if (btem == 15)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.boss_bad;
                        ReactTb.Text = "「これは....終末の....」";
                    }

                }
                //回復ステータスで処理時の客のセリフと画像
                if (btway == 1)
                {
                    ReactPb.Image = BuzzCookingFinal.Properties.Resources.happy_bg;

                    if (btem == 0)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.free_good;
                        ReactTb.Text = "「ヤバ！美味しいなこれ！」";
                    }
                    else if (btem == 1)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.businessman_good;
                        ReactTb.Text = "「これは・・午後からの活力！！！」";
                    }
                    else if (btem == 2)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.ol_good;
                        ReactTb.Text = "「ちょーやば！先輩誘わなきゃ！」";
                    }
                    else if (btem == 3)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.family_good;
                        ReactTb.Text = "「ママの料理よりおいしい！！！」";
                    }
                    else if (btem == 4)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.kids_good;
                        ReactTb.Text = "「生まれて初めてこんな美味しいの\r\n食べたよ！おとーさんにも教えなきゃ！」";
                    }
                    else if (btem == 5)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.american_good;
                        ReactTb.Text = "「WAO！Delicious!!!」";
                    }
                    else if (btem == 6)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.china_good;
                        ReactTb.Text = "「好吃 ハオチー！！！」";
                    }
                    else if (btem == 7)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.india_good;
                        ReactTb.Text = "「 レケン ボハット アッチャ タ」";
                    }
                    else if (btem == 8)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.bisyokuwoman_good;
                        ReactTb.Text = "「あら？いけるじゃない？\r\n不味いなんて嘘じゃない！」";
                    }
                    else if (btem == 9)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.bisyokuman_good;
                        ReactTb.Text = "「噂通りだな！素晴らしい！」";
                    }
                    else if (btem == 10)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.kansaman_good;
                        ReactTb.Text = "「聞いていた話と違うな・・」";
                    }
                    else if (btem == 11)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.kansawoman_good;
                        ReactTb.Text = "「合法よ合法！！美味しすぎるわ！」";
                    }
                    else if (btem == 12)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.police_good;
                        ReactTb.Text = "「事件性なしであります！！！\r\nむしろ美味しすぎて事件であります！」";
                    }
                    else if (btem == 13)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.yakuza_good;
                        ReactTb.Text = "「うほ！うほほほ！！！\r\nうまーーーーーーーーい」";
                    }
                    else if (btem == 14)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.boss_good;
                        ReactTb.Text = "「ふむ・・悪くないではないか。」";
                    }
                    else if (btem == 15)
                    {
                        bm3 = BuzzCookingFinal.Properties.Resources.boss_good;
                        ReactTb.Text = "「素晴らしい料理ではないか！」";
                    }
                }
            }
            if (bt_click == 3)
            {
                Result rtf = new Result(btem, btenemy, btway);
                rtf.Show();
                Close();
            }

        }

        private void reactpb_Paint(object sender, PaintEventArgs e)
        {
            //客の反応描写
            Graphics g = e.Graphics;
            if (bt_click == 1)
            {
                g.DrawImage(bm2, 581, 141, 200, 200);
            }
            else if (bt_click == 2)
            {
                g.DrawImage(bm3, new Rectangle(10, 0, i, ReactPb.Height), 0, 0, bm3.Width, bm3.Height, GraphicsUnit.Pixel);
            }
        }

        public void tm_Tick(object sender, EventArgs e)
        {
            if (i == (ReactPb.Width - 20))
            {
                tm.Stop();
            }
            else
            {
                i = i + 10;
            }
            ReactPb.Invalidate();
        }
    }
}
