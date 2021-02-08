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
    public partial class Clear : Form
    {
        public Clear()
        {
            InitializeComponent();

            //サイズの固定
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.ActiveControl = GameResultLb;
        }

        private void Clear_Load(object sender, EventArgs e)
        {
            //倒した総客数によってクリア画面の分岐
            if (Result.End == 1)//正規エンディング
            {
                if (Result.Happykill == 11)
                {
                    ResultTb.Text = "閻魔を倒したことで世界は平和になった。";
                    ResultexTb.Text = "美味しいという評判が世界に轟き、その美味しい料理のおかげで\r\n世界から争いがなくなった・・・。あなたとあなたが作った料理は\r\n「人を幸せにする伝説」として後世まで語り継がれたという。";
                }
                else
                {
                    ResultTb.Text = "神を倒したことで世界は滅亡した。";
                    ResultexTb.Text = "不味いという評判が世界に轟き、その不味い料理は\r\n世界を滅ぼした・・・。神が滅び、料理を口にせず生き残った人々は\r\n「世界を滅ぼす料理人」として、後世まで語り継いだという・・。";
                }
            }
            else if (Result.End == 2)//ゲームオーバー1
            {
                GameResultLb.Text = "残念ながらゲームオーバーです・・・";
                ResultTb.Text = "神の怒りは免れた。・・・が。";
                ResultexTb.Text = "不味いという評判が世界に轟き、同時に大量の犠牲者も生まれた。\r\nあらゆる生き物の生気を奪うあなたの料理。のちに世界政府会議で\r\nあなたの料理は調理・保持禁止事項に盛り込まれたという。";
            }
            else if (Result.End == 3)//ゲームオーバー2
            {
                GameResultLb.Text = "残念ながらゲームオーバーです・・・";
                ResultTb.Text = "閻魔の怒りに触れた。";
                ResultexTb.Text = "あなたの料理は美味しいと世界に評判だったが\r\n閻魔の怒りに触れ、あなたも、あなたの料理も存在ごと抹消された。\r\nだが「閻魔の怒りに触れた料理」という噂だけは後世まで残った。";
            }
            else if (Result.End == 4)//ゲームオーバー3
            {
                GameResultLb.Text = "残念ながらゲームオーバーです・・・";
                ResultTb.Text = "警察に許された。";
                ResultexTb.Text = "あなたの料理は捜査対象から外されたが\r\n不味いという評判が中途半端に広まり、客が来なくなった。\r\nその結果、収入がなくなり店は潰れてしまった。";
            }
            else if (Result.End == 5)//ゲームオーバー4
            {
                GameResultLb.Text = "残念ながらゲームオーバーです・・・";
                ResultTb.Text = "お礼参りされた。";
                ResultexTb.Text = "どうやら怒らせてはいけない人を怒らせた。\r\n連日店を荒らされ、シャバで店主を見た者はいないという・・。";
            }
            else if (Result.End == 6)//ゲームオーバー5
            {
                GameResultLb.Text = "残念ながらゲームオーバーです・・・";
                ResultTb.Text = "監査をごまかせた。";
                ResultexTb.Text = "偶然にも監査をごまかすことが出来たが\r\n後日裁判沙汰になり、違法性が認められた。\r\nだが、意外にもあなたの不味い料理を求める人が巷にいるらしい。";
            }
            else if (Result.End == 7)//ゲームオーバー6
            {
                GameResultLb.Text = "残念ながらゲームオーバーです・・・";
                ResultTb.Text = "営業停止処分になった。";
                ResultexTb.Text = "あなたの料理は監査に引っかかった。\r\n営業停止処分を下され、お店を続けることが出来なくなった。";
            }

        }
    }
}
