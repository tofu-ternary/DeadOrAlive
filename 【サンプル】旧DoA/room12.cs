using System.Drawing;

namespace test
{
    class Room12 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point point_kinko = new Point(200, 200);
        Point point_tansu = new Point(500, 200);

        Point point_cu = new Point(150, 330);
        Point point_tan = new Point(300, 300);

        Point arrowleft = new Point(25, 300);
        Point arrowright = new Point(900, 300);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool moni_big = false;
        public int moni_num = 0;
        public bool moni_suc = false;

        public bool kin_big = false;
        public bool kin_open = false;


        public bool tansu1_big = false;
        public bool tansu1_open = false;
        public bool tansu2_big = false;

        public bool nyu_click = false;

        public bool nazo14 = true;
        public bool cube = true;
        public bool b_key = true;

        public bool d_cl = false;


        Ui ui = new Ui();
        Key key_nyu = new Key();
        Mis mis = new Mis();

        Room17 r17 = new Room17();

        public void In(Ui ui2)
        {
            ui = ui2;
        }

        public void In2(Key key2)
        {
            key_nyu = key2;
        }

        public void In3(Mis mis2)
        {
            mis = mis2;
        }

        public void In4(Room17 c_r17)
        {
            r17 = c_r17;
        }
        public void Draw(Graphics gr)
        {
            if (all)
            {


                img = test.Properties.Resources.RM12;
                gr.DrawImage(img, point);


                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, arrowleft);
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);

            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (moni_big)
            {
                switch (moni_num)
                {
                    case 0:
                        img = test.Properties.Resources.rm12moni_1;
                        gr.DrawImage(img, point);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point);
                        break;
                    case 1:
                        img = test.Properties.Resources.rm12moni_2;
                        gr.DrawImage(img, point);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point);
                        break;
                    case 2:
                        img = test.Properties.Resources.rm12moni_3;
                        gr.DrawImage(img, point);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point);
                        break;
                    case 3:
                        break;
                }
                key_nyu.Draw(gr, 0);
            }
            else if (tansu1_big && r17.box_move == 2)
            {
                img = test.Properties.Resources.rm12tansu1;
                gr.DrawImage(img, point);
                if (nazo14)
                {
                    img = test.Properties.Resources.rm12nazo14;
                    gr.DrawImage(img, point_tan);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }
            else if (tansu2_big)
            {
                img = test.Properties.Resources.rm12tansu2;
                gr.DrawImage(img, point);
                if (b_key)
                {
                    img = test.Properties.Resources.rm12key;
                    gr.DrawImage(img, point_tan);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }
            else if (kin_big)
            {
                if (kin_open)
                {
                    img = test.Properties.Resources.rm12kinkobig_open;
                    gr.DrawImage(img, point);
                    if (cube)
                    {
                        img = test.Properties.Resources.rm12cube;
                        gr.DrawImage(img, point_cu);
                    }
                }
                else
                {
                    img = test.Properties.Resources.rm12kinkobig;
                    gr.DrawImage(img, point);
                    key_nyu.Draw(gr, 1);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }
            ui.Draw(gr);
        }
        public int Loc(int x, int y)
        {
            if (all)
            {

                if (x > 256 && x < 620 && y > 129 && y < 360)
                {
                    if (!moni_suc)
                    {
                        Audio.Play_display_on();
                        moni_big = true;
                    }
                }
                if (x > 695 && x < 860 && y > 380 && y < 445 && r17.box_move == 2)
                {
                    Audio.Play_slide_door();
                    tansu1_big = true;
                }
                if (x > 695 && x < 860 && y > 450 && y < 510 && moni_suc)
                {
                    Audio.Play_slide_door();
                    tansu2_big = true;
                }
                if (x > 795 && x < 850 && y > 315 && y < 370)
                {
                    kin_big = true;
                }

                if (x > 20 && x < 150 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room13;
                }
                else if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room11;
                }
            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (moni_big)
            {
                if (x > 770 && x < 970 && y > 505 && y < 565)
                {
                    nyu_click = true;
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    moni_big = false;
                    nyu_click = false;
                }

            }
            else if (kin_big)
            {
                if (kin_open)
                {
                    if (x > 340 && x < 510 && y > 400 && y < 595 && cube)
                    {
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            cube = false;
                            ui.Bl((int)Ui.Items.item37);
                        }

                    }
                    else if (x > 340 && x < 510 && y > 400 && y < 595 && ui.item[ui.item_selet] == (int)Ui.Items.item37)
                    {
                        ui.Dl(ui.item_selet);
                        cube = true;
                    }
                }
                else
                {
                    if (x > 668 && x < 720 && y > 479 && y < 570)
                    {
                        nyu_click = true;
                    }
                }

                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    kin_big = false;
                }

            }
            else if (tansu1_big)
            {
                if (x > 335 && x < 640 && y > 310 && y < 430 && nazo14)
                {
                    mis.n_mis = true;
                    nazo14 = false;
                    mis.qes[(int)Mis.QE.Qes14] = true;
                    Audio.Play_misdis();
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    tansu1_big = false;

                }
            }
            else if (tansu2_big)
            {
                if (x > 435 && x < 540 && y > 360 && y < 450 && b_key)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        b_key = false;
                        ui.Bl((int)Ui.Items.item35);
                    }

                }
                else if (x > 435 && x < 540 && y > 360 && y < 450 && ui.item[ui.item_selet] == (int)Ui.Items.item35)
                {
                    ui.Dl(ui.item_selet);
                    b_key = true;
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    tansu2_big = false;

                }
            }



            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room12;
        }

        public void D_Loc(int x, int y)
        {

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

        public void S_good(string str)
        {
            string str1 = "43";
            string str2 = "2";
            string str3 = "14";
            string str4 = "human";
            if (moni_big)
            {
                if (str == str1 && moni_num == 0)
                {
                    moni_num = 1;
                    nyu_click = false;
                    key_nyu.Nl();
                    Audio.Play_success();
                }
                else if (str == str2 && moni_num == 1)
                {
                    moni_num = 2;
                    nyu_click = false;
                    key_nyu.Nl();
                    Audio.Play_success();
                }
                else if (str == str3 && moni_num == 2)
                {
                    moni_num = 3;
                    nyu_click = false;
                    moni_suc = true;
                    moni_big = false;
                    key_nyu.Nl();
                    Audio.Play_success();
                }
                else
                {
                    nyu_click = false;
                    key_nyu.Nl();
                    Audio.Play_failed();
                }
            }
            else if (kin_big && !kin_open)
            {
                if (str == str4)
                {
                    kin_open = true;
                    nyu_click = false;
                    key_nyu.Nl();
                    Audio.Play_success();
                }
                else
                {
                    nyu_click = false;
                    key_nyu.Nl();
                    Audio.Play_failed();
                }
            }
            All();
        }

        public override void Nl()
        {
            all = true;

            moni_big = false;
            moni_num = 0;
            moni_suc = false;

            kin_big = false;
            kin_open = false;

            tansu1_big = false;
            tansu1_open = false;
            tansu2_big = false;

            nyu_click = false;

            nazo14 = true;
            cube = true;
            b_key = true;

            d_cl = false;
        }

        public void All()
        {
            if (d_cl || kin_big || tansu1_big || tansu2_big || moni_big)
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