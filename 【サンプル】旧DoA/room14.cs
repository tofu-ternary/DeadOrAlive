using System.Drawing;

namespace test
{
    class Room14 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point arrowright = new Point(900, 300);

        Point point_item = new Point(500, 300);
        Point img_set = new Point(220, 310);
        Point imgbig_set = new Point(346, 515);
        Point point_pul = new Point(330, 320);
        Point point_ice = new Point(450, 450);
        Point point_nazo13 = new Point(300, 470);
        Point point_tyen = new Point(750, 340);
        Point point_img = new Point(200, 170);
        Point point_dri = new Point(830, 455);
        Point point_wri = new Point(550, 450);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        //       public bool tansu1open = false;
        public bool tansu1big = false;

        //       public bool tansu2open = false;
        public bool tansu2big = false;
        public bool tansu2open = false;

        public bool pulet_set = false;
        public bool imgbig = false;
        public bool pulet = true;
        public bool ice = true;
        public bool nazo13 = true;
        public bool draib = true;
        public bool tyen = true;

        public bool wri = true;

        public bool d_cl = false;



        Ui ui = new Ui();
        Mis mis = new Mis();
        public void In(Ui ui2)
        {
            ui = ui2;
        }
        public void In3(Mis mis2)
        {
            mis = mis2;
        }

