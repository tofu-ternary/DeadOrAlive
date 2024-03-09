using System.Drawing;

namespace test
{
    class Room19 : Room
    {

        Image img;
        Point point = new Point(0, 0);

        Point point_bal = new Point(670, 233);
        Point point_key = new Point(320, 170);
        Point[] b_in = { new Point(315, 79), new Point(384, 77), new Point(456, 78), new Point(535, 77), new Point(612, 77) };
        Point[] l_in = { new Point(320, 30), new Point(390, 30), new Point(462, 30), new Point(540, 30), new Point(615, 30) };
        Point lanp = new Point(695, 155);

        Point tele_right = new Point(900, 275);
        Point tele_left = new Point(25, 275);
        Point tele_up = new Point(450, 10);
        Point tele_down = new Point(450, 500);



        Point arrowright = new Point(900, 300);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool boxbig = false;
        public bool boxopen = false;

        public bool bal = false;
        public bool bal_rate = false;

        public bool bulekey = true;

        public bool tele_big = false;
        public int tele_move = 12;

        public bool in_big = false;
        public bool[] tele_in = { false, false, false, false, false };
        public bool pulet = false;

        public bool nyu_click = false;

        public int left = 0;
        public int right = 0;
        public int up = 0;
        public int down = 0;


        public bool d_cl = false;


        Ui ui = new Ui();
        Key key_nyu = new Key();
        Mis mis = new Mis();

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

