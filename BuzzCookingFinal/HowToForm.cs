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
    public partial class HowToForm : Form
    {
        public HowToForm()
        {
            InitializeComponent();

            //サイズを固定
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void HowToForm_Load(object sender, EventArgs e)
        {
            //ストーリーの説明
            Purposelb.Text = "あなたは限界世界の料理人です。";
            Ppxplb.Text = "お客様に合わせて料理を提供しましょう。あなたの作った料理で限界世界の未来が変わります。\r\n\r\n" +
                "料理を上手く作ることが出来れば昇天し、美味しいという評判が広がります。\r\n" +
                "料理が上手く出来なかった場合は卒倒し、不味いという評判が広がります。\r\n\r\n" +
                "美味しい料理で世界平和を目指すのも、不味い料理で世界征服するのもあなた次第です。";
            //遊び方の説明
            HowTolb.Text = "遊び方";
            Htxplb.Text = "１：料理を選びましょう。\r\n２：選んだ料理に合う食材を選びましょう。\r\n３：BuzzCook!ボタンで客と戦闘になります。\r\n\r\n" +
                "お客様には好きな料理があります。好きそうな料理を提供してあげましょう。\r\n" +
                "評判によっては珍しいお客様が来るかもしれません。";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
