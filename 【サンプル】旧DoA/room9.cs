using System.Drawing;

namespace test
{
    class Room9 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point oyu_p = new Point(24, 504);
        Point key_p = new Point(105, 525);
        Point ygr_p = new Point(225, 250);
        Point kbm_p = new Point(325, 290);
        Point yka_p = new Point(594, 508);
        Point g_r8 = new Point(900, 300);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool hro = false;
        public bool key = true;

        public bool ygr = true;
        public bool kbm = false;

        public bool l_dead = false;
        public bool yka = false;

        public bool d_cl = false;

        //public bool pos = true;

        Ui ui = new Ui();
        Key key_nyu = new Key();
        Mis mis = new Mis();
        Room19 r19 = new Room19();

        //必須でも名前がちがくてもいい

        public void In(Ui ui2)//全体のUIと結びつける（必須）
        {
            ui = ui2;
        }

        /*
        public void In2(Key key2)//キーボード入力が必要な時に必要
        {
            key_nyu = key2;
        }
        */
        public void In3(Mis mis2)
        {
            mis = mis2;
        }
        public void In4(Room19 c_r19)
        {
            r19 = c_r19;
        }

        public void Draw(Graphics gr)//描写（必須）変更なしでよい
        {
            if (all)//ゲーム画面の全体にいるか（ほぼ必須）＜私的にはあったほうがわかりやすい
            {
                img = test.Properties.Resources.RM9;
                gr.DrawImage(img, point);
                /*
                if (!moni)//部屋のフラグ
                {
                    img = test.Properties.Resources.RM1;
                    gr.DrawImage(img, point);
                }
                else if (moni)
                {
                    img = test.Properties.Resources.RM1_2;
                    gr.DrawImage(img, point);
                }
                */

                if (yka)
                {
                    img = test.Properties.Resources.rm9yuka;
                    gr.DrawImage(img, yka_p);
                }

                if (!hro)
                {
                    img = test.Properties.Resources.rm9oyu;
                    gr.DrawImage(img, oyu_p);
                }
                else if (hro)
                {
                    if (key)
                    {
                        img = test.Properties.Resources.rm9kagi;
                        gr.DrawImage(img, key_p);
                    }
                }

                if (ygr)
                {
                    img = test.Properties.Resources.rm9yogore;
                    gr.DrawImage(img, ygr_p);
                }

                if (kbm)
                {
                    img = test.Properties.Resources.rm9kubomi;
                    gr.DrawImage(img, kbm_p);
                }

            }//ここからはゲーム画面の全体ではなく拡大された後などの処理
            else if (/*!all && !nyu && */d_cl)//アイテム欄をダブルクリックされた後のクリック動作の描写（（all）の次など早めにかく）（必須）
            {
                ui.D_draw(gr);
            }
            /*
            else if (//!all && !d_cl &&// nyu) 入力画面か
            {
                img = test.Properties.Resources.rm1nyu;
                gr.DrawImage(img, point);
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
                key_nyu.Draw(gr);
            }
            else if (moni_big)//モニター拡大か
            {
                if (!moni)
                {
                    img = test.Properties.Resources.rm1moni;
                    gr.DrawImage(img, point);
                }
                else
                {
                    img = test.Properties.Resources.rm1moni_2;
                    gr.DrawImage(img, point);

                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }
            */
            if (!d_cl)
            {
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, g_r8);
            }