        bool a = true;
        public void Draw(Graphics gr)
        {/*
            if (a)
            {
                a = false;
                ui.Bl((int)Ui.Items.item19);
            }*/



            if (all)
            {
                img = test.Properties.Resources.RM19;
                gr.DrawImage(img, point);

                if (bal)
                {
                    img = test.Properties.Resources.rm19bal;
                    gr.DrawImage(img, point_bal);

                }
                if (bal_rate)
                {
                    img = test.Properties.Resources.rm19llanp_green;
                    gr.DrawImage(img, lanp);
                }
                else
                {
                    img = test.Properties.Resources.rm19llanp_red;
                    gr.DrawImage(img, lanp);
                }

                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);

            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (boxbig)
            {
                if (boxopen)
                {
                    img = test.Properties.Resources.rm19box_open;
                    gr.DrawImage(img, point);
                    if (bulekey)
                    {
                        img = test.Properties.Resources.rm19bulekey;
                        gr.DrawImage(img, point_key);
                    }
                }
                else
                {
                    img = test.Properties.Resources.rm19box;
                    gr.DrawImage(img, point);
                    key_nyu.Draw(gr, 0);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);

            }
            else if (tele_big)
            {
                img = Star_img(tele_move);
                gr.DrawImage(img, point);
                img = test.Properties.Resources.rm19tele;
                gr.DrawImage(img, point);

                if (tele_in[0])
                {
                    img = test.Properties.Resources.rm19telered;
                    gr.DrawImage(img, point);
                }
                if (tele_in[1])
                {
                    img = test.Properties.Resources.rm19telebule;
                    gr.DrawImage(img, point);
                }
                if (tele_in[2])
                {
                    img = test.Properties.Resources.rm19teleyellow;
                    gr.DrawImage(img, point);
                }
                if (tele_in[3])
                {
                    img = test.Properties.Resources.rm19telegreen;
                    gr.DrawImage(img, point);
                }
                if (tele_in[4])
                {
                    img = test.Properties.Resources.rm19telepa;
                    gr.DrawImage(img, point);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
                gr.DrawImage(img, tele_left);
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, tele_right);
                img = test.Properties.Resources.矢印2;
                gr.DrawImage(img, tele_up);
                img = test.Properties.Resources.矢印4;
                gr.DrawImage(img, tele_down);

            }
            else if (in_big)
            {
                img = test.Properties.Resources.rm19in;
                gr.DrawImage(img, point);
                if (tele_in[0])
                {
                    img = test.Properties.Resources.rm19inred;
                    gr.DrawImage(img, b_in[0]);
                    img = test.Properties.Resources.rm19llanp_green;
                    gr.DrawImage(img, l_in[0]);
                }
                else
                {
                    img = test.Properties.Resources.rm19llanp_red;
                    gr.DrawImage(img, l_in[0]);
                }
                if (tele_in[1])
                {
                    img = test.Properties.Resources.rm19inbule;
                    gr.DrawImage(img, b_in[1]);
                    img = test.Properties.Resources.rm19llanp_green;
                    gr.DrawImage(img, l_in[1]);
                }
                else
                {
                    img = test.Properties.Resources.rm19llanp_red;
                    gr.DrawImage(img, l_in[1]);
                }
                if (tele_in[2])
                {
                    img = test.Properties.Resources.rm19inyellow;
                    gr.DrawImage(img, b_in[2]);
                    img = test.Properties.Resources.rm19llanp_green;
                    gr.DrawImage(img, l_in[2]);
                }
                else
                {
                    img = test.Properties.Resources.rm19llanp_red;
                    gr.DrawImage(img, l_in[2]);
                }
                if (tele_in[3])
                {
                    img = test.Properties.Resources.rm19ingreen;
                    gr.DrawImage(img, b_in[3]);
                    img = test.Properties.Resources.rm19llanp_green;
                    gr.DrawImage(img, l_in[3]);
                }
                else
                {
                    img = test.Properties.Resources.rm19llanp_red;
                    gr.DrawImage(img, l_in[3]);
                }
                if (tele_in[4])
                {
                    img = test.Properties.Resources.rm19inpa;
                    gr.DrawImage(img, b_in[4]);
                    img = test.Properties.Resources.rm19llanp_green;
                    gr.DrawImage(img, l_in[4]);
                }
                else
                {
                    img = test.Properties.Resources.rm19llanp_red;
                    gr.DrawImage(img, l_in[4]);
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

                if (x > 670 && x < 740 && y > 240 && y < 310 && ui.item[ui.item_selet] == (int)Ui.Items.item19 && !bal)
                {
                    bal = true;
                    ui.Dl(ui.item_selet);
                }
                else if (x > 670 && x < 740 && y > 240 && y < 310 && bal && !bal_rate)
                {
                    Audio.Play_water_fall();
                    bal_rate = true;
                }
                else if (x > 565 && x < 590 && y > 305 && y < 338)
                {
                    tele_big = true;
                }
                else if (x > 530 && x < 550 && y > 315 && y < 350)
                {
                    in_big = true;
                }
                else if (x > 150 && x < 260 && y > 390 && y < 425)
                {
                    boxbig = true;
                }




                if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room18;
                }
            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (boxbig)
            {
                if (boxopen)
                {
                    if (bulekey)
                    {
                        if (x > 380 && x < 580 && y > 200 && y < 440)
                        {
                            bulekey = false;
                            ui.key[1] = true;
                            Menu.n_menu = true;
                            Audio.Play_menudis();
                        }
                    }
                }
                else
                {
                    if (x > 213 && x < 295 && y > 460 && y < 530)
                    {
                        nyu_click = true;
                    }
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    boxbig = false;
                }
            }
            else if (tele_big)
            {
                if (x > 30 && x < 125 && y > 285 && y < 375 && left != 2)
                {
                    tele_move--;
                    left++;
                    right--;
                }
                else if (x > 450 && x < 550 && y > 15 && y < 115 && up != 2)
                {
                    tele_move -= 5;
                    up++;
                    down--;
                }
                else if (x > 450 && x < 550 && y > 500 && y < 600 && down != 2)
                {
                    tele_move += 5;
                    down++;
                    up--;
                }
                else if (x > 905 && x < 1000 && y > 280 && y < 375 && right != 2)
                {
                    tele_move++;
                    right++;
                    left--;
                }



                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    tele_big = false;
                    tele_move = 12;
                    right = 0;
                    left = 0;
                    up = 0;
                    down = 0;
                }
            }
            else if (in_big)
            {
                if (pulet)
                {
                    if (x > 315 && x < 344 && y > 79 && y < 577)
                    {
                        if (!tele_in[0])
                        {
                            tele_in[0] = true;
                            Audio.Play_mato_put();
                        }
                        else
                        {
                            tele_in[0] = false;
                            Audio.Play_mato_put();
                        }
                    }
                    else if (x > 384 && x < 413 && y > 77 && y < 575)
                    {
                        if (!tele_in[1])
                        {
                            tele_in[1] = true;
                            Audio.Play_mato_put();
                        }
                        else
                        {
                            tele_in[1] = false;
                            Audio.Play_mato_put();
                        }
                    }
                    else if (x > 456 && x < 485 && y > 78 && y < 576)
                    {
                        if (!tele_in[2])
                        {
                            tele_in[2] = true;
                            Audio.Play_mato_put();
                        }
                        else
                        {
                            tele_in[2] = false;
                            Audio.Play_mato_put();
                        }
                    }
                    else if (x > 535 && x < 564 && y > 77 && y < 575)
                    {
                        if (!tele_in[3])
                        {
                            tele_in[3] = true;
                            Audio.Play_mato_put();
                        }
                        else
                        {
                            tele_in[3] = false;
                            Audio.Play_mato_put();
                        }
                    }
                    else if (x > 612 && x < 641 && y > 77 && y < 575)
                    {
                        if (!tele_in[4])
                        {
                            tele_in[4] = true;
                            Audio.Play_mato_put();
                        }
                        else
                        {
                            tele_in[4] = false;
                            Audio.Play_mato_put();
                        }
                    }
                }
                else if (!pulet)
                {
                    if (x > 275 && x < 695 && y > 0 && y < 608)
                    {
                        if (ui.item[ui.item_selet] == (int)Ui.Items.item30)
                        {
                            ui.Dl(ui.item_selet);
                            pulet = true;
                            for (int i = 0; i < 5; i++)
                            {
                                tele_in[i] = true;
                            }
                            Audio.Play_mato_put();
                        }
                    }
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    in_big = false;
                }
            }


            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room19;
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
            string str1 = "lost";
            if (str == str1)
            {
                Audio.Play_success();
                boxopen = true;
            }
            else
            {
                Audio.Play_failed();
                nyu_click = false;
                key_nyu.Nl();

            }
            All();
        }

