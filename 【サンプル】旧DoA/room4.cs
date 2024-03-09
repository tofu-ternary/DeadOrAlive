using System.Drawing;

namespace test
{
    class Room4 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point point_hakoR = new Point(0, 0);
        Point point_hakoL = new Point(0, 0);

        Point point_moeru = new Point(770, 460);
        Point arrowright = new Point(900, 300);
        Point arrowup = new Point(450, 50);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool hakoR = true;
        public bool hakoL = true;

        public bool moeru = true;

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
                if (hakoR && hakoL)
                {
                    img = test.Properties.Resources.RM4;
                    gr.DrawImage(img, point);
                }
                else if (!hakoR)
                {
                    img = test.Properties.Resources.RM4_1;
                    gr.DrawImage(img, point_hakoR);
                    if (moeru)
                    {
                        img = test.Properties.Resources.rm4moeru;
                        gr.DrawImage(img, point_moeru);
                    }
                }
                else if (!hakoL)
                {
                    img = test.Properties.Resources.RM4_2;
                    gr.DrawImage(img, point_hakoL);
                }

                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);

                img = test.Properties.Resources.矢印2;
                gr.DrawImage(img, arrowup);
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
                if (x > 560 && x < 685 && y > 343 && y < 495 && hakoR)
                {
                    hakoR = false;
                    hakoL = true;
                    Audio.Play_slide_door();
                }
                else if (x > 777 && x < 815 && y > 450 && y < 495 && ui.item[4] == (int)Ui.Items.error && moeru && hakoL && !hakoR)
                {
                    moeru = false;
                    ui.Bl((int)Ui.Items.item17);
                }
                else if (x > 675 && x < 815 && y > 375 && y < 550 && ui.item[ui.item_selet] == (int)Ui.Items.item17 && !moeru)
                {
                    ui.Dl(ui.item_selet);
                    moeru = true;
                }
                else if (x > 693 && x < 816 && y > 342 && y < 495)
                {
                    hakoL = false;
                    hakoR = true;
                    Audio.Play_slide_door();
                }
                else if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room3;
                }
                else if (x > 475 && x < 525 && y > 50 && y < 165)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room8;
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
            return (int)Form1.RM.room4;
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

            hakoR = true;
            hakoL = true;

            moeru = true;

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