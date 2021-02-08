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
    public partial class Result : Form
    {
        public static int Hellkill;
        public static int Happykill;
        public static int Exp;
        public static int End;
        public Result()
        {
            InitializeComponent();

            //サイズの固定
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        public Result(int btem, string btenemy, int btway)
        {
            InitializeComponent();

            this.ActiveControl = label1;//テキストボックスをアクティブにしないため

            //サイズの固定
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            EnemyTb.Text = btenemy;

            //客によって得る集客力（経験値）
            if (btem >= 14)
            {
                Exp += 100;

                //神を攻撃で倒した場合もしくは閻魔を回復で倒した場合
                if ((btem == 14 && btway == 0) || (btem == 15 && btway == 1))
                {
                    End = 1;//正規エンディング
                }
                //神を回復で倒した場合
                else if (btem == 14 && btway == 1)
                {
                    End = 2;//ゲームオーバー1
                }
                //閻魔を攻撃で倒した場合
                else
                {
                    End = 3;//ゲームオーバー2
                }
            }
            else if (btem >= 12)
            {
                Exp += 70;

                //警察官を回復で倒した場合
                if (btem == 12 && btway == 1)
                {
                    End = 4;//ゲームオーバー3
                }
                //反社会的な人を攻撃で倒した場合
                else if (btem == 13 && btway == 0)
                {
                    End = 5;//ゲームオーバー4
                }
            }
            else if (btem >= 10)
            {
                Exp += 50;

                //保健所職員Aを攻撃で倒した場合
                if (btem == 10 && btway == 1)
                {
                    End = 6;//ゲームオーバー5
                }
                //保健所職員Bを攻撃で倒した場合
                else if (btem == 11 && btway == 0)
                {
                    End = 7;//ゲームオーバー6
                }

            }
            else if (btem >= 8)
            {
                Exp += 30;
            }
            else if (btem >= 5)
            {
                Exp += 5;
            }
            else if (btem >= 2)
            {
                Exp += 3;
            }
            else
            {
                Exp += 1;
            }

            ExpTb.Text = Exp.ToString();

            //倒した方法によって処理を変化
            if (btway == 0)
            {
                EnemyResultLB.Text = "は倒れた";
                ReputeLb.Text = "不味いという評判が広がった";
                Hellkill++;
            }
            else
            {
                EnemyResultLB.Text = "は昇天した";
                ReputeLb.Text = "美味しいという評判が広がった";
                Happykill++;
            }
        }

        private void Nextbt_Click(object sender, EventArgs e)
        {
            //神もしくは閻魔を倒した場合はクリア画面へ
            if (End >= 1)
            {
                Clear clf = new Clear();
                clf.Show();
                Close();
            }

            else//次の戦闘へ
            {
                Cook ckf = new Cook();
                ckf.Show();
                Close();
            }
        }
    }
}