        public override void Nl()
        {
            all = true;

            boxbig = false;
            boxopen = false;

            bal = false;
            bal_rate = false;

            bulekey = true;

            tele_big = false;
            tele_move = 12;

            in_big = false;
            for (int i = 0; i < 5; i++)
            {
                tele_in[i] = false;
            }
            pulet = false;

            nyu_click = false;

            left = 0;
            right = 0;
            up = 0;
            down = 0;

            d_cl = false;
        }

        public void All()
        {
            if (d_cl || boxbig || tele_big || in_big)
            {
                all = false;
            }
            else
            {
                all = true;
            }
        }
        public Image Star_img(int m)
        {
            switch (m)
            {
                case 0:
                    return test.Properties.Resources.rm19hosi_1;
                case 1:
                    return test.Properties.Resources.rm19hosi_2;
                case 2:
                    return test.Properties.Resources.rm19hosi_3;
                case 3:
                    return test.Properties.Resources.rm19hosi_4;
                case 4:
                    return test.Properties.Resources.rm19hosi_5;
                case 5:
                    return test.Properties.Resources.rm19hosi_6;
                case 6:
                    return test.Properties.Resources.rm19hosi_7;
                case 7:
                    return test.Properties.Resources.rm19hosi_8;
                case 8:
                    return test.Properties.Resources.rm19hosi_9;
                case 9:
                    return test.Properties.Resources.rm19hosi_10;
                case 10:
                    return test.Properties.Resources.rm19hosi_11;
                case 11:
                    return test.Properties.Resources.rm19hosi_12;
                case 12:
                    return test.Properties.Resources.rm19hosi_13;
                case 13:
                    return test.Properties.Resources.rm19hosi_14;
                case 14:
                    return test.Properties.Resources.rm19hosi_15;
                case 15:
                    return test.Properties.Resources.rm19hosi_16;
                case 16:
                    return test.Properties.Resources.rm19hosi_17;
                case 17:
                    return test.Properties.Resources.rm19hosi_18;
                case 18:
                    return test.Properties.Resources.rm19hosi_19;
                case 19:
                    return test.Properties.Resources.rm19hosi_20;
                case 20:
                    return test.Properties.Resources.rm19hosi_21;
                case 21:
                    return test.Properties.Resources.rm19hosi_22;
                case 22:
                    return test.Properties.Resources.rm19hosi_23;
                case 23:
                    return test.Properties.Resources.rm19hosi_24;
                case 24:
                    return test.Properties.Resources.rm19hosi_25;
                default:
                    return test.Properties.Resources.rm19hosi_1;

            }
        }
    }

}