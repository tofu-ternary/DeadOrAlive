using System.Drawing;

namespace test
{
    class Room15 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point g_r16 = new Point(25, 300);
        Point sntk = new Point(190, 170);

        public bool all = true;

        public bool stk = false;
        public bool l_dead = false;
        public bool end = false;

        public bool d_cl = false;

        Ui ui = new Ui();
        Key key_nyu = new Key();
        Mis mis = new Mis();

        public void In(Ui ui2)//全体のUIと結びつける（必須）
        {
            ui = ui2;
        }

        public void In3(Mis mis2)
        {
            mis = mis2;
        }

        public void Draw(Graphics gr)//描写（必須）変更なしでよい
        {
            if (all)//ゲーム画面の全体にいるか（ほぼ必須）＜私的にはあったほうがわかりやすい
            {
                img = test.Properties.Resources.RM15;
                gr.DrawImage(img, point);

                if (stk)
                {
                    img = test.Properties.Resources.rm15sentakushi;
                    gr.DrawImage(img, sntk);
                }
            }
            if (!d_cl && !stk)
            {
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, g_r16);
            }

            ui.Draw(gr);//下のアイテム欄描写（必須）
        }

        public int Loc(int x, int y)//ｘとｙで座標指定（必須）変更なしでよい
        {
            if (all)//描写の時と同じ
            {

            }
            else if (/*!all&& !nyu &&*/ d_cl)//アイテム欄のダブルタップ確認（必須）変更なしでよい//消さない
            {
                d_cl = ui.D_loc(x, y);
            }

            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);//アイテム欄のタップ（必須）変更なしでよい消さない
            }

            if (x > 910 && x < 980 && y > 320 && y < 410 && !stk)
            {
                Audio.Play_warning();
                stk = true;
            }

            if (x > 585 && x < 720 && y > 230 && y < 260 && stk)
            {
                stk = false;
                end = true;
            }

            if (x > 585 && x < 720 && y > 285 && y < 320 && stk)
            {
                stk = false;
            }

            if (x > 25 && x < 100 && y > 300 && y < 375 && !d_cl && !stk)
            {
                Audio.Play_move();
                return (int)Form1.RM.room16;
            }

            All();//ゲーム画面の全体にいるかどうかの判定（ほぼ必須）

            return (int)Form1.RM.room15;

        }

        public void D_Loc(int x, int y)//ダブルクリック判定（必須）変更なしでよい
        {//解説なし

            if (x > 25 && x < 125 && y > 650 && y < 750)
            {
                if (ui.item[0] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[0]);
                }
            }
            else if (x > 175 && x < 275 && y > 650 && y < 750)
            {
                if (ui.item[1] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[1]);
                }
            }
            else if (x > 325 && x < 425 && y > 650 && y < 750)
            {
                if (ui.item[2] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[2]);
                }
            }
            else if (x > 480 && x < 580 && y > 650 && y < 750)
            {
                if (ui.item[3] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[3]);
                }
            }
            else if (x > 620 && x < 720 && y > 650 && y < 750)
            {
                if (ui.item[4] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[4]);
                }
            }
        }
        public override void Nl()//タイトル画面に戻ってきた時のフラグ初期化（基本的には宣言したものすべて）
        {
            all = true;

            stk = false;
            l_dead = false;

            d_cl = false;
        }

        public void All()//ゲーム画面の全体かどうか
        {
            if (d_cl)
            {
                all = false;
            }
            else
            {
                all = true;
            }
        }


    }
}