            ui.Draw(gr);//下のアイテム欄描写（必須）
        }

        bool a = true;
        public int Loc(int x, int y)//ｘとｙで座標指定（必須）変更なしでよい
        {
            if (all)//描写の時と同じ
            {
                /*
                if (a)
                {
                    a = false;
                    ui.Bl((int)Ui.Items.item21);
                    ui.Bl((int)Ui.Items.item13);
                    ui.Bl((int)Ui.Items.item12);
                }
                */
                if (x > 24 && x < 393 && y > 504 && y < 557 && !hro)
                {
                    hro = true;
                    Audio.Play_water_fall();
                }

                else if (x > 105 && x < 130 && y > 525 && y < 550 && hro && key)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        key = false;
                        ui.Bl((int)Ui.Items.item20);
                    }
                }
                else if (x > 105 && x < 130 && y > 525 && y < 550 && hro && !key && ui.item[ui.item_selet] == (int)Ui.Items.item20)
                {
                    ui.Dl(ui.item_selet);

                    key = true;
                }

                else if (x > 550 && x < 590 && y > 400 && y < 410)
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item21)
                    {
                        ui.Dl(ui.item_selet);

                        ui.Bl((int)Ui.Items.item21_2);
                    }
                    else if (ui.item[ui.item_selet] == (int)Ui.Items.item21_1)
                    {
                        ui.Dl(ui.item_selet);

                        ui.Bl((int)Ui.Items.item21_3);
                    }
                }

                else if (x > 690 && x < 730 && y > 400 && y < 410)
                {
                    if (r19.bal_rate)
                    {
                        if (ui.item[ui.item_selet] == (int)Ui.Items.item21)
                        {
                            ui.Dl(ui.item_selet);

                            ui.Bl((int)Ui.Items.item21_1);
                        }
                        else if (ui.item[ui.item_selet] == (int)Ui.Items.item21_2)
                        {
                            ui.Dl(ui.item_selet);

                            ui.Bl((int)Ui.Items.item21_3);
                        }
                    }
                }

                else if (x > 420 && x < 880 && y > 510 && y < 610)
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item21_1)
                    {
                        ui.Dl(ui.item_selet);

                        ui.Bl((int)Ui.Items.item21);
                    }
                    else if (ui.item[ui.item_selet] == (int)Ui.Items.item21_2)
                    {
                        Audio.Play_water_spill();
                        l_dead = true;
                        ui.Dl(ui.item_selet);

                        ui.Bl((int)Ui.Items.item21);
                    }
                    else if (ui.item[ui.item_selet] == (int)Ui.Items.item21_3)
                    {
                        Audio.Play_water_spill();
                        yka = true;

                        ui.Dl(ui.item_selet);

                        ui.Bl((int)Ui.Items.item21);
                    }
                }

                else if (x > 225 && x < 425 && y > 250 && y < 450 && ygr && ui.item[ui.item_selet] == (int)Ui.Items.item13)
                {
                    ygr = false;
                    Audio.Play_clean_wall();
                    ui.Dl(ui.item_selet);
                }

                else if (x > 325 && x < 360 && y > 290 && y < 325 && !ygr && ui.item[ui.item_selet] == (int)Ui.Items.item12)
                {
                    kbm = true;
                    Audio.Play_stair_discovery();
                    Menu.n_menu = true;
                    Audio.Play_menudis();
                    ui.Dl(ui.item_selet);
                }

                /*
                if (x > 200 && x < 230 && y > 250 && y < 365 && sti && !pos)
                {


                    if (ui.item[4] == (int)Ui.Items.error)//ui.item[]で自分の持ち物０～４　アイテム（４）がerror(空)だったら
                    {
                        sti = false;
                        ui.Bl((int)Ui.Items.item1);//アイテム欄にitem1を追加
                    }
                }
                else if (x > 200 && x < 230 && y > 250 && y < 365 && ui.item[ui.item_selet] == (int)Ui.Items.item1 && !pos)//ui.item_selectは自分のアイテム欄の選択場所
                {//座標指定+アイテム選択がItem１+pos（ポスターがあるかないか）がないか
                    ui.Dl(ui.item_selet);//アイテム選択がされているアイテムを消す

                    sti = true;

                }

                if (x > 500 && x < 700 && y > 200 && y < 400 && kai)
                {
                    return (int)Form1.RM.room2;//リターン文に矢印タップ時の次の部屋（必須）
                }
                */

            }

            else if (/*!all&& !nyu &&*/ d_cl)//アイテム欄のダブルタップ確認（必須）変更なしでよい//消さない
            {
                d_cl = ui.D_loc(x, y);
            }

            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);//アイテム欄のタップ（必須）変更なしでよい消さない
            }

            if (x > 900 && x < 1025 && y > 300 && y < 375 && !d_cl)
            {
                Audio.Play_move();
                return (int)Form1.RM.room8;
            }

            All();//ゲーム画面の全体にいるかどうかの判定（ほぼ必須）

            return (int)Form1.RM.room9;



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

            hro = false;
            key = true;

            ygr = true;
            kbm = false;

            l_dead = false;
            yka = false;

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

        /*public Ui N_ui()//いらない（）
        {
            return ui;
        }
        */
    }
}
