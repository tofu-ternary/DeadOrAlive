using System.Drawing;

namespace test
{
    class Room6 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point greennum1 = new Point(205, 73);
        Point greennum2 = new Point(245, 73);
        Point[] points_dish = { new Point(305, 430), new Point(370, 420), new Point(555, 420), new Point(620, 430) };
        Point[] points_dool = { new Point(200, 390), new Point(390, 357), new Point(575, 357), new Point(725, 390) };
        Point point_depression = new Point(570, 175);
        Point point_nazo5 = new Point(570, 185);
        Point point_fire = new Point(400, 350);
        Point point_maki = new Point(300, 460);
        Point point_pulet = new Point(420, 480);
        Point point_nazo7 = new Point(340, 400);
        Point point_saku = new Point(234, 401);

        Point arrowleft = new Point(25, 300);
        Point arrowright = new Point(900, 300);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool depression = false;
        public bool dish = true;
        public bool dish_wash = false;
        public bool[] dool = { true, true, true, true };
        public bool d_miss = false;
        public bool pulet = false;
        public bool nazo5 = true;
        public bool nazo7 = false;
        public bool fire = false;
        public bool set_wood = false;
        public bool kamado_big = false;

        public int green_num = 0;

        public bool d_cl = false;


        Ui ui = new Ui();
        Key key_nyu = new Key();
        Mis mis = new Mis();

        public void In(Ui ui2)
        {
            ui = ui2;
        }

        public void In3(Mis mis2)
        {
            mis = mis2;
        }

        bool a = false;
        public void Draw(Graphics gr)
        {/*            if (!a)
            {
                ui.Bl((int)Ui.Items.item15);
                ui.Bl((int)Ui.Items.item18);
                ui.Bl((int)Ui.Items.item16);
                ui.Bl((int)Ui.Items.item17);
                a = true;
            }*/

            if (all)
            {

                if (fire)
                {
                    img = test.Properties.Resources.RM6_f;
                    gr.DrawImage(img, point);
                }
                else
                {
                    img = test.Properties.Resources.RM6;
                    gr.DrawImage(img, point);
                }


                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, arrowleft);
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);
                for (int i = 0; i < 4; i++)
                {
                    if (!dish_wash && dish)
                    {
                        img = test.Properties.Resources.rm6d_dish;
                        gr.DrawImage(img, points_dish[i]);
                    }
                    else if (dish_wash && dish)
                    {
                        switch (i)
                        {
                            case 0:
                                img = test.Properties.Resources.rm6dish_1;
                                break;
                            case 1:
                                img = test.Properties.Resources.rm6dish_2;
                                break;
                            case 2:
                                img = test.Properties.Resources.rm6dish_3;
                                break;
                            case 3:
                                img = test.Properties.Resources.rm6dish_4;
                                break;
                        }
                        gr.DrawImage(img, points_dish[i]);
                    }

                    if (dool[i])
                    {
                        switch (i)
                        {
                            case 0:
                                img = test.Properties.Resources.rm6dool_1;
                                break;
                            case 1:
                                img = test.Properties.Resources.rm6dool_2;
                                break;
                            case 2:
                                img = test.Properties.Resources.rm6dool_3;
                                break;
                            case 3:
                                img = test.Properties.Resources.rm6dool_4;
                                break;
                        }
                        gr.DrawImage(img, points_dool[i]);
                    }
                }




