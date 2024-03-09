using System.Drawing;

namespace test
{
    class Room8 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point point_q = new Point(0, 0);

        Point arrowleft = new Point(25, 300);
        Point arrowright = new Point(900, 300);
        Point arrowdown = new Point(450, 500);
        Point arrowup = new Point(450, 50);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool d_cl = false;

        Ui ui = new Ui();
        Room3 rm3 = new Room3();
        Mis mis = new Mis();
        Room9 r9 = new Room9();

        public void In(Ui ui2)
        {
            ui = ui2;
        }

        public void In3(Mis c_mis)
        {
            mis = c_mis;
        }

        public void In4(Room9 c_r9)
        {
            r9 = c_r9;
        }


        public void Draw(Graphics gr)
        {
            if (all)
            {
                img = test.Properties.Resources.RM8;
                gr.DrawImage(img, point);

                if (r9.kbm)
                {
                    img = test.Properties.Resources.RM8_q;
                    gr.DrawImage(img, point_q);

                    img = test.Properties.Resources.矢印2;
                    gr.DrawImage(img, arrowup);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, arrowleft);

                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);

                img = test.Properties.Resources.矢印4;
                gr.DrawImage(img, arrowdown);

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
                if (x > 20 && x < 150 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room9;
                }
                else if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room7;
                }
                else if (x > 475 && x < 525 && y > 500 && y < 600)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room4;
                }
                if (r9.kbm)
                {
                    if (x > 475 && x < 525 && y > 50 && y < 165)
                    {
                        Audio.Play_move();
                        return (int)Form1.RM.room13;
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
            return (int)Form1.RM.room8;
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