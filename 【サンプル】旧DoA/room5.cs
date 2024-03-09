using System.Drawing;

namespace test
{
    class Room5 : Room
    {

        Image img;
        Point point = new Point(0, 0);

        Point se_point = new Point(350, 485);
        Point tong_point = new Point(80, 390);

        Point arrowleft = new Point(25, 300);


        public bool all = true;

        public bool rei = false;
        public bool oprei = false;
        public bool or = false;

        public bool tana = false;
        public bool optana = false;
        public bool se = true;

        public bool tana2 = false;
        public bool optana2 = false;
        public bool tong = true;

        public bool nyu_click = false;


        public bool d_cl = false;


        Ui ui = new Ui();
        Key key_nyu = new Key();
        Mis mis = new Mis();
        Room19 r19 = new Room19();

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
        public void In4(Room19 c_r19)
        {
            r19 = c_r19;
        }

        public void Draw(Graphics gr)
        {


            if (d_cl)
            {
                ui.D_draw(gr);
            }
            else
            {

                if (all)
                {
                    img = test.Properties.Resources.RM5;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, arrowleft);
                }

                else if (tana)
                {
                    img = test.Properties.Resources.rm5tana;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);

                }
                else if (optana)
                {
                    img = test.Properties.Resources.rm5optana;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    if (se)
                    {
                        img = test.Properties.Resources.rm5se;
                        gr.DrawImage(img, se_point);
                    }

                }
                else if (tana2)
                {
                    img = test.Properties.Resources.rm5tana2;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);

                }
                else if (optana2)
                {
                    img = test.Properties.Resources.rm5optana2;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    if (tong)
                    {
                        img = test.Properties.Resources.tong;
                        gr.DrawImage(img, tong_point);
                    }

                }
                else if (rei && !or)
                {
                    img = test.Properties.Resources.rm5rei;
                    gr.DrawImage(img, point);
                    key_nyu.Draw(gr, 0);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);


                }
                else if (oprei || or)
                {
                    img = test.Properties.Resources.rm5oprei;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                }
            }


            ui.Draw(gr);
        }
        public int Loc(int x, int y)
        {
            if (d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else
            {
                if (all)
                {
                    if (x > 740 && x < 905 && y > 300 && y < 400)
                    {
                        all = false;
                        rei = true;
                        if (oprei)
                        {
                            Audio.Play_slide_door();
                        }
                    }
                    if (x > 580 && x < 730 && y > 40 && y < 160)
                    {
                        all = false;
                        tana = true;
                    }
                    if (x > 275 && x < 440 && y > 375 && y < 410)
                    {
                        all = false;
                        tana2 = true;
                    }
                    if (x > 120 && x < 275 && y > 370 && y < 525 && r19.bal_rate && ui.item[ui.item_selet] == (int)Ui.Items.item22)
                    {
                        ui.Dl(ui.item_selet);
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item22_2);
                            se = false;
                        }
                    }
                    if (x > 20 && x < 150 && y > 300 && y < 375)
                    {
                        Audio.Play_move();
                        return (int)Form1.RM.room6;
                    }
                }


                else if (tana)
                {
                    if (x > 220 && x < 1024 && y > 0 && y < 615)
                    {
                        tana = false;
                        optana = true;
                        Audio.Play_slide_door();
                    }
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        tana = false;
                        all = true;
                    }
                }
                else if (optana)
                {
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        optana = false;
                        all = true;
                    }
                    if (x > 495 && x < 570 && y > 535 && y < 625 && se)
                    {


                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item13);
                            se = false;
                        }
                    }
                    else if (x > 495 && x < 570 && y > 535 && y < 625 && ui.item[ui.item_selet] == (int)Ui.Items.item13)
                    {
                        ui.Dl(ui.item_selet);

                        se = true;
                    }
                }
                else if (tana2)
                {
                    if (x > 0 && x < 960 && y > 380 && y < 610)
                    {
                        tana2 = false;
                        optana2 = true;
                        Audio.Play_slide_door();
                    }
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        tana2 = false;
                        all = true;
                    }
                }
                else if (optana2)
                {
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        optana2 = false;
                        all = true;
                    }
                    if (x > 80 && x < 480 && y > 390 && y < 590 && tong)
                    {


                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item18);
                            tong = false;
                        }
                    }
                    else if (x > 80 && x < 480 && y > 390 && y < 590 && ui.item[ui.item_selet] == (int)Ui.Items.item18)
                    {
                        ui.Dl(ui.item_selet);

                        tong = true;
                    }
                }
                else if (rei && !or)
                {
                    if (x > 580 && x < 660 && y > 390 && y < 490)
                    {
                        nyu_click = true;
                        //or = true;

                    }
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        rei = false;
                        all = true;
                    }

                }
                else if (oprei || or)
                {
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        rei = false;
                        oprei = false;
                        all = true;
                    }
                    if (x > 0 && x < 1024 && y > 0 && y < 610 && ui.item[ui.item_selet] == (int)Ui.Items.icepaper_1)
                    {
                        ui.Dl(ui.item_selet);

                        mis.n_mis = true;
                        mis.qes[(int)Mis.QE.Qes10] = true;
                        Audio.Play_misdis();
                    }
                }
            }

            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room5;
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
            string str1 = "neo";
            if (str == str1)
            {
                oprei = true;
                or = true;
                rei = false;
                Audio.Play_success();
            }
            else
            {
                nyu_click = false;
                key_nyu.Nl();
                Audio.Play_failed();

            }
            All();
        }

        public override void Nl()
        {
            all = true;

            rei = false;
            oprei = false;

            tana = false;
            optana = false;
            se = true;

            nyu_click = false;

            d_cl = false;
        }

        public void All()
        {
            if (d_cl || rei || oprei || tana || optana || tana2 || optana2)
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