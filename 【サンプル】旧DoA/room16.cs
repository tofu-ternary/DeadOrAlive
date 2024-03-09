using System.Drawing;

namespace test
{
    class Room16 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point point_tyen = new Point(665, 410);
        Point point_book = new Point(740, 420);
        Point point_book2 = new Point(715, 400);
        Point point_key = new Point(765, 428);
        Point point_rmi = new Point(5, 455);

        Point arrowleft = new Point(25, 300);
        Point arrowright = new Point(900, 300);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool d_cl = false;


        public bool t_lock = true;
        public bool tyen = true;
        public bool b_lock = true;
        public bool y_key = true;

        public bool t_set = false;
        public bool t_set2 = false;

        public bool t_big = false;

        public bool remain1 = false;
        public bool remain2 = false;

        public int spen = 0;

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


        public bool a = true;
        public void Draw(Graphics gr)
        {
            /*
            if (a)
            {
                a = false;
                ui.Bl((int)Ui.Items.item35);
                ui.Bl((int)Ui.Items.item34);
            }*/
            if (all)
            {
                if (!t_set)
                {
                    img = test.Properties.Resources.RM16;
                    gr.DrawImage(img, point);
                }
                else if (t_set)
                {
                    img = test.Properties.Resources.RM16_2;
                    gr.DrawImage(img, point);
                }
                if (b_lock)
                {
                    img = test.Properties.Resources.rm16book1;
                    gr.DrawImage(img, point_book);
                }
                else
                {
                    img = test.Properties.Resources.rm16book2;
                    gr.DrawImage(img, point_book2);
                    if (y_key)
                    {
                        img = test.Properties.Resources.rm16key;
                        gr.DrawImage(img, point_key);
                    }
                }
                if (t_lock && tyen)
                {
                    img = test.Properties.Resources.rm16tyen1;
                    gr.DrawImage(img, point_tyen);
                }
                else if (!t_lock && tyen)
                {
                    img = test.Properties.Resources.rm16tyen2;
                    gr.DrawImage(img, point_tyen);
                }



                if (remain2)
                {
                    img = test.Properties.Resources.rm16tyen4;
                    gr.DrawImage(img, point_rmi);
                }
                else if (remain1)
                {
                    img = test.Properties.Resources.rm16tyen5;
                    gr.DrawImage(img, point_rmi);
                }




                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, arrowleft);
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);
            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (t_big)
            {
                if (!t_set && !t_set2 || t_set2 && !t_set)
                {
                    img = test.Properties.Resources.rm16tyenbig;
                    gr.DrawImage(img, point);
                }
                else if (t_set && !t_set2)
                {
                    img = test.Properties.Resources.rm16tyenbig_on;
                    gr.DrawImage(img, point);
                }
                else if (t_set && t_set2)
                {
                    if (spen == 0 || spen == 2)
                    {
                        img = test.Properties.Resources.rm16tyenbig_on2;
                        gr.DrawImage(img, point);
                    }
                    else
                    {
                        img = test.Properties.Resources.rm16tyenbig_on3;
                        gr.DrawImage(img, point);
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
                if (x > 690 && x < 860 && y > 490 && y < 550 && !t_lock && tyen)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        tyen = false;
                        ui.Bl((int)Ui.Items.item36);
                    }
                }
                else if (x > 690 && x < 860 && y > 490 && y < 550 && !t_lock && !tyen && ui.item[ui.item_selet] == (int)Ui.Items.item36 && !t_set && !t_set2)
                {
                    ui.Dl(ui.item_selet);
                    tyen = true;
                }
                if (x > 715 && x < 875 && y > 430 && y < 550 && ui.item[ui.item_selet] == (int)Ui.Items.item34 && t_lock)
                {
                    t_lock = false;
                    Audio.Play_chain_cut();
                }


                if (x > 745 && x < 800 && y > 425 && y < 475 && !t_lock && !b_lock)
                {
                    y_key = false;
                    ui.key[(int)Ui.Keys.yellow] = true;
                    Menu.n_menu = true;
                    Audio.Play_menudis();
                }

                if (x > 745 && x < 800 && y > 425 && y < 475 && !t_lock && ui.item[ui.item_selet] == (int)Ui.Items.item35 && b_lock)
                {
                    ui.Dl(ui.item_selet);
                    Audio.Play_valve_set();
                    b_lock = false;
                }

                if (x > 255 && x < 470 && y > 240 && y < 540)
                {
                    t_big = true;
                }

                if (x > 20 && x < 150 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room17;
                }
                else if (x > 900 && x < 1025 && y > 300 && y < 375)
                {

                    int wh_i = ui.WH_i((int)Ui.Items.item36);
                    if (!t_set2 && wh_i != 5 && t_set)
                    {
                        ui.Dl(wh_i);
                        remain1 = true;
                    }
                    if (t_set2 && wh_i != 5 && !t_set)
                    {
                        ui.Dl(wh_i);
                        remain2 = true;
                    }
                    Audio.Play_move();
                    return (int)Form1.RM.room15;
                }

                if (x > 0 && x < 125 && y > 510 && y < 580 && remain1)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        remain1 = false;
                        ui.Bl((int)Ui.Items.item36);
                    }
                }
                else if (x > 0 && x < 250 && y > 510 && y < 580 && remain2)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        remain2 = false;
                        ui.Bl((int)Ui.Items.item36);
                    }
                }

            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (t_big)
            {

                if (x > 335 && x < 680 && y > 120 && y < 485 && spen != 2 && t_set && t_set2)
                {
                    Audio.Play_chain_move();
                    spen++;
                    if(spen == 2)
                    {
                        Audio.Play_box_max();
                    }
                }

                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    t_big = false;
                }
                if (x > 255 && x < 740 && y > 50 && y < 545 && ui.item[ui.item_selet] == (int)Ui.Items.item36 && !t_set)
                {
                    Audio.Play_chain_set();
                    t_set = true;
                    if (t_set2)
                    {
                        ui.Dl(ui.item_selet);
                    }
                }

            }



            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room16;
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
            string str2 = "abcd";
            if (str == str2)
            {

            }
            else
            {

            }
            All();
        }

        public override void Nl()
        {
            all = true;

            d_cl = false;

            t_lock = true;
            tyen = true;
            b_lock = true;
            y_key = true;

            t_set = false;
            t_set2 = false;

            t_big = false;

            remain1 = false;
            remain2 = false;
        }

        public void All()
        {
            if (d_cl || t_big)
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