
using System.Drawing;

namespace test
{
    class Room7 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point point_b = new Point(0, 0);

        Point redrock = new Point(218, 380);
        Point bulerock = new Point(328, 370);
        Point yellowrock = new Point(655, 368);
        Point orangerock = new Point(765, 380);

        Point arrowleft = new Point(25, 300);
        Point arrowright = new Point(900, 300);
        Point arrowback = new Point(450, 50);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool back = true;
        public bool redkey = true;
        public bool bulekey = true;
        public bool yellowkey = true;
        public bool orangekey = true;

        public bool soto = false;
        public bool open = false;

        public bool d_cl = false;

        Ui ui = new Ui();
        Room3 rm3 = new Room3();
        Mis mis = new Mis();

        public void In(Ui ui2)
        {
            ui = ui2;
        }

        public void In3(Mis c_mis)
        {
            mis = c_mis;
        }


        public void Draw(Graphics gr)
        {
            if (all)
            {
                if (back)
                {
                    img = test.Properties.Resources.RM7;
                    gr.DrawImage(img, point);

                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, arrowleft);

                    img = test.Properties.Resources.矢印3;
                    gr.DrawImage(img, arrowright);

                    if (redkey)
                    {
                        img = test.Properties.Resources.RM7_red;
                        gr.DrawImage(img, redrock);
                    }
                    if (bulekey)
                    {
                        img = test.Properties.Resources.RM7_bule;
                        gr.DrawImage(img, bulerock);
                    }
                    if (yellowkey)
                    {
                        img = test.Properties.Resources.RM7_yellow;
                        gr.DrawImage(img, yellowrock);
                    }
                    if (orangekey)
                    {
                        img = test.Properties.Resources.RM7_orange;
                        gr.DrawImage(img, orangerock);
                    }
                }
                else if (!back)
                {

                    if (!open)
                    {
                        img = test.Properties.Resources.RM7_b;
                        gr.DrawImage(img, point_b);
                    }
                    else
                    {
                        img = test.Properties.Resources.RM7_b2;
                        gr.DrawImage(img, point_b);
                    }
                }

                img = test.Properties.Resources.矢印4;
                gr.DrawImage(img, arrowback);
            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            ui.Draw(gr);
        }
        public int Loc(int x, int y)
        {
            if (all)
            {
                if (back)
                {
                    if (x > 220 && x < 260 && y > 380 && y < 537 && ui.key[0])
                    {
                        redkey = false;
                        ui.key[0] = false;
                        Audio.Play_tower_disappear();
                    }
                    if (x > 330 && x < 371 && y > 370 && y < 530 && ui.key[1])
                    {
                        bulekey = false;
                        ui.key[1] = false;
                        Audio.Play_tower_disappear();
                    }
                    if (x > 655 && x < 700 && y > 365 && y < 525 && ui.key[2])
                    {
                        yellowkey = false;
                        ui.key[2] = false;
                        Audio.Play_tower_disappear();
                    }
                    if (x > 767 && x < 810 && y > 380 && y < 535 && ui.key[3])
                    {
                        orangekey = false;
                        ui.key[3] = false;
                        Audio.Play_tower_disappear();

                    }
                    else if (x > 20 && x < 150 && y > 300 && y < 375)
                    {
                        Audio.Play_move();
                        return (int)Form1.RM.room8;
                    }
                    else if (x > 900 && x < 1025 && y > 300 && y < 375)
                    {
                        Audio.Play_move();
                        return (int)Form1.RM.room6;
                    }
                }

                if (x > 475 && x < 525 && y > 50 && y < 165 && back)
                {
                    Audio.Play_move();
                    back = false;
                }
                else if (x > 475 && x < 525 && y > 50 && y < 165 && !back)
                {
                    Audio.Play_move();
                    back = true;
                }
                if (x > 420 && x < 617 && y > 190 && y < 495 && !back)
                {
                    if (ui.item[ui.item_selet] == (int)Ui.Items.item20_1)
                    {
                        ui.Dl(ui.item_selet);
                        open = true;
                        Audio.Play_enddoor_open();
                    }
                    else if (open)
                    {
                        soto = true;
                    }
                }
            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }



            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room7;
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
        public override void Nl()
        {
            all = true;
            back = true;
            redkey = true;
            bulekey = true;
            yellowkey = true;
            orangekey = true;
            open = false;
            soto = false;
            d_cl = false;
        }

        public void All()
        {
            if (d_cl == true)
            {
                all = false;
            }
            else
            {
                all = true;
            }
        }

        public void Num_get(int x)
        {

        }

    }
}