                switch (green_num)
                {
                    case 0:
                        img = test.Properties.Resources.t0;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 1:
                        img = test.Properties.Resources.t4;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 2:
                        img = test.Properties.Resources.t8;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 3:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, greennum1);
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 4:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, greennum1);
                        img = test.Properties.Resources.t6;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 5:
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, greennum1);
                        img = test.Properties.Resources.t0;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 6:
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, greennum1);
                        img = test.Properties.Resources.t4;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 7:
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, greennum1);
                        img = test.Properties.Resources.t8;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 8:
                        img = test.Properties.Resources.t3;
                        gr.DrawImage(img, greennum1);
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, greennum2);
                        break;
                    case 9:
                        img = test.Properties.Resources.t3;
                        gr.DrawImage(img, greennum1);
                        img = test.Properties.Resources.t6;
                        gr.DrawImage(img, greennum2);
                        break;
                }

            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (kamado_big)
            {
                if (fire)
                {
                    img = test.Properties.Resources.rm6fire_big;
                    gr.DrawImage(img, point);
                    if (pulet)
                    {
                        img = test.Properties.Resources.rm6pulet;
                        gr.DrawImage(img, point_pulet);
                    }
                    if (nazo7)
                    {
                        img = test.Properties.Resources.rm6kamado_nazo7;
                        gr.DrawImage(img, point_nazo7);
                    }
                }
                else
                {
                    img = test.Properties.Resources.rm6kamado_big;
                    gr.DrawImage(img, point);
                    if (depression)
                    {
                        img = test.Properties.Resources.rm6depression;
                        gr.DrawImage(img, point_depression);
                        if (nazo5)
                        {
                            img = test.Properties.Resources.rm6nazo5;
                            gr.DrawImage(img, point_nazo5);
                        }
                    }
                    if (set_wood)
                    {
                        img = test.Properties.Resources.rm6kamado_maki;
                        gr.DrawImage(img, point_maki);
                    }
                }
                img = test.Properties.Resources.rm6kamado_saku;
                gr.DrawImage(img, point_saku);
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }

            ui.Draw(gr);
        }
        public int Loc(int x, int y)
        {
            if (all)
            {

                if (x > 770 && x < 815 && y > 143 && y < 185 && ui.item[ui.item_selet] == (int)Ui.Items.item1 && !depression)
                {
                    depression = true;
                    Audio.Play_block_fall();
                }

                if (x > 220 && x < 285 && y > 390 && y < 490 && dool[0])
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        dool[0] = false;
                        ui.Bl((int)Ui.Items.item24);
                    }
                }
                else if (x > 220 && x < 285 && y > 390 && y < 490 && !dool[0])
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item24)
                    {
                        ui.Dl(ui.item_selet);
                        dool[0] = true;
                    }
                }
                else if (x > 395 && x < 450 && y > 360 && y < 420 && dool[1])
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        dool[1] = false;
                        ui.Bl((int)Ui.Items.item25);
                    }
                }
                else if (x > 395 && x < 450 && y > 360 && y < 420 && !dool[1])
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item25)
                    {
                        ui.Dl(ui.item_selet);
                        dool[1] = true;
                    }
                }
                else if (x > 580 && x < 630 && y > 360 && y < 420 && dool[2])
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        dool[2] = false;
                        ui.Bl((int)Ui.Items.item26);
                    }
                }
                else if (x > 580 && x < 630 && y > 360 && y < 420 && !dool[2])
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item26)
                    {
                        ui.Dl(ui.item_selet);
                        dool[2] = true;
                    }
                }
                else if (x > 745 && x < 805 && y > 395 && y < 490 && dool[3])
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        dool[3] = false;
                        ui.Bl((int)Ui.Items.item27);
                    }
                }
                else if (x > 745 && x < 805 && y > 395 && y < 490 && !dool[3])
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item27)
                    {
                        ui.Dl(ui.item_selet);
                        dool[3] = true;
                    }
                }
                else if (x > 425 && x < 600 && y > 325 && y < 425)
                {
                    kamado_big = true;
                }
                else if (x > 325 && x < 705 && y > 425 && y < 485)
                {
                    if (dish)
                    {
                        if (dish_wash)
                        {
                            if (ui.item[4] == (int)Ui.Items.error)
                            {
                                dish = false;
                                ui.Bl((int)Ui.Items.item22_2);
                                Audio.Play_mato_put();
                            }
                        }
                        else
                        {
                            if (ui.item[4] == (int)Ui.Items.error)
                            {
                                dish = false;
                                ui.Bl((int)Ui.Items.item22);
                                Audio.Play_mato_put();
                            }
                        }
                    }
                    else
                    {
                        if (ui.item[ui.item_selet] == (int)Ui.Items.item22)
                        {
                            ui.Dl(ui.item_selet);
                            dish_wash = false;
                            dish = true;
                        }
                        if (ui.item[ui.item_selet] == (int)Ui.Items.item22_2)
                        {
                            ui.Dl(ui.item_selet);
                            dish_wash = true;
                            dish = true;
                        }
                    }
                }

                if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room5;
                }
                if (x > 20 && x < 150 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room7;
                }

            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (kamado_big)
            {
                if (x > 570 && x < 700 && y > 185 && y < 225 && nazo5 && depression && !fire)
                {
                    mis.n_mis = true;
                    nazo5 = false;
                    mis.qes[(int)Mis.QE.Qes5] = true;
                    Audio.Play_misdis();
                }

                if (x > 225 && x < 775 && y > 405 && y < 580 && fire)
                {

                    if (ui.item[ui.item_selet] == (int)Ui.Items.item18)
                    {
                        if (pulet)
                        {
                            if (ui.item[4] == (int)Ui.Items.error)
                            {
                                ui.Bl((int)Ui.Items.item28);
                                pulet = false;
                            }
                        }
                        else if (nazo7)
                        {
                            mis.n_mis = true;
                            nazo7 = false;
                            mis.qes[(int)Mis.QE.Qes7] = true;
                            Audio.Play_misdis();
                        }
                    }

                }

                if (x > 225 && x < 775 && y > 405 && y < 580 && !fire && !set_wood)
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item15)
                    {
                        ui.Dl(ui.item_selet);
                        set_wood = true;
                        Audio.Play_wood_put();
                    }
                }
                else if (x > 225 && x < 775 && y > 405 && y < 580 && !fire && set_wood)
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item16)
                    {
                        ui.Dl(ui.item_selet);
                        fire = true;
                        Audio.Play_wood_fire();
                    }
                }
                else if (x > 225 && x < 775 && y > 200 && y < 580 && fire)
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item24)
                    {
                        d_miss = true;
                        ui.Dl(ui.item_selet);
                        Audio.Play_dool_fine();
                    }
                    else if (ui.item[ui.item_selet] == (int)Ui.Items.item25)
                    {
                        pulet = true;
                        Audio.Play_wood_fire();
                        ui.Dl(ui.item_selet);
                    }
                    else if (ui.item[ui.item_selet] == (int)Ui.Items.item26)
                    {
                        d_miss = true;
                        ui.Dl(ui.item_selet);
                        Audio.Play_dool_fine();
                    }
                    else if (ui.item[ui.item_selet] == (int)Ui.Items.item27)
                    {
                        d_miss = true;
                        ui.Dl(ui.item_selet);
                        Audio.Play_dool_fine();
                    }
                    else if (ui.item[ui.item_selet] == (int)Ui.Items.item17)
                    {
                        nazo7 = true;
                        ui.Dl(ui.item_selet);
                        Audio.Play_dool_fine();
                    }
                }


                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    kamado_big = false;
                }
            }

            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room6;
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
            string str2 = "15";
            if (str == str2)
            {
                box_open = true;
            }
            else
            {
                nyu_click = false;
                key_nyu.Nl();

            }
            All();
        }
        */
        public override void Nl()
        {

            all = true;
            depression = false;
            dish = true;
            dish_wash = false;
            for (int i = 0; i < 4; i++)
            {
                dool[i] = true;

            }
            d_miss = false;
            pulet = false;
            nazo5 = true;
            nazo7 = false;
            fire = false;
            set_wood = false;
            kamado_big = false;

            green_num = 0;

            d_cl = false;
        }

        public void All()
        {
            if (d_cl || kamado_big)
            {
                all = false;
            }
            else
            {
                all = true;
            }
        }

        public Ui N_ui()
        {
            return ui;
        }
        public void Num_get(int x)
        {
            green_num = x;
        }

    }
}