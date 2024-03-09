using System.Drawing;

namespace test
{
    class Room1 : Room
    {

        Image img;
        Point point = new Point(0, 0);

        Point pos_point = new Point(150, 250);
        Point sti_point = new Point(200, 250);
        Point key_point = new Point(454, 332);
        Point box_point = new Point(500, 500);
        Point kai_point = new Point(500, 261);
        Point kay_point = new Point(536, 225);
        Point cube_point = new Point(736, 516);
        Point ori_point = new Point(315, 105);

        Point point_key2 = new Point(885, 520);
        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool pos = true;
        public bool sti = true;
        public bool key = true;
        public bool key2 = true;
        public bool box = true;
        public bool kai = false;
        public bool cube = false;
        public bool ori = false;

        public bool nyu = false;
        public bool k_nyu = false;

        public bool d_cl = false;

        public bool nyu_click = false;

        public bool moni = false;
        public bool moni_big = false;

        Ui ui = new Ui();
        Key key_nyu = new Key();

        //必須でも名前がちがくてもいい

        public void In(Ui ui2)//全体のUIと結びつける（必須）
        {
            ui = ui2;
        }
        public void In2(Key key2)//キーボード入力が必要な時に必要
        {
            key_nyu = key2;
        }
        bool a = true;
        public void Draw(Graphics gr)//描写（必須）変更なしでよい
        {
            /*
            if (a)
            {
                ui.Bl((int)Ui.Items.item37);
                a = false;
            }
            */
            if (all)//ゲーム画面の全体にいるか（ほぼ必須）＜私的にはあったほうがわかりやすい
            {
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
                if (key2 && cube)
                {
                    img = test.Properties.Resources.rm1orangekey;
                    gr.DrawImage(img, point_key2);
                }
                if (sti)
                {
                    img = test.Properties.Resources.rm1stick;
                    gr.DrawImage(img, sti_point);
                }
                if (pos)
                {
                    img = test.Properties.Resources.rm1posutor;
                    gr.DrawImage(img, pos_point);
                }
                if (key)
                {
                    img = test.Properties.Resources.rm1kagi;
                    gr.DrawImage(img, key_point);
                }
                if (box)
                {
                    img = test.Properties.Resources.rm1box;
                    gr.DrawImage(img, box_point);
                }
                if (kai)
                {
                    img = test.Properties.Resources.rm1kaidan;
                    gr.DrawImage(img, kai_point);
                    img = test.Properties.Resources.矢印2;
                    gr.DrawImage(img, kay_point);
                }
                if (cube)
                {
                    img = test.Properties.Resources.rm1dig;
                    gr.DrawImage(img, cube_point);
                }
                if (!ori)
                {

                    img = test.Properties.Resources.rm1ori1;
                    gr.DrawImage(img, ori_point);
                }
                else
                {
                    img = test.Properties.Resources.rm1ori2;
                    gr.DrawImage(img, 272, 173);
                }
            }//ここからはゲーム画面の全体ではなく拡大された後などの処理
            else if (/*!all && !nyu && */d_cl)//アイテム欄をダブルクリックされた後のクリック動作の描写（（all）の次など早めにかく）（必須）
            {
                ui.D_draw(gr);
            }
            else if (/*!all && !d_cl &&*/ nyu)//入力画面か
            {
                img = test.Properties.Resources.rm1nyu;
                gr.DrawImage(img, point);
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
                key_nyu.Draw(gr, 0);
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
            ui.Draw(gr);//下のアイテム欄描写（必須）
        }
        public int Loc(int x, int y)//ｘとｙで座標指定（必須）変更なしでよい
        {
            if (all)//描写の時と同じ
            {

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
                else if (x > 150 && x < 240 && y > 250 && y < 375 && pos)
                {


                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        pos = false;
                        ui.Bl((int)Ui.Items.item4);
                    }
                }
                else if (x > 150 && x < 240 && y > 250 && y < 375 && ui.item[ui.item_selet] == (int)Ui.Items.item4)
                {
                    ui.Dl(ui.item_selet);

                    pos = true;
                }





                if (x > 455 && x < 471 && y > 326 && y < 350 && ui.item[ui.item_selet] == (int)Ui.Items.item1 && key || x > 400 && x < 500 && y > 300 && y < 400 && ori && key)
                {

                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        key = false;
                        ui.Bl((int)Ui.Items.item2);
                    }
                }
                else if (x > 455 && x < 471 && y > 326 && y < 350 && ui.item[ui.item_selet] == (int)Ui.Items.item2 && ori)
                {
                    ui.Dl(ui.item_selet);
                    key = true;
                }


                if (x > 300 && x < 400 && y > 300 && y < 400 && ui.item[ui.item_selet] == (int)Ui.Items.item2 && !ori)
                {
                    ori = true;
                    Audio.Play_prison_open();
                }

                if (x > 495 && x < 555 && y > 510 && y < 570 && box && ori)
                {


                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        box = false;
                        ui.Bl((int)Ui.Items.item3);
                    }
                }
                else if (x > 500 && x < 600 && y > 400 && y < 600 && ui.item[ui.item_selet] == (int)Ui.Items.item3)
                {
                    ui.Dl(ui.item_selet);

                    box = true;
                }

