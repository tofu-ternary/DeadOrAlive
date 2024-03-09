using System.Drawing;

namespace test
{
    class Room13 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point point_hasigo = new Point(200, 0);
        Point point_nazo8 = new Point(150, 500);
        Point arrowleft = new Point(25, 300);
        Point arrowright = new Point(900, 300);
        Point arrowdown = new Point(450, 500);
        Point arrowup = new Point(450, 50);

        Point rednum1 = new Point(340, 50);
        Point rednum2 = new Point(380, 50);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool nazo8 = true;
        public bool nazo6 = true;

        public bool d_cl = false;

        public int red_num = 0;


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
        public void In4(Room3 c_rm3)
        {
            rm3 = c_rm3;
        }

        public void Draw(Graphics gr)
        {
            if (all)
            {
                img = test.Properties.Resources.RM13;
                gr.DrawImage(img, point);

                if (rm3.hasigo)
                {
                    img = test.Properties.Resources.rm13hasigo;
                    gr.DrawImage(img, point_hasigo);
                    img = test.Properties.Resources.矢印2;
                    gr.DrawImage(img, arrowup);

                }
                if (nazo8 && rm3.hasigo)
                {
                    img = test.Properties.Resources.rm13nazo8;
                    gr.DrawImage(img, point_nazo8);
                }

                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, arrowleft);
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);
                img = test.Properties.Resources.矢印4;
                gr.DrawImage(img, arrowdown);

                switch (red_num)
                {
                    case 0:
                        img = test.Properties.Resources.t0;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 1:
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 2:
                        img = test.Properties.Resources.t4;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 3:
                        img = test.Properties.Resources.t6;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 4:
                        img = test.Properties.Resources.t8;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 5:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, rednum1);
                        img = test.Properties.Resources.t0;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 6:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, rednum1);
                        img = test.Properties.Resources.t2;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 7:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, rednum1);
                        img = test.Properties.Resources.t4;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 8:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, rednum1);
                        img = test.Properties.Resources.t6;
                        gr.DrawImage(img, rednum2);
                        break;
                    case 9:
                        img = test.Properties.Resources.t1;
                        gr.DrawImage(img, rednum1);
                        img = test.Properties.Resources.t8;
                        gr.DrawImage(img, rednum2);
                        break;
                }

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
                    return (int)Form1.RM.room14;
                }
                else if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room12;
                }
                else if (x > 475 && x < 525 && y > 500 && y < 600)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room8;
                }
                else if (x > 475 && x < 525 && y > 50 && y < 165 && rm3.hasigo)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room18;
                }
                else if (x > 520 && x < 862 && y > 235 && y < 460 && nazo6)
                {
                    nazo6 = false;
                    mis.n_mis = true;
                    mis.qes[(int)Mis.QE.Qes6] = true;
                    Audio.Play_misdis();
                }

                if (nazo8 && rm3.hasigo)
                {
                    if (x > 150 && x < 250 && y > 500 && y < 550)
                    {
                        mis.n_mis = true;
                        nazo8 = false;
                        mis.qes[(int)Mis.QE.Qes8] = true;
                        Audio.Play_misdis();
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
            return (int)Form1.RM.room13;
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
            nazo8 = true;
            nazo6 = true;
            red_num = 0;
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
            red_num = x;
        }

    }
}