        bool a = true;
        public void Draw(Graphics gr)
        {
            /*    if (a)
                {
                    ui.Bl((int)Ui.Items.item33);
                    a = false;
                }*/
            if (all)
            {
                img = test.Properties.Resources.RM14;
                gr.DrawImage(img, point);

                if (pulet_set)
                {
                    img = test.Properties.Resources.rm14imgset;
                    gr.DrawImage(img, img_set);
                    img = test.Properties.Resources.rm14imgopen;
                    gr.DrawImage(img, point_img);
                }
                else
                {
                    img = test.Properties.Resources.rm14img;
                    gr.DrawImage(img, point_img);
                }

                if (ice)
                {
                    img = test.Properties.Resources.rm14icepape;
                    gr.DrawImage(img, point_ice);
                }

                if (draib)
                {
                    img = test.Properties.Resources.rm14dri;
                    gr.DrawImage(img, point_dri);
                }

                if (wri)
                {
                    img = test.Properties.Resources.rm14writer;
                    gr.DrawImage(img, point_wri);
                }


                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);
            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (tansu1big)
            {

                img = test.Properties.Resources.rm14tansu1open;
                gr.DrawImage(img, point);
                if (nazo13)
                {
                    img = test.Properties.Resources.rm14nazo13;
                    gr.DrawImage(img, point_nazo13);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }
            else if (tansu2big)
            {
                img = test.Properties.Resources.rm14tansu2open;
                gr.DrawImage(img, point);
                if (tyen)
                {
                    img = test.Properties.Resources.rm14tyen;
                    gr.DrawImage(img, point_tyen);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }
            else if (imgbig)
            {
                if (pulet_set)
                {

                    img = test.Properties.Resources.rm14imgbigopen;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.rm14imgbig_set;
                    gr.DrawImage(img, imgbig_set);
                    if (pulet)
                    {
                        img = test.Properties.Resources.rm14puleto;
                        gr.DrawImage(img, point_pul);
                    }
                }
                else
                {
                    img = test.Properties.Resources.rm14imgbig;
                    gr.DrawImage(img, point);
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


                if (x > 825 && x < 840 && y > 455 && y < 492 && draib)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        draib = false;
                        ui.Bl((int)Ui.Items.item14);
                    }
                }
                else if (x > 825 && x < 840 && y > 455 && y < 492 && !draib && ui.item[ui.item_selet] == (int)Ui.Items.item14)
                {
                    ui.Dl(ui.item_selet);
                    draib = true;
                }

                if (x > 455 && x < 510 && y > 450 && y < 466 && ice)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        ice = false;
                        ui.Bl((int)Ui.Items.icepaper_1);
                    }
                }
                else if (x > 455 && x < 510 && y > 450 && y < 466 && !ice && ui.item[ui.item_selet] == (int)Ui.Items.icepaper_1)
                {
                    ui.Dl(ui.item_selet);
                    ice = true;
                }

                if (x > 545 && x < 570 && y > 450 && y < 480 && wri)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        wri = false;
                        ui.Bl((int)Ui.Items.item16);
                    }
                }
                else if (x > 545 && x < 570 && y > 450 && y < 480 && !wri && ui.item[ui.item_selet] == (int)Ui.Items.item16)
                {
                    ui.Dl(ui.item_selet);
                    wri = true;
                }


                if (x > 60 && x < 110 && y > 530 && y < 560)
                {
                    Audio.Play_slide_door();
                    tansu1big = true;
                }
                if (x > 120 && x < 170 && y > 470 && y < 505)
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item33 || tansu2open)
                    {
                        Audio.Play_slide_door();
                        tansu2big = true;
                        tansu2open = true;
                        if (ui.item[ui.item_selet] == (int)Ui.Items.item33)
                        {
                            ui.Dl(ui.item_selet);
                        }
                    }
                }

                if (x > 195 && x < 285 && y > 155 && y < 280)
                {
                    imgbig = true;
                }

                if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room13;
                }
            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (tansu1big)
            {
                if (x > 350 && x < 550 && y > 500 && y < 580)
                {
                    mis.n_mis = true;
                    nazo13 = false;
                    mis.qes[(int)Mis.QE.Qes13] = true;
                    Audio.Play_misdis();
                }

                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    tansu1big = false;
                }
            }
            else if (tansu2big)
            {
                if (x > 750 && x < 1000 && y > 340 && y < 580 && tyen)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        ui.Bl((int)Ui.Items.item34);
                        tyen = false;
                    }
                }
                else if (x > 750 && x < 1000 && y > 340 && y < 580 && !tyen && ui.item[ui.item_selet] == (int)Ui.Items.item34)
                {
                    ui.Dl(ui.item_selet);
                    tyen = true;
                }

                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    tansu2big = false;
                }
            }
            else if (imgbig)
            {
                if (pulet_set)
                {
                    if (x > 430 && x < 600 && y > 340 && y < 470 && pulet)
                    {
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item30);
                            pulet = false;
                        }
                    }
                    else if (x > 430 && x < 600 && y > 340 && y < 460 && !pulet && ui.item[ui.item_selet] == (int)Ui.Items.item30)
                    {
                        ui.Dl(ui.item_selet);
                        pulet = true;
                    }
                    if (x > 345 && x < 663 && y > 515 && y < 580)
                    {
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            pulet_set = false;
                            ui.Bl((int)Ui.Items.item28);
                        }

                    }

                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        imgbig = false;
                    }
                }
                else
                {
                    if (x > 345 && x < 663 && y > 515 && y < 580 && ui.item[ui.item_selet] == (int)Ui.Items.item28 && !pulet_set)
                    {
                        pulet_set = true;
                        Audio.Play_plate_set();
                        ui.Dl(ui.item_selet);
                    }

                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        imgbig = false;
                    }
                }
            }


            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room14;
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
        /*
        public void S_good(string str)
        {
            string str2 = "abcd";
            if (str == str2)
            {

            }
            else
            {

            }
            All();
        }
        */
        public override void Nl()
        {
            all = true;

            tansu1big = false;
            tansu2big = false;
            tansu2open = false;

            pulet_set = false;
            imgbig = false;
            pulet = true;
            ice = true;
            nazo13 = true;
            draib = true;
            tyen = true;
            wri = true;

            d_cl = false;
        }

        public void All()
        {
            if (d_cl || tansu1big || tansu2big || imgbig)
            {
                all = false;
            }
            else
            {
                all = true;
            }
        }
        /*
        public Ui N_ui()
        {
            return ui;
        }
        */
    }
}
