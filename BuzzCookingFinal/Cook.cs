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
    public partial class Cook : Form
    {
        private int enemynum;
        private string enemy;
        private Image enemyimg;

        private int index;
        private string menu;
        private int menucg;
        private int foodcg;
        private Image menuimg;
        private int menuatkst;
        private int menuhlst;
        private int menufn;

        private int mainatkst;
        private int mainhlst;
        private int mainfn;

        private int subindex;

        private int sub1atkst;
        private int sub1hlst;
        private int sub1index;

        private int sub2atkst;
        private int sub2hlst;
        private int sub2index;

        private int sub3atkst;
        private int sub3hlst;
        private int sub3index;

        private int atkst;
        private int hlst;
        private int way;

        private int hellkill;
        private int happykill;
        private int exp;

        public Cook()//倒した総客数と集客力の呼び出し
        {
            InitializeComponent();
            hellkill = Result.Hellkill;
            happykill = Result.Happykill;
            exp = Result.Exp;

            //サイズの固定
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void Cook_Load(object sender, EventArgs e)//各種データの読込
        {
            //メニューのデータ
            menuDataSet.MenuDataTable.AddMenuDataTableRow("オムライス", "米", 1, 10, 40);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("カレー", "米", 1, 50, 50);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("牛丼", "米", 1, 20, 30);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("海鮮丼", "米", 1, 30, 20);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("パエリア", "米", 1, 40, 10);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("ピザ", "パン", 2, 20, 40);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("フレンチトースト", "パン", 2, 30, 20);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("パスタ", "麺", 3, 30, 20);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("ラーメン", "麺", 3, 40, 40);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("担々麺", "麺", 3, 50, 20);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("ステーキ", "肉", 4, 20, 50);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("刺身", "魚", 5, 40, 20);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("サラダ", "野菜", 6, 20, 20);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("たこ焼き", "小麦粉", 7, 20, 20);
            menuDataSet.MenuDataTable.AddMenuDataTableRow("ケーキ", "小麦粉", 7, 30, 40);

            //メイン食材のデータ
            mainFoodDataSet.MainFoodDataTable.AddMainFoodDataTableRow("米", 1, 10, 10);
            mainFoodDataSet.MainFoodDataTable.AddMainFoodDataTableRow("パン", 2, 10, 10);
            mainFoodDataSet.MainFoodDataTable.AddMainFoodDataTableRow("麺", 3, 20, 20);
            mainFoodDataSet.MainFoodDataTable.AddMainFoodDataTableRow("肉", 4, 40, 40);
            mainFoodDataSet.MainFoodDataTable.AddMainFoodDataTableRow("魚", 5, 40, 40);
            mainFoodDataSet.MainFoodDataTable.AddMainFoodDataTableRow("野菜", 6, 40, 40);
            mainFoodDataSet.MainFoodDataTable.AddMainFoodDataTableRow("小麦粉", 7, 20, 20);

            //サブ食材のデータ
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("なし", 0, 0);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("卵", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("豆腐", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("カレー", 15, 15);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("魚介", 10, 15);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("キノコ", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("肉加工品", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("牛乳", 10, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("チーズ", 10, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("刃物", 100, 0);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("昆虫", 25, 10);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("牛肉", 5, 10);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("豚肉", 5, 10);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("鶏肉", 5, 10);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("スープ", 5, 10);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("果物", 15, 20);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("砂糖", 15, 10);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("塩", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("酢", 15, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("醤油", 10, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("味噌", 10, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("唐辛子", 20, 20);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("ワサビ", 20, 20);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("マヨネーズ", 15, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("バター", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("ワイン", 15, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("コーヒー", 15, 10);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("出汁", 10, 10);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("みりん", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("胡椒", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("ケチャップ", 10, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("めんつゆ", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("ソース", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("胡麻", 5, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("ラー油", 10, 5);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("ホイップクリーム", 25, 25);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("チョコレート", 25, 25);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("ニンニク", 20, 20);
            subFoodDataSet.SubFoodDataTable.AddSubFoodDataTableRow("人肉", 35, 35);

            //各方法で倒した客数と集客力の表示
            HellnumLb.Text = "" + hellkill;
            HappynumLb.Text = "" + happykill;
            ExpLb.Text = "" + exp;

            //各方法で倒した総客数によって客に割り当てる乱数の調整
            //集客力条件は特定の状況下で同じレア客を連続発生させないため
            Random rnd = new Random();

            if (hellkill == 3 && exp <= 20)
            {
                enemynum = rnd.Next(8, 8);//衛生管理女
            }
            else if (hellkill == 5 && exp <= 60)
            {
                enemynum = rnd.Next(10, 10);//保健所職員男
            }
            else if (hellkill == 7 && exp <= 100)
            {
                enemynum = rnd.Next(12, 12);//警察官
            }
            else if (hellkill == 10 && exp <= 220)
            {
                enemynum = rnd.Next(14, 14);//神
            }
            else if (happykill == 3 && exp <= 20)
            {
                enemynum = rnd.Next(9, 9);//衛生管理男
            }
            else if (happykill == 5 && exp <= 60)
            {
                enemynum = rnd.Next(11, 11);//保健所職員女
            }
            else if (happykill == 7 && exp <= 100)
            {
                enemynum = rnd.Next(13, 13);//反社会勢力
            }
            else if (happykill == 10 && exp <= 220)
            {
                enemynum = rnd.Next(15, 15);//閻魔
            }
            else
            {
                enemynum = rnd.Next(0, 8);//一般の客
            }

            //乱数の応じて客のデータをセット
            if (enemynum == 0)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.free;
                EnemyTb.Text = "一般人";
            }
            else if (enemynum == 1)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.businessman;
                EnemyTb.Text = "サラリーマン";
            }
            else if (enemynum == 2)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.ol;
                EnemyTb.Text = "OL";
            }
            else if (enemynum == 3)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.family;
                EnemyTb.Text = "家族";
            }
            else if (enemynum == 4)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.kids;
                EnemyTb.Text = "こども";
            }
            else if (enemynum == 5)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.american;
                EnemyTb.Text = "アメリカ人";
            }
            else if (enemynum == 6)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.china;
                EnemyTb.Text = "中国人";
            }
            else if (enemynum == 7)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.india;
                EnemyTb.Text = "インド人";
            }
            else if (enemynum == 8)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.bisyokuwoman;
                EnemyTb.Text = "衛生管理者A";
            }
            else if (enemynum == 9)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.bisyokuman;
                EnemyTb.Text = "衛生管理者B";
            }
            else if (enemynum == 10)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.kansaman;
                EnemyTb.Text = "保健所の職員A";
            }
            else if (enemynum == 11)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.kansawoman;
                EnemyTb.Text = "保健所の職員B";
            }
            else if (enemynum == 12)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.police;
                EnemyTb.Text = "警察官";
            }
            else if (enemynum == 13)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.yakuza;
                EnemyTb.Text = "反社会的な人";
            }
            else if (enemynum == 14)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.shinwa_zeus;
                EnemyTb.Text = "神";
            }
            else if (enemynum == 15)
            {
                EnemyPb.Image = BuzzCookingFinal.Properties.Resources.enmadaiou;
                EnemyTb.Text = "閻魔";
            }

            enemy = EnemyTb.Text;
            enemyimg = EnemyPb.Image;
        }

        private void MenuCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = MenuCb.SelectedIndex;
            menucg = 0;//メニューのコンボボックスの初期値

            //選ばれた値から各種データの抽出とセット
            string menucol = MenuCb.SelectedValue.ToString();
            DataRow[] menuRow = menuDataSet.MenuDataTable.Select("料理名 = '" + menucol + "'");
            foreach (DataRow menudr in menuRow)
            {
                menufn = int.Parse(menudr["分類番号"].ToString());
                menuatkst = int.Parse(menudr["攻撃力"].ToString());
                menuhlst = int.Parse(menudr["回復力"].ToString());
            }

            //メニューに対応する画像のセット
            if (index == 0)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.omurice;
            }
            else if (index == 1)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.curryruce;
            }
            else if (index == 2)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.gyudon;
            }
            else if (index == 3)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.kaisendon;
            }
            else if (index == 4)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.paella;
            }
            else if (index == 5)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.pizza_takuhai;
            }
            else if (index == 6)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.frenchtoast;
            }
            else if (index == 7)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.ankake_supa;
            }
            else if (index == 8)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.ramen_iekei;
            }
            else if (index == 9)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.tantanmen;
            }
            else if (index == 10)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.beefsteak;
            }
            else if (index == 11)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.funamori;
            }
            else if (index == 12)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.vegetable_yasai_stick;
            }
            else if (index == 13)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.takoyaki_fune;
            }
            else if (index == 14)
            {
                MenuPb.Image = BuzzCookingFinal.Properties.Resources.shortcake;
            }

            menuimg = MenuPb.Image;
            menu = MenuCb.Text;
            menucg = 1;

            Bt_Enabled();//条件が揃ったらボタンを押せるように

            atkst = 0;
            hlst = 0;

            atkst = menuatkst;
            hlst = menuhlst;

            stcalc();//各ステータスの計算

        }

        private void MainFoodCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodcg = 0;//メイン食材のコンボボックスの初期値

            //選ばれた値から各種データの抽出とセット
            string maincol = MainFoodCb.SelectedValue.ToString();
            DataRow[] mainRow = mainFoodDataSet.MainFoodDataTable.Select("食材分類 = '" + maincol + "'");
            foreach (DataRow maindr in mainRow)
            {
                mainfn = int.Parse(maindr["分類番号"].ToString());
                mainatkst = int.Parse(maindr["攻撃力"].ToString());
                mainhlst = int.Parse(maindr["回復力"].ToString());
            }

            foodcg = 1;

            Bt_Enabled();//条件が揃ったらボタンを押せるように

            atkst = 0;
            hlst = 0;

            atkst = mainatkst;
            hlst = mainhlst;

            stcalc();//各ステータスの計算

        }

        private void SubCb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub1index = SubCb1.SelectedIndex;

            //選ばれた値から各種データの抽出とセット
            string sub1col = SubCb1.SelectedValue.ToString();
            DataRow[] sub1Row = subFoodDataSet.SubFoodDataTable.Select("食材名 = '" + sub1col + "'");
            foreach (DataRow sub1dr in sub1Row)
            {
                sub1atkst = int.Parse(sub1dr["攻撃力"].ToString());
                sub1hlst = int.Parse(sub1dr["回復力"].ToString());
            }

            SubCb2.Enabled = true;

            atkst = 0;
            hlst = 0;

            atkst = sub1atkst;
            hlst = sub1hlst;
            subindex = sub1index;

            subst();//サブ食材のステータスの計算

            sub1atkst = atkst;
            sub1hlst = hlst;

            stcalc();//各ステータスの計算

            Bt_Enabled();//条件が揃ったらボタンを押せるように
        }

        private void SubCb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub2index = SubCb2.SelectedIndex;

            //選ばれた値から各種データの抽出とセット
            string sub2col = SubCb2.SelectedValue.ToString();
            DataRow[] sub2Row = subFoodDataSet.SubFoodDataTable.Select("食材名 = '" + sub2col + "'");
            foreach (DataRow sub2dr in sub2Row)
            {
                sub2atkst = int.Parse(sub2dr["攻撃力"].ToString());
                sub2hlst = int.Parse(sub2dr["回復力"].ToString());
            }

            SubCb3.Enabled = true;

            atkst = 0;
            hlst = 0;

            atkst = sub2atkst;
            hlst = sub2hlst;
            subindex = sub2index;

            subst();//サブ食材のステータスの計算

            sub2atkst = atkst;
            sub2hlst = hlst;

            stcalc();//各ステータスの計算

        }

        private void SubCb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub3index = SubCb3.SelectedIndex;

            //選ばれた値から各種データの抽出とセット
            string sub3col = SubCb3.SelectedValue.ToString();
            DataRow[] sub3Row = subFoodDataSet.SubFoodDataTable.Select("食材名 = '" + sub3col + "'");
            foreach (DataRow sub3dr in sub3Row)
            {
                sub3atkst = int.Parse(sub3dr["攻撃力"].ToString());
                sub3hlst = int.Parse(sub3dr["回復力"].ToString());
            }
            atkst = 0;
            hlst = 0;

            atkst = sub3atkst;
            hlst = sub3hlst;
            subindex = sub3index;

            subst();//サブ食材のステータスの計算

            sub3atkst = atkst;
            sub3hlst = hlst;

            stcalc();//各ステータスの計算

        }

        private void Bt_Enabled()
        {
            //メニューとメイン食材とサブ食材１が初期値から切り替わっていればボタンを押せるようにする
            if (menucg == 1 && foodcg == 1 && sub1index > 0)
            {
                BzckBt.Enabled = true;
            }
        }

        private void BzckBt_Click(object sender, EventArgs e)
        {
            //サブ食材１が選択されていない場合
            if ((sub1index == 0) == true)
            {
                MessageBox.Show("サブ食材１を選択してください。");
                return;
            }
            //サブ食材２と３が選択されていない場合は普通の処理
            else if (SubCb2.SelectedIndex == 0 && SubCb3.SelectedIndex == 0)
            {

            }
            //サブ食材で同じものが選択されている場合
            else if (SubCb1.SelectedIndex == SubCb2.SelectedIndex ||
                    SubCb1.SelectedIndex == SubCb3.SelectedIndex ||
                    SubCb2.SelectedIndex == SubCb3.SelectedIndex)
            {
                MessageBox.Show("同じサブ食材が選ばれています。\r\n違うサブ食材を選択してください。");
                return;
            }

            //計算後、高かったステータスで倒す方法の決定
            if (atkst > hlst)
            {
                way = 0;
            }
            else
            {
                way = 1;
            }

            Battle btf = new Battle(enemynum, enemy, enemyimg, way, menu, menuimg);
            btf.Show();
            this.Hide();
        }

        private void subst()//サブ食材のステータス計算処理
        {
            int[] subst = new int[2];
            subst[0] = atkst;
            subst[1] = hlst;

            if (subindex == 1)
            {
                egg(subst);
            }
            else if (subindex == 2)
            {
                tofu(subst);
            }
            else if (subindex == 3)
            {
                curry(subst);
            }
            else if (subindex == 4)
            {
                fish(subst);
            }
            else if (subindex == 5)
            {
                mushroom(subst);
            }
            else if (subindex == 6)
            {
                meet(subst);
            }
            else if (subindex == 7)
            {
                milk(subst);
            }
            else if (subindex == 8)
            {
                cheese(subst);
            }
            else if (subindex == 9)
            {
                knife(subst);
            }
            else if (subindex == 10)
            {
                insect(subst);
            }
            else if (subindex == 11)
            {
                beef(subst);
            }
            else if (subindex == 12)
            {
                pork(subst);
            }
            else if (subindex == 13)
            {
                chicken(subst);
            }
            else if (subindex == 14)
            {
                soup(subst);
            }
            else if (subindex == 15)
            {
                fruit(subst);
            }
            else if (subindex == 16)
            {
                sugar(subst);
            }
            else if (subindex == 17)
            {
                solt(subst);
            }
            else if (subindex == 18)
            {
                vinegar(subst);
            }
            else if (subindex == 19)
            {
                soysause(subst);
            }
            else if (subindex == 20)
            {
                miso(subst);
            }
            else if (subindex == 21)
            {
                mustard(subst);
            }
            else if (subindex == 22)
            {
                wasabi(subst);
            }
            else if (subindex == 23)
            {
                mayonnaise(subst);
            }
            else if (subindex == 24)
            {
                butter(subst);
            }
            else if (subindex == 25)
            {
                wine(subst);
            }
            else if (subindex == 26)
            {
                coffee(subst);
            }
            else if (subindex == 27)
            {
                dashi(subst);
            }
            else if (subindex == 28)
            {
                sweetsake(subst);
            }
            else if (subindex == 29)
            {
                pepper(subst);
            }
            else if (subindex == 30)
            {
                ketchup(subst);
            }
            else if (subindex == 31)
            {
                noodlesoup(subst);
            }
            else if (subindex == 32)
            {
                source(subst);
            }
            else if (subindex == 33)
            {
                sesame(subst);
            }
            else if (subindex == 34)
            {
                chilioil(subst);
            }
            else if (subindex == 35)
            {
                whippedcream(subst);
            }
            else if (subindex == 36)
            {
                chocolate(subst);
            }
            else if (subindex == 37)
            {
                garlic(subst);
            }
            else if (subindex == 38)
            {
                humanmeet(subst);
            }

            atkst = subst[0];
            hlst = subst[1];

        }

        //各サブ食材がメニューと一致しているかどうかにより計算処理
        private int[] egg(int[] subst)
        {
            if (index == 0 || index == 6)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] = atkst - atkst;
                subst[1] = hlst;
                return subst;
            }
        }
        private int[] tofu(int[] subst)
        {
            if (index == 8 || index == 12)
            {
                subst[0] -= atkst;
                subst[1] = hlst;
                return subst;
            }
            else
            {
                subst[0] = atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] curry(int[] subst)
        {
            if (index == 1)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 0 || index == 2 || index == 4 || index == 5 || index == 8)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] fish(int[] subst)
        {
            if (index == 3 || index == 4 || index == 7 || index == 8 || index == 11 || index == 13)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 10)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] mushroom(int[] subst)
        {
            if (index == 1 || index == 4 || index == 5 || index == 7 || index == 12)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 0)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] meet(int[] subst)
        {
            if (index == 5 || index == 7 || index == 9)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 0 || index == 1 || index == 2)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] milk(int[] subst)
        {
            if (index == 6 || index == 14)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 0 || index == 7)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] cheese(int[] subst)
        {
            if (index == 5)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 0 || index == 1 || index == 2 || index == 7 || index == 10)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] knife(int[] subst)
        {
            subst[0] += atkst;
            subst[1] -= hlst;
            return subst;
        }
        private int[] insect(int[] subst)
        {
            if (index == 3 || index == 4)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] beef(int[] subst)
        {
            if (index == 2 || index == 10)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 7)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] pork(int[] subst)
        {
            if (index == 1 || index == 7 || index == 8 || index == 9 || index == 10)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] chicken(int[] subst)
        {
            if (index == 0 || index == 1 || index == 5 || index == 7 || index == 10)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] soup(int[] subst)
        {
            if (index == 4 || index == 7 || index == 8 || index == 9)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] fruit(int[] subst)
        {
            if (index == 14)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 1 || index == 12)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] sugar(int[] subst)
        {
            if (index == 6 || index == 14)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] solt(int[] subst)
        {
            if (index == 0 || index == 3 || index == 8 || index == 10 || index == 11 || index == 13)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] vinegar(int[] subst)
        {
            if (index == 0 || index == 1 || index == 3)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] soysause(int[] subst)
        {
            if (index == 1 || index == 3 || index == 8 || index == 11 || index == 13)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] miso(int[] subst)
        {
            if (index == 8 || index == 9)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] mustard(int[] subst)
        {
            if (index == 9)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] wasabi(int[] subst)
        {
            if (index == 3 || index == 10 || index == 11)
            {
                subst[0] = atkst - atkst;
                subst[1] = hlst + hlst;
                return subst;
            }
            else
            {
                subst[0] = atkst + atkst;
                subst[1] = hlst - hlst;
                return subst;
            }
        }
        private int[] mayonnaise(int[] subst)
        {

            if (index == 0 || index == 1 || index == 2 || index == 5 || index == 12)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] butter(int[] subst)
        {
            if (index == 0 || index == 6 || index == 14)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] wine(int[] subst)
        {
            if (index == 1 || index == 4)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 0 || index == 10)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] coffee(int[] subst)
        {
            if (index == 1)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] dashi(int[] subst)
        {
            if (index == 4 || index == 7 || index == 8 || index == 9)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] sweetsake(int[] subst)
        {
            if (index == 3 || index == 8)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] pepper(int[] subst)
        {
            if (index == 4 || index == 5 || index == 7 || index == 8 || index == 9 || index == 10)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] ketchup(int[] subst)
        {
            if (index == 0)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 4 || index == 5)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] noodlesoup(int[] subst)
        {
            if (index == 2 || index == 3 || index == 8 || index == 13)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] source(int[] subst)
        {
            if (index == 1 || index == 13)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] sesame(int[] subst)
        {
            if (index == 9)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 0 || index == 3 || index == 7 || index == 8)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] chilioil(int[] subst)
        {
            if (index == 9)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] whippedcream(int[] subst)
        {
            if (index == 14)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else if (index == 6)
            {
                subst[0] = atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] chocolate(int[] subst)
        {
            if (index == 14)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] garlic(int[] subst)
        {
            if (index == 0 || index == 1 || index == 2 || index == 4 || index == 7 || index == 8 || index == 9 || index == 10)
            {
                subst[0] += atkst;
                subst[1] = hlst + hlst + hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }
        private int[] humanmeet(int[] subst)
        {
            if (index == 9 || index == 10)
            {
                subst[0] -= atkst;
                subst[1] += hlst;
                return subst;
            }
            else
            {
                subst[0] += atkst;
                subst[1] -= hlst;
                return subst;
            }
        }

        private void stcalc()//各ステータスの最終計算処理
        {
            if (menufn == mainfn)//メニューとメイン食材が一致している場合
            {
                hlst = menuhlst + mainhlst + (exp / 2);
                atkst = menuatkst - mainatkst;
            }
            else//メニューとメイン食材が不一致の場合
            {
                atkst = menuatkst + mainatkst + (exp / 2);
                hlst = menuhlst - mainhlst;
            }

            hlst = hlst + ((sub1hlst + sub2hlst + sub3hlst) + exp / 3) + exp;
            atkst = atkst + ((sub1atkst + sub2atkst + sub3atkst) + exp / 3) + exp;

            //メニューに対して必須のサブ食材が選ばれていなかった場合
            //オムライス＝卵、カレー＝カレー、牛丼＝牛肉、海鮮丼＝魚介、パエリア＝魚介、フレンチトースト＝砂糖、たこ焼き＝魚介
            if (((index == 0) && ((sub1index == 1) || (sub2index == 1) || (sub3index == 1)) ||
                (index == 1) && ((sub1index == 3) || (sub2index == 3) || (sub3index == 3)) ||
                (index == 2) && ((sub1index == 11) || (sub2index == 11) || (sub3index == 11)) ||
                (index == 3) && ((sub1index == 4) || (sub2index == 4) || (sub3index == 4)) ||
                (index == 4) && ((sub1index == 4) || (sub2index == 4) || (sub3index == 4)) ||
                (index == 6) && ((sub1index == 16) || (sub2index == 16) || (sub3index == 16)) ||
                (index == 13) && ((sub1index == 4) || (sub2index == 4) || (sub3index == 4))) == false)
            {
                atkst = atkst + 25;
                hlst = hlst - 25;
            }

            //客の相性による補正
            //OLにケーキ、アメリカ人に刺身の場合、回復値に補正
            if (((enemynum == 2) && (index == 14)) || ((enemynum == 5) && (index == 11)))
            {
                hlst = hlst + (sub1hlst + sub2hlst + sub3hlst) + exp;
            }
            //中国人に担々麺、インド人にカレーの場合、攻撃値に補正
            else if (((enemynum == 6) && (index == 9)) || ((enemynum == 7) && (index == 1)))
            {
                atkst = atkst + (sub1hlst + sub2hlst + sub3hlst) + exp;
            }

            //ゲームモードによるステータスの表示切替
            if (Form1.mode == 0)
            {
                AstLb.Text = "" + atkst;
                HstLb.Text = "" + hlst;
            }
            else if (Form1.mode == 1)
            {
                AstLb.Text = "???";
                HstLb.Text = "???";
            }

        }

    }
}
