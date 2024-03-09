using System.Drawing;

namespace test
{
    class Room17 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point[] point_box = { new Point(185, 405), new Point(560, 405), new Point(830, 405) };
        Point point_key = new Point(300, 300);

        Point point_tyen = new Point(820, 575);

        Point arrowleft = new Point(25, 300);
        Point arrowright = new Point(900, 300);

        Point bulenum1 = new Point(115, 180);
        Point bulenum2 = new Point(150, 180);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool t_set = false;
        public int box_move = 0;
        public bool box_big = false;
        public bool box_open = false;
        public bool t_noset = false;
        public bool tyen = false;

        public bool h_key = true;

        public bool nyu_click = false;

        public int bule_num = 0;

        public bool d_cl = false;


        Ui ui = new Ui();
        Key key_nyu = new Key();
        Mis mis = new Mis();
        Room16 r16 = new Room16();

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

        public void In4(Room16 c_r16)
        {
            r16 = c_r16;
        }


        public void Draw(Graphics gr)
        {
            if (all)
            {
                box_move = r16.spen;
                img = test.Properties.Resources.RM17;
                gr.DrawImage(img, point);

                if (!r16.t_set2)
                {
                    img = test.Properties.Resources.rm17box;
                    gr.DrawImage(img, point_box[0]);
                }
                else if (!r16.t_set && r16.t_set2 && tyen)
                {
                    img = test.Properties.Resources.rm17box_tyen4;
                    gr.DrawImage(img, point_box[0]);
                }
                else if (!r16.t_set && r16.t_set2)
                {
                    img = test.Properties.Resources.rm17box_tyen5;
                    gr.DrawImage(img, point_box[0]);
                }
                else if (r16.t_set && r16.t_set2 && box_move == 0)
                {
                    img = test.Properties.Resources.rm17box_tyen1;
                    gr.DrawImage(img, point_box[0]);
                }
                else if (r16.t_set && r16.t_set2 && box_move == 1)
                {
                    img = test.Properties.Resources.rm17box_tyen2;
                    gr.DrawImage(img, point_box[1]);
                }
                else if (r16.t_set && r16.t_set2 && box_move == 2)
                {
                    img = test.Properties.Resources.rm17box_tyen3;
                    gr.DrawImage(img, point_box[2]);
                }
                if (r16.t_set && !r16.t_set2 && t_noset)
                {
                    img = test.Properties.Resources.rm17tyen_put;
                    gr.DrawImage(img, point_tyen);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, arrowleft);
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);


                switch (bule_num)
                {
                    case 0:
                        img = test.Properties.Resources.t0;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 1:
                        img = test.Properties.Resources.t3;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 2:
                        img = test.Properties.Resources.t6;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 3:
                        img = test.Properties.Resources.t9;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 4:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, bulenum1);
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 5:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, bulenum1);
                        img = test.Properties.Resources.t5;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 6:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, bulenum1);
                        img = test.Properties.Resources.t8;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 7:
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, bulenum1);
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 8:
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, bulenum1);
                        img = test.Properties.Resources.t4;
                        gr.DrawImage(img, bulenum2);
                        break;
                    case 9:
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, bulenum1);
                        img = test.Properties.Resources.t7;
                        gr.DrawImage(img, bulenum2);
                        break;
                }

            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (box_big)
            {
                if (!box_open)
                {
                    img = test.Properties.Resources.rm17boxbig;
                    gr.DrawImage(img, point);
                    key_nyu.Draw(gr, 0);
                }
                else
                {
                    img = test.Properties.Resources.rm17boxbigopen;
                    gr.DrawImage(img, point);
                    if (h_key)
                    {
                        img = test.Properties.Resources.rm17key2;
                        gr.DrawImage(img, point_key);
                    }
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
                if (t_noset)
                {
                    if (x > 850 && x < 1024 && y > 565 && y < 610)
                    {
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            t_noset = false;
                            ui.Bl((int)Ui.Items.item36);
                        }
                    }
                }
                if (tyen)
                {
                    if (x > 300 && x < 390 && y > 495 && y < 535)
                    {
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            tyen = false;
                            ui.Bl((int)Ui.Items.item36);
                        }
                    }
                }

                switch (box_move)
                {
                    case 0:
                        if (x > 185 && x < 275 && y > 405 && y < 450)
                        {
                            box_big = true;
                            if (box_open)
                            {
                                Audio.Play_door_open();
                            }
                        }
                        break;
                    case 1:
                        if (x > 575 && x < 665 && y > 405 && y < 450)
                        {
                            box_big = true;
                            if (box_open)
                            {
                                Audio.Play_door_open();
                            }
                        }
                        break;
                    case 2:
                        if (x > 830 && x < 930 && y > 405 && y < 450)
                        {
                            box_big = true;
                            if (box_open)
                            {
                                Audio.Play_door_open();
                            }
                        }
                        break;

                }

                if (x > 275 && x < 320 && y > 400 && y < 525 && ui.item[ui.item_selet] == (int)Ui.Items.item36)
                {
                    r16.t_set2 = true;
                    if (r16.t_set)
                    {
                        ui.Dl(ui.item_selet);
                    }
                }
                /*
                if(x > 275 && x < 320 && y > 400 && y < 525 && ui.item[ui.item_selet] == (int)Ui.Items.item36 && !t_set && !r16.t_set)
                {
                    t_set = true;
                    r16.t_set2 = true;
                }
                */


                if (x > 900 && x < 1025 && y > 300 && y < 375)
                {

                    Audio.Play_move();
                    return (int)Form1.RM.room16;
                }
                if (x > 20 && x < 150 && y > 300 && y < 375)
                {
                    int wh_i = ui.WH_i((int)Ui.Items.item36);
                    if (!r16.t_set2 && wh_i != 5 && r16.t_set)
                    {
                        ui.Dl(wh_i);
                        tyen = false;
                        t_noset = true;
                    }
                    if (r16.t_set2 && wh_i != 5 && !r16.t_set)
                    {
                        ui.Dl(wh_i);
                        tyen = true;
                        t_noset = false;
                    }
                    Audio.Play_move();
                    return (int)Form1.RM.room18;
                }

            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (box_big)
            {
                if (box_open)
                {
                    if (x > 410 && x < 495 && y > 380 && y < 470 && h_key)
                    {
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            h_key = false;
                            ui.Bl((int)Ui.Items.item32);
                        }
                    }
                    else if (x > 410 && x < 495 && y > 380 && y < 470 && ui.item[ui.item_selet] == (int)Ui.Items.item32)
                    {
                        ui.Dl(ui.item_selet);
                        h_key = true;
                    }
                }
                else
                {
                    if (x > 135 && x < 475 && y > 370 && y < 465)
                    {
                        nyu_click = true;
                    }
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    box_big = false;
                }
            }


            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room17;
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
            string str2 = "15";
            if (str == str2)
            {
                box_open = true;
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

            t_set = false;
            box_move = 0;
            box_big = false;
            box_open = false;
            t_noset = false;

            h_key = true;

            nyu_click = false;

            tyen = false;
            bule_num = 0;

            d_cl = false;
        }

        public void All()
        {
            if (d_cl || box_big)
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
        }*/
        public void Num_get(int x)
        {
            bule_num = x;
        }

    }
}