                if (x > 775 && x < 850 && y > 450 && y < 475 && ori && !k_nyu)
                {
                    nyu = true;
                }

                if (x > 730 && x < 760 && y > 500 && y < 530 && ui.item[ui.item_selet] == (int)Ui.Items.item37)
                {
                    ui.Dl(ui.item_selet);

                    cube = true;
                }
                if (x > 885 && x < 900 && y > 520 && y < 550 && cube && key2)
                {
                    key2 = false;
                    ui.key[(int)Ui.Keys.orange] = true;
                    Menu.n_menu = true;
                    Audio.Play_menudis();
                }

                if (x > 700 && x < 862 && y > 240 && y < 360 && ori)
                {
                    moni_big = true;
                }
                if (x > 525 && x < 625 && y > 200 && y < 320 && kai)
                { 
                    Audio.Play_move();
                    return (int)Form1.RM.room2;//リターン文に矢印タップ時の次の部屋（必須）

                }

            }
            else if (/*!all&& !nyu &&*/ d_cl)//アイテム欄のダブルタップ確認（必須）変更なしでよい
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (nyu && !d_cl)//入力画面であり、ダブルクリックで拡大してない
            {
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    nyu = false;
                    nyu_click = false;//これがtrueになることで文字列確定

                }
                else if (x > 850 && x < 955 && y > 450 && y < 575)//確定
                {
                    nyu_click = true;
                }
            }
            else if (moni_big)
            {
                if (x > 840 && x < 865 && y > 540 && y < 565 && !moni)
                {
                    moni = true;
                    Audio.Play_display_on();
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    moni_big = false;
                }
            }

            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);//アイテム欄のタップ（必須）変更なしでよい
            }

            All();//ゲーム画面の全体にいるかどうかの判定（ほぼ必須）

            return (int)Form1.RM.room1;



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

        public void S_good(string str)//文字列が正しいかどうか
        {
            string str2 = "rlel";//答え
            if (str == str2)//確認
            {
                kai = true;//フラグ管理
                nyu = false;
                k_nyu = true;
                nyu_click = true;
                key_nyu.Nl();//初期化
                Menu.n_menu = true;
                Audio.Play_success();
                Audio.Play_menudis();
            }
            else
            {
                Audio.Play_failed();
                nyu_click = false;//再入力待ち、初期化
                key_nyu.Nl();
            }
            All();
        }

        public override void Nl()//タイトル画面に戻ってきた時のフラグ初期化（基本的には宣言したものすべて）
        {
            all = true;

            pos = true;
            sti = true;
            key = true;
            box = true;
            kai = false;
            cube = false;
            key2 = true;
            ori = false;

            nyu = false;
            k_nyu = false;
            nyu_click = false;
            d_cl = false;
            moni = false;
            moni_big = false;
        }

        public void All()//ゲーム画面の全体かどうか
        {
            if (d_cl || nyu || moni_big)
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
