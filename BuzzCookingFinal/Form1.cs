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
    public partial class Form1 : Form
    {
        public static int mode;
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = label1; //ボタンをアクティブにしないため

            //サイズを固定
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void HowTobt_Click(object sender, EventArgs e)//遊び方画面へ
        {
            HowToForm htf = new HowToForm();
            DialogResult dr = htf.ShowDialog();
        }

        private void Playbt_Click(object sender, EventArgs e)//プレー画面へ
        {
            Cook ckf = new Cook();
            ckf.Show();

            //途中で間違って変更できないように
            Playbt.Enabled = false;
            設定ToolStripMenuItem.Enabled = false;
        }

        //ゲームモードの切替
        private void アマチュアToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt =
               MessageBox.Show("ステータスが確認できるので簡単なゲームモードです。\r\nゲーム終了まで難易度の変更が出来ませんがよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dt == DialogResult.OK)
            {
                mode = 0;
                MessageBox.Show("ゲームモード：アマチュアに切り替えました", "難易度アマチュアに変更完了");
            }
        }

        private void プロToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt =
                MessageBox.Show("ステータスが見えないので難しいゲームモードです。\r\nゲーム終了まで難易度の変更が出来ませんがよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dt == DialogResult.OK)
            {
                mode = 1;
                MessageBox.Show("ゲームモード：プロに切り替えました", "難易度プロに変更完了");
            }
        }
    }